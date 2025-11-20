using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace Common.Operations
{
    /// <summary>
    /// Reads exported symbols from PCSX2 process to get memory base addresses
    /// Based on the pcsx2_offsetreader implementation
    /// </summary>
    public class PCSX2SymbolReader
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, int dwSize, out int lpNumberOfBytesRead);

        [DllImport("psapi.dll", SetLastError = true)]
        private static extern bool EnumProcessModules(IntPtr hProcess, [Out] IntPtr[] lphModule, uint cb, out uint lpcbNeeded);

        [DllImport("psapi.dll", SetLastError = true)]
        private static extern uint GetModuleFileNameEx(IntPtr hProcess, IntPtr hModule, [Out] StringBuilder lpBaseName, uint nSize);

        [StructLayout(LayoutKind.Sequential)]
        private struct IMAGE_DOS_HEADER
        {
            public ushort e_magic;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 29)]
            public ushort[] e_res;
            public int e_lfanew;
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct IMAGE_FILE_HEADER
        {
            public ushort Machine;
            public ushort NumberOfSections;
            public uint TimeDateStamp;
            public uint PointerToSymbolTable;
            public uint NumberOfSymbols;
            public ushort SizeOfOptionalHeader;
            public ushort Characteristics;
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct IMAGE_OPTIONAL_HEADER64
        {
            public ushort Magic;
            public byte MajorLinkerVersion;
            public byte MinorLinkerVersion;
            public uint SizeOfCode;
            public uint SizeOfInitializedData;
            public uint SizeOfUninitializedData;
            public uint AddressOfEntryPoint;
            public uint BaseOfCode;
            public ulong ImageBase;
            public uint SectionAlignment;
            public uint FileAlignment;
            public ushort MajorOperatingSystemVersion;
            public ushort MinorOperatingSystemVersion;
            public ushort MajorImageVersion;
            public ushort MinorImageVersion;
            public ushort MajorSubsystemVersion;
            public ushort MinorSubsystemVersion;
            public uint Win32VersionValue;
            public uint SizeOfImage;
            public uint SizeOfHeaders;
            public uint CheckSum;
            public ushort Subsystem;
            public ushort DllCharacteristics;
            public ulong SizeOfStackReserve;
            public ulong SizeOfStackCommit;
            public ulong SizeOfHeapReserve;
            public ulong SizeOfHeapCommit;
            public uint LoaderFlags;
            public uint NumberOfRvaAndSizes;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public IMAGE_DATA_DIRECTORY[] DataDirectory;
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct IMAGE_DATA_DIRECTORY
        {
            public uint VirtualAddress;
            public uint Size;
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct IMAGE_EXPORT_DIRECTORY
        {
            public uint Characteristics;
            public uint TimeDateStamp;
            public ushort MajorVersion;
            public ushort MinorVersion;
            public uint Name;
            public uint Base;
            public uint NumberOfFunctions;
            public uint NumberOfNames;
            public uint AddressOfFunctions;
            public uint AddressOfNames;
            public uint AddressOfNameOrdinals;
        }

        /// <summary>
        /// Reads the base addresses from PCSX2's exported symbols
        /// </summary>
        public static bool ReadBaseAddresses(IntPtr processHandle, string processName, out IntPtr eememBase, out IntPtr iopmemBase, out IntPtr vumemBase)
        {
            eememBase = IntPtr.Zero;
            iopmemBase = IntPtr.Zero;
            vumemBase = IntPtr.Zero;

            try
            {
                // Get the base address of the PCSX2 module
                IntPtr moduleBase = GetModuleBaseAddress(processHandle, processName);
                if (moduleBase == IntPtr.Zero)
                {
                    MessageBox.Show("Failed to get PCSX2 module base address!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                // Read the DOS header
                IMAGE_DOS_HEADER dosHeader = ReadStructure<IMAGE_DOS_HEADER>(processHandle, moduleBase);
                if (dosHeader.e_magic != 0x5A4D) // "MZ"
                {
                    MessageBox.Show("Invalid DOS header!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                // Read the NT headers
                IntPtr ntHeadersAddress = moduleBase + dosHeader.e_lfanew;
                uint signature = ReadUInt32(processHandle, ntHeadersAddress);
                if (signature != 0x00004550) // "PE\0\0"
                {
                    MessageBox.Show("Invalid PE signature!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                // Read file header and optional header
                IMAGE_FILE_HEADER fileHeader = ReadStructure<IMAGE_FILE_HEADER>(processHandle, ntHeadersAddress + 4);
                IMAGE_OPTIONAL_HEADER64 optionalHeader = ReadStructure<IMAGE_OPTIONAL_HEADER64>(processHandle, ntHeadersAddress + 4 + Marshal.SizeOf<IMAGE_FILE_HEADER>());

                // Get export directory from data directories (index 0 is the export table)
                if (optionalHeader.DataDirectory == null || optionalHeader.DataDirectory.Length == 0 || optionalHeader.DataDirectory[0].VirtualAddress == 0)
                {
                    MessageBox.Show("No export directory found in PCSX2!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                // Read the export directory
                IMAGE_DATA_DIRECTORY exportDataDir = optionalHeader.DataDirectory[0];
                IntPtr exportDirAddress = moduleBase + (int)exportDataDir.VirtualAddress;
                IMAGE_EXPORT_DIRECTORY exportDir = ReadStructure<IMAGE_EXPORT_DIRECTORY>(processHandle, exportDirAddress);

                // Read the export names
                IntPtr namesAddress = moduleBase + (int)exportDir.AddressOfNames;
                IntPtr functionsAddress = moduleBase + (int)exportDir.AddressOfFunctions;
                IntPtr ordinalsAddress = moduleBase + (int)exportDir.AddressOfNameOrdinals;

                // Search for our symbols
                for (uint i = 0; i < exportDir.NumberOfNames; i++)
                {
                    // Read the RVA of the name
                    uint nameRva = ReadUInt32(processHandle, namesAddress + (int)(i * 4));
                    string name = ReadString(processHandle, moduleBase + (int)nameRva);

                    if (name == "EEmem" || name == "IOPmem" || name == "VUmem")
                    {
                        // Read the ordinal
                        ushort ordinal = ReadUInt16(processHandle, ordinalsAddress + (int)(i * 2));

                        // Read the function RVA
                        uint functionRva = ReadUInt32(processHandle, functionsAddress + (ordinal * 4));
                        IntPtr symbolAddress = moduleBase + (int)functionRva;

                        // IMPORTANT: The symbols EEmem, IOPmem, VUmem are POINTERS to the actual base addresses
                        // We need to dereference them by reading the memory at the symbol address
                        IntPtr baseAddress = ReadIntPtr(processHandle, symbolAddress);

                        // Assign to the appropriate output
                        if (name == "EEmem")
                            eememBase = baseAddress;
                        else if (name == "IOPmem")
                            iopmemBase = baseAddress;
                        else if (name == "VUmem")
                            vumemBase = baseAddress;
                    }
                }

                bool success = eememBase != IntPtr.Zero && iopmemBase != IntPtr.Zero && vumemBase != IntPtr.Zero;

                if (!success)
                {
                    string missing = "";
                    if (eememBase == IntPtr.Zero) missing += "EEmem ";
                    if (iopmemBase == IntPtr.Zero) missing += "IOPmem ";
                    if (vumemBase == IntPtr.Zero) missing += "VUmem ";
                    MessageBox.Show($"Failed to find exported symbols: {missing}\n\nMake sure you're using PCSX2 v1.7 or newer with exported symbols.", "Symbol Read Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                return success;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading PCSX2 symbols: {ex.Message}\n\nStack trace:\n{ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private static IntPtr GetModuleBaseAddress(IntPtr processHandle, string processName)
        {
            try
            {
                IntPtr[] moduleHandles = new IntPtr[1024];
                GCHandle gch = GCHandle.Alloc(moduleHandles, GCHandleType.Pinned);
                IntPtr pModules = gch.AddrOfPinnedObject();

                uint cbNeeded;
                if (!EnumProcessModules(processHandle, moduleHandles, (uint)(moduleHandles.Length * IntPtr.Size), out cbNeeded))
                {
                    gch.Free();
                    return IntPtr.Zero;
                }

                int moduleCount = (int)(cbNeeded / IntPtr.Size);

                for (int i = 0; i < moduleCount; i++)
                {
                    StringBuilder moduleName = new StringBuilder(260);
                    if (GetModuleFileNameEx(processHandle, moduleHandles[i], moduleName, (uint)moduleName.Capacity) > 0)
                    {
                        string fullPath = moduleName.ToString();
                        string fileName = System.IO.Path.GetFileNameWithoutExtension(fullPath);

                        // Match the process name (with or without .exe extension)
                        if (fileName.Equals(processName, StringComparison.OrdinalIgnoreCase) ||
                            fileName.Equals(processName + ".exe", StringComparison.OrdinalIgnoreCase) ||
                            (processName + ".exe").Equals(fileName + ".exe", StringComparison.OrdinalIgnoreCase))
                        {
                            gch.Free();
                            // Return the first module (main executable)
                            return moduleHandles[0];
                        }
                    }
                }

                gch.Free();
                // If we didn't find a specific match, return the first module (main exe)
                return moduleHandles[0];
            }
            catch
            {
                return IntPtr.Zero;
            }
        }

        private static T ReadStructure<T>(IntPtr processHandle, IntPtr address) where T : struct
        {
            int size = Marshal.SizeOf<T>();
            byte[] buffer = new byte[size];

            if (!ReadProcessMemory(processHandle, address, buffer, size, out int bytesRead) || bytesRead != size)
            {
                throw new Exception($"Failed to read {typeof(T).Name} at address {address:X}");
            }

            IntPtr ptr = Marshal.AllocHGlobal(size);
            try
            {
                Marshal.Copy(buffer, 0, ptr, size);
                return Marshal.PtrToStructure<T>(ptr);
            }
            finally
            {
                Marshal.FreeHGlobal(ptr);
            }
        }

        private static uint ReadUInt32(IntPtr processHandle, IntPtr address)
        {
            byte[] buffer = new byte[4];
            if (!ReadProcessMemory(processHandle, address, buffer, 4, out int bytesRead) || bytesRead != 4)
            {
                throw new Exception($"Failed to read UInt32 at address {address:X}");
            }
            return BitConverter.ToUInt32(buffer, 0);
        }

        private static ushort ReadUInt16(IntPtr processHandle, IntPtr address)
        {
            byte[] buffer = new byte[2];
            if (!ReadProcessMemory(processHandle, address, buffer, 2, out int bytesRead) || bytesRead != 2)
            {
                throw new Exception($"Failed to read UInt16 at address {address:X}");
            }
            return BitConverter.ToUInt16(buffer, 0);
        }

        private static IntPtr ReadIntPtr(IntPtr processHandle, IntPtr address)
        {
            byte[] buffer = new byte[IntPtr.Size];
            if (!ReadProcessMemory(processHandle, address, buffer, IntPtr.Size, out int bytesRead) || bytesRead != IntPtr.Size)
            {
                throw new Exception($"Failed to read IntPtr at address {address:X}");
            }
            return (IntPtr)BitConverter.ToInt64(buffer, 0);
        }

        private static string ReadString(IntPtr processHandle, IntPtr address, int maxLength = 256)
        {
            byte[] buffer = new byte[maxLength];
            if (!ReadProcessMemory(processHandle, address, buffer, maxLength, out int bytesRead))
            {
                throw new Exception($"Failed to read string at address {address:X}");
            }

            int nullIndex = Array.IndexOf(buffer, (byte)0);
            if (nullIndex >= 0)
            {
                return Encoding.ASCII.GetString(buffer, 0, nullIndex);
            }

            return Encoding.ASCII.GetString(buffer);
        }
    }
}
