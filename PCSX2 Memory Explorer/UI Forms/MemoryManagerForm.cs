using Common;
using Common.Operations;
using System.Diagnostics;

namespace PCSX2_Memory_Explorer
{
    public partial class MemoryManager : Form
    {
        private IFormFactory formFactory;

        public MemoryManager(IFormFactory formFactory)
        {
            InitializeComponent();
            this.formFactory = formFactory;
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            // Run the external executable to update the base_addresses.txt file
            bool updated = UpdateBaseAddresses();
            if (!updated)
            {
                labelStatus.Text = "Failed to update base addresses!";
                labelStatus.ForeColor = Color.Red;
                return;
            }

            SharedResources.ProcessHandle = MemoryOperations.OpenPCSX2Process("pcsx2-qtx64-avx2");
            if (SharedResources.ProcessHandle == IntPtr.Zero)
            {
                labelStatus.Text = "Failed to connect to PCSX2!";
                labelStatus.ForeColor = Color.Red;
                return;
            }

            if (SharedResources.BaseAddressManager.ReadBaseAddressesFromFile("base_addresses.txt"))
            {
                labelStatus.Text = "Connected to PCSX2 and loaded addresses!";
                labelStatus.ForeColor = Color.Green;
                labelEEmem.Text = $"EEmem: {SharedResources.BaseAddressManager.EEmemBaseAddress.ToString("X")}";
                labelIOPmem.Text = $"IOPmem: {SharedResources.BaseAddressManager.IOPmemBaseAddress.ToString("X")}";
                labelVUmem.Text = $"VUmem: {SharedResources.BaseAddressManager.VUmemBaseAddress.ToString("X")}";
            }
            else
            {
                labelStatus.Text = "Failed to load base addresses!";
                labelStatus.ForeColor = Color.Red;
            }
        }

        private void buttonRead_Click(object sender, EventArgs e)
        {
            if (!ValidateAndGetAddress(out int offset))
            {
                return;
            }

            IntPtr addressToRead = SharedResources.BaseAddressManager.EEmemBaseAddress + offset;
            byte[] buffer = new byte[4];

            bool success = MemoryOperations.ReadMemory(SharedResources.ProcessHandle, addressToRead, buffer, out int bytesRead);

            if (success && bytesRead == buffer.Length)
            {
                int value = BitConverter.ToInt32(buffer, 0);
                textBoxReadValue.Text = value.ToString();
                labelStatus.Text = "Memory read successful!";
                labelStatus.ForeColor = Color.Green;
            }
            else
            {
                labelStatus.Text = "Memory read failed!";
                labelStatus.ForeColor = Color.Red;
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
                IntPtr addressToWrite = SharedResources.BaseAddressManager.EEmemBaseAddress + offset;
                byte[] buffer = BitConverter.GetBytes(value);

                bool success = MemoryOperations.WriteMemory(SharedResources.ProcessHandle, addressToWrite, buffer, out int bytesWritten);

                if (success && bytesWritten == buffer.Length)
                {
                    labelStatus.Text = "Memory write successful!";
                    labelStatus.ForeColor = Color.Green;
                }
                else
                {
                    labelStatus.Text = "Memory write failed!";
                    labelStatus.ForeColor = Color.Red;
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

            IntPtr addressToView = SharedResources.BaseAddressManager.EEmemBaseAddress + offset;
            MemoryViewerForm memoryViewerForm = new MemoryViewerForm();
            memoryViewerForm.LoadMemory(SharedResources.ProcessHandle, SharedResources.BaseAddressManager.EEmemBaseAddress, addressToView, 0x100);
            memoryViewerForm.Show();
        }

        private bool ValidateAndGetAddress(out int offset)
        {
            offset = 0;

            if (SharedResources.BaseAddressManager.EEmemBaseAddress == IntPtr.Zero)
            {
                labelStatus.Text = "Not connected to process!";
                labelStatus.ForeColor = Color.Red;
                return false;
            }

            string addressText = textBoxMemAddress.Text;

            if (string.IsNullOrEmpty(addressText))
            {
                labelStatus.Text = "Memory address is empty!";
                labelStatus.ForeColor = Color.Red;
                return false;
            }

            if (addressText.StartsWith("0x", StringComparison.OrdinalIgnoreCase))
            {
                addressText = addressText.Substring(2);
            }

            if (!Int32.TryParse(addressText, System.Globalization.NumberStyles.HexNumber, null, out offset))
            {
                labelStatus.Text = "Invalid memory address!";
                labelStatus.ForeColor = Color.Red;
                return false;
            }

            return true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedText = comboBox1.SelectedItem.ToString();

            try
            {
                Form form = formFactory.CreateForm(selectedText);
                form.Show();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool UpdateBaseAddresses()
        {
            // Define the path to the external executable
            string exePath = "pcsx2_offsetreader_external.exe";
            try
            {
                // Set up the process start information
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = exePath,
                    WorkingDirectory = AppDomain.CurrentDomain.BaseDirectory, // Ensure it runs in the same directory as the executable
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = true
                };

                // Start the process
                using (Process process = Process.Start(startInfo))
                {
                    // Wait for the process to exit and check the exit code
                    process.WaitForExit();
                    return process.ExitCode == 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error running {exePath}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
