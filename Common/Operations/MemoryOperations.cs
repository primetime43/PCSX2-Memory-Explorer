using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Common.Operations
{
    public class MemoryOperations
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, int dwSize, out int lpNumberOfBytesRead);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, int dwSize, out int lpNumberOfBytesWritten);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool CloseHandle(IntPtr hObject);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern IntPtr GetModuleHandle(string lpModuleName);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern IntPtr GetProcAddress(IntPtr hModule, string lpProcName);

        const int PROCESS_VM_READ = 0x0010;
        const int PROCESS_VM_WRITE = 0x0020;
        const int PROCESS_VM_OPERATION = 0x0008;
        const int PROCESS_ALL_ACCESS = 0x001F0FFF;

        public static IntPtr OpenPCSX2Process(string processName, bool suppressErrors = false)
        {
            Process[] processes = Process.GetProcessesByName(processName);
            if (processes.Length == 0)
            {
                if (!suppressErrors)
                {
                    MessageBox.Show($"{processName} process not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return IntPtr.Zero;
            }

            Process process = processes[0];
            IntPtr processHandle = OpenProcess(PROCESS_ALL_ACCESS, false, process.Id);
            if (processHandle == IntPtr.Zero)
            {
                if (!suppressErrors)
                {
                    MessageBox.Show($"Failed to open process! Error: {Marshal.GetLastWin32Error()}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return IntPtr.Zero;
            }

            return processHandle;
        }

        public static IntPtr GetSymbolAddress(IntPtr processHandle, string moduleName, string symbolName)
        {
            IntPtr moduleHandle = GetModuleHandle(moduleName);
            if (moduleHandle == IntPtr.Zero)
            {
                MessageBox.Show($"Failed to get module handle! Error: {Marshal.GetLastWin32Error()}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return IntPtr.Zero;
            }

            IntPtr symbolAddress = GetProcAddress(moduleHandle, symbolName);
            if (symbolAddress == IntPtr.Zero)
            {
                MessageBox.Show($"Failed to get procedure address! Error: {Marshal.GetLastWin32Error()}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return IntPtr.Zero;
            }

            byte[] addressBuffer = new byte[IntPtr.Size];
            if (!ReadProcessMemory(processHandle, symbolAddress, addressBuffer, addressBuffer.Length, out int bytesRead) || bytesRead != addressBuffer.Length)
            {
                MessageBox.Show($"Failed to read process memory! Error: {Marshal.GetLastWin32Error()}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return IntPtr.Zero;
            }

            return (IntPtr)BitConverter.ToInt64(addressBuffer, 0);
        }

        public static bool ReadMemory(IntPtr processHandle, IntPtr address, byte[] buffer, out int bytesRead)
        {
            return ReadProcessMemory(processHandle, address, buffer, buffer.Length, out bytesRead);
        }

        public static bool WriteMemory(IntPtr processHandle, IntPtr address, byte[] buffer, out int bytesWritten)
        {
            return WriteProcessMemory(processHandle, address, buffer, buffer.Length, out bytesWritten);
        }
    }
}
