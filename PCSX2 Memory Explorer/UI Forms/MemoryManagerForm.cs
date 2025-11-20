using Common;
using Common.Operations;

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
            // Try to connect to PCSX2 process (try multiple common process names)
            string[] possibleNames = { "pcsx2-qt", "pcsx2-qtx64-avx2", "pcsx2x64", "pcsx2" };
            string connectedProcessName = null;

            foreach (string processName in possibleNames)
            {
                SharedResources.ProcessHandle = MemoryOperations.OpenPCSX2Process(processName, suppressErrors: true);
                if (SharedResources.ProcessHandle != IntPtr.Zero)
                {
                    connectedProcessName = processName;
                    break;
                }
            }

            if (SharedResources.ProcessHandle == IntPtr.Zero)
            {
                labelStatus.Text = "PCSX2 not found! Make sure it's running.";
                labelStatus.ForeColor = Color.Red;
                return;
            }

            // Read base addresses directly from PCSX2's exported symbols
            if (SharedResources.BaseAddressManager.ReadBaseAddressesFromProcess(SharedResources.ProcessHandle, connectedProcessName))
            {
                labelStatus.Text = $"Connected to {connectedProcessName}!";
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
            // Check if connected to PCSX2
            if (SharedResources.ProcessHandle == IntPtr.Zero || SharedResources.BaseAddressManager.EEmemBaseAddress == IntPtr.Zero)
            {
                labelStatus.Text = "Not connected to PCSX2!";
                labelStatus.ForeColor = Color.Red;
                return;
            }

            // Try to get address from textbox if provided, otherwise start at 0x0
            IntPtr startAddress = IntPtr.Zero;
            if (ValidateAndGetAddress(out int offset, showEmptyError: false))
            {
                startAddress = new IntPtr(offset);
            }

            MemoryViewerForm memoryViewerForm = new MemoryViewerForm();
            memoryViewerForm.LoadMemory(SharedResources.ProcessHandle, SharedResources.BaseAddressManager.EEmemBaseAddress, startAddress);
            memoryViewerForm.Show();
        }

        private bool ValidateAndGetAddress(out int offset)
        {
            return ValidateAndGetAddress(out offset, showEmptyError: true);
        }

        private bool ValidateAndGetAddress(out int offset, bool showEmptyError)
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
                if (showEmptyError)
                {
                    labelStatus.Text = "Memory address is empty!";
                    labelStatus.ForeColor = Color.Red;
                }
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

    }
}
