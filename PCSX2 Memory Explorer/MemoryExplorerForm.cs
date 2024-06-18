using System;
using System.IO;
using System.Windows.Forms;

namespace PCSX2_Memory_Explorer
{
    public partial class MemoryManager : Form
    {
        private IntPtr processHandle = IntPtr.Zero;
        private IntPtr EEmemBaseAddress = IntPtr.Zero;
        private IntPtr IOPmemBaseAddress = IntPtr.Zero;
        private IntPtr VUmemBaseAddress = IntPtr.Zero;

        public MemoryManager()
        {
            InitializeComponent();
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            // Open the PCSX2 process
            processHandle = Program.OpenPCSX2Process("pcsx2-qtx64-avx2");
            if (processHandle == IntPtr.Zero)
            {
                labelStatus.Text = "Failed to connect to PCSX2!";
                labelStatus.ForeColor = System.Drawing.Color.Red;
                return;
            }

            // Read base addresses from file
            if (ReadBaseAddressesFromFile())
            {
                labelStatus.Text = "Connected to PCSX2 and loaded addresses!";
                labelStatus.ForeColor = System.Drawing.Color.Green;
                labelEEmem.Text = $"EEmem: {EEmemBaseAddress.ToString("X")}";
                labelIOPmem.Text = $"IOPmem: {IOPmemBaseAddress.ToString("X")}";
                labelVUmem.Text = $"VUmem: {VUmemBaseAddress.ToString("X")}";
            }
            else
            {
                labelStatus.Text = "Failed to load base addresses!";
                labelStatus.ForeColor = System.Drawing.Color.Red;
            }
        }

        private bool ReadBaseAddressesFromFile()
        {
            try
            {
                string[] lines = File.ReadAllLines("base_addresses.txt");
                foreach (var line in lines)
                {
                    if (line.StartsWith("EEmem:"))
                        EEmemBaseAddress = (IntPtr)Convert.ToInt64(line.Split(' ')[1], 16);
                    else if (line.StartsWith("IOPmem:"))
                        IOPmemBaseAddress = (IntPtr)Convert.ToInt64(line.Split(' ')[1], 16);
                    else if (line.StartsWith("VUmem:"))
                        VUmemBaseAddress = (IntPtr)Convert.ToInt64(line.Split(' ')[1], 16);
                }
                return EEmemBaseAddress != IntPtr.Zero && IOPmemBaseAddress != IntPtr.Zero && VUmemBaseAddress != IntPtr.Zero;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading base addresses: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void buttonRead_Click(object sender, EventArgs e)
        {
            if (!ValidateAndGetAddress(out int offset))
            {
                return;
            }

            IntPtr addressToRead = EEmemBaseAddress + offset;
            byte[] buffer = new byte[4]; // Assuming we're reading a 4-byte integer

            bool success = Program.ReadProcessMemory(processHandle, addressToRead, buffer, buffer.Length, out int bytesRead);

            if (success && bytesRead == buffer.Length)
            {
                int value = BitConverter.ToInt32(buffer, 0);
                textBoxReadValue.Text = value.ToString();
                labelStatus.Text = "Memory read successful!";
                labelStatus.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                labelStatus.Text = "Memory read failed!";
                labelStatus.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void buttonWrite_Click(object sender, EventArgs e)
        {
            if (!ValidateAndGetAddress(out int offset))
            {
                return;
            }

            if (int.TryParse(textBoxWriteValue.Text, out int value))
            {
                IntPtr addressToWrite = EEmemBaseAddress + offset;
                byte[] buffer = BitConverter.GetBytes(value);

                bool success = Program.WriteProcessMemory(processHandle, addressToWrite, buffer, buffer.Length, out int bytesWritten);

                if (success && bytesWritten == buffer.Length)
                {
                    labelStatus.Text = "Memory write successful!";
                    labelStatus.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    labelStatus.Text = "Memory write failed!";
                    labelStatus.ForeColor = System.Drawing.Color.Red;
                }
            }
            else
            {
                labelStatus.Text = "Invalid input!";
            }
        }

        private void buttonViewMemory_Click(object sender, EventArgs e)
        {
            if (!ValidateAndGetAddress(out int offset))
            {
                return;
            }

            IntPtr addressToView = EEmemBaseAddress + offset;

            // Open the MemoryViewerForm and load memory around the specified address
            MemoryViewerForm memoryViewerForm = new MemoryViewerForm();
            memoryViewerForm.LoadMemory(processHandle, EEmemBaseAddress, addressToView, 0x100); // Adjust the size as needed
            memoryViewerForm.Show();
        }

        private bool ValidateAndGetAddress(out int offset)
        {
            offset = 0;

            if (EEmemBaseAddress == IntPtr.Zero)
            {
                labelStatus.Text = "Not connected to process!";
                labelStatus.ForeColor = System.Drawing.Color.Red;
                return false;
            }

            string addressText = textBoxMemAddress.Text;

            if (string.IsNullOrEmpty(addressText))
            {
                labelStatus.Text = "Memory address is empty!";
                labelStatus.ForeColor = System.Drawing.Color.Red;
                return false;
            }

            // Remove the "0x" prefix if it exists
            if (addressText.StartsWith("0x", StringComparison.OrdinalIgnoreCase))
            {
                addressText = addressText.Substring(2);
            }

            if (!Int32.TryParse(addressText, System.Globalization.NumberStyles.HexNumber, null, out offset))
            {
                labelStatus.Text = "Invalid memory address!";
                labelStatus.ForeColor = System.Drawing.Color.Red;
                return false;
            }

            return true;
        }
    }
}
