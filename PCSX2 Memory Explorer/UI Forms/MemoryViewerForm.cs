using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace PCSX2_Memory_Explorer
{
    public partial class MemoryViewerForm : Form
    {
        // Import necessary Windows API functions
        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, int dwSize, out int lpNumberOfBytesRead);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern int VirtualQueryEx(IntPtr hProcess, IntPtr lpAddress, out MEMORY_BASIC_INFORMATION lpBuffer, uint dwLength);

        // Structure to hold memory information
        [StructLayout(LayoutKind.Sequential)]
        public struct MEMORY_BASIC_INFORMATION
        {
            public IntPtr BaseAddress;
            public IntPtr AllocationBase;
            public uint AllocationProtect;
            public IntPtr RegionSize;
            public uint State;
            public uint Protect;
            public uint Type;
        }

        // Constants for memory protection options
        const uint PAGE_NOACCESS = 0x01;
        const uint PAGE_READONLY = 0x02;
        const uint PAGE_READWRITE = 0x04;
        const uint PAGE_WRITECOPY = 0x08;
        const uint PAGE_EXECUTE = 0x10;
        const uint PAGE_EXECUTE_READ = 0x20;
        const uint PAGE_EXECUTE_READWRITE = 0x40;
        const uint PAGE_EXECUTE_WRITECOPY = 0x80;
        const uint PAGE_GUARD = 0x100;
        const uint PAGE_NOCACHE = 0x200;
        const uint PAGE_WRITECOMBINE = 0x400;

        // Variables to store the parameters for reloading memory
        private IntPtr _processHandle;
        private IntPtr _baseAddress;
        private IntPtr _addressOfFocus;
        private int _size;

        public MemoryViewerForm()
        {
            InitializeComponent();
        }

        // Method to load memory and display it in the RichTextBox
        public void LoadMemory(IntPtr processHandle, IntPtr baseAddress, IntPtr addressOfFocus, int size)
        {
            // Store the parameters for reloading memory
            _processHandle = processHandle;
            _baseAddress = baseAddress;
            _addressOfFocus = addressOfFocus;
            _size = size;

            // Calculate the starting address to read from, centered around the focus address
            IntPtr startAddress = addressOfFocus - size / 2;
            byte[] buffer = new byte[size]; // Buffer to hold the memory content
            int bytesReadTotal = 0; // Counter for total bytes read
            bool success = true; // Flag to track success of memory reading

            StringBuilder sb = new StringBuilder(); // StringBuilder to construct the memory display text

            // Loop to read memory in chunks
            for (int i = 0; i < size; i += 4)
            {
                int chunkSize = Math.Min(4, size - i); // Determine the size of the chunk to read
                byte[] chunkBuffer = new byte[chunkSize]; // Buffer for the current chunk
                IntPtr currentAddress = startAddress + i; // Calculate the current address to read

                // Check memory protection
                MEMORY_BASIC_INFORMATION mbi;
                int result = VirtualQueryEx(processHandle, currentAddress, out mbi, (uint)Marshal.SizeOf(typeof(MEMORY_BASIC_INFORMATION)));

                // If memory is not readable, skip to the next chunk
                if (result == 0 || (mbi.Protect & (PAGE_READONLY | PAGE_READWRITE | PAGE_WRITECOPY | PAGE_EXECUTE_READ | PAGE_EXECUTE_READWRITE | PAGE_EXECUTE_WRITECOPY)) == 0)
                {
                    sb.AppendLine($"Address {currentAddress.ToInt64():X8} is not readable. Protection: {mbi.Protect}");
                    continue;
                }

                // Read memory chunk
                success = ReadProcessMemory(processHandle, currentAddress, chunkBuffer, chunkSize, out int bytesRead);

                // If reading fails, log the error and break the loop
                if (!success || bytesRead != chunkSize)
                {
                    sb.AppendLine($"Error reading memory at {currentAddress.ToInt64():X8}: {Marshal.GetLastWin32Error()}");
                    break;
                }

                // Copy the chunk to the main buffer
                Array.Copy(chunkBuffer, 0, buffer, i, chunkSize);
                bytesReadTotal += bytesRead;

                // Construct the memory display line
                if (checkBoxDisplayRawAddresses.Checked)
                {
                    sb.AppendFormat("{0:X8}  ", currentAddress.ToInt64());
                }
                else
                {
                    sb.AppendFormat("{0:X8}  ", (currentAddress.ToInt64() - baseAddress.ToInt64()));
                }

                for (int j = 0; j < chunkSize; j++)
                {
                    sb.AppendFormat("{0:X2} ", chunkBuffer[j]);
                }
                sb.AppendLine();
            }

            // Set the constructed text to the RichTextBox
            richTextBoxMemory.Text = sb.ToString();

            // If reading memory failed, show an error message
            if (!success)
            {
                MessageBox.Show($"Total bytes read: {bytesReadTotal}. Error reading memory: {Marshal.GetLastWin32Error()}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event handler for checkbox state change
        private void checkBoxDisplayRawAddresses_CheckedChanged(object sender, EventArgs e)
        {
            // Reload the memory view when the checkbox state changes
            LoadMemory(_processHandle, _baseAddress, _addressOfFocus, _size);
        }
    }
}
