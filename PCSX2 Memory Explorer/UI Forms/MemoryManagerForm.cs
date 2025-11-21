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
            string[] possibleNames = { "pcsx2-qt", "pcsx2-qtx64-avx2", "pcsx2x64", "pcsx2" };
            string? connectedProcessName = null;

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

            if (SharedResources.BaseAddressManager.ReadBaseAddressesFromProcess(SharedResources.ProcessHandle, connectedProcessName!))
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

        private void buttonViewMemory_Click(object sender, EventArgs e)
        {
            if (SharedResources.ProcessHandle == IntPtr.Zero || SharedResources.BaseAddressManager.EEmemBaseAddress == IntPtr.Zero)
            {
                labelStatus.Text = "Not connected to PCSX2!";
                labelStatus.ForeColor = Color.Red;
                return;
            }

            IntPtr startAddress = IntPtr.Zero;
            if (ValidateAndGetAddress(out int offset, showEmptyError: false))
            {
                startAddress = new IntPtr(offset);
            }

            MemoryViewerForm memoryViewerForm = new MemoryViewerForm();
            memoryViewerForm.LoadMemory(SharedResources.ProcessHandle, SharedResources.BaseAddressManager.EEmemBaseAddress, startAddress);
            memoryViewerForm.Show();
        }

        private void buttonOpenGame_Click(object sender, EventArgs e)
        {
            OpenSelectedGame();
        }

        private void listBoxGames_DoubleClick(object sender, EventArgs e)
        {
            OpenSelectedGame();
        }

        private void OpenSelectedGame()
        {
            if (listBoxGames.SelectedItem == null)
            {
                labelStatus.Text = "Please select a game first";
                return;
            }

            string? selectedGame = listBoxGames.SelectedItem.ToString();
            if (string.IsNullOrEmpty(selectedGame))
                return;

            try
            {
                Form form = formFactory.CreateForm(selectedGame);
                form.Show();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateAndGetAddress(out int offset, bool showEmptyError = true)
        {
            offset = 0;

            if (SharedResources.BaseAddressManager.EEmemBaseAddress == IntPtr.Zero)
            {
                if (showEmptyError)
                {
                    labelStatus.Text = "Not connected to process!";
                    labelStatus.ForeColor = Color.Red;
                }
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

            if (!int.TryParse(addressText, System.Globalization.NumberStyles.HexNumber, null, out offset))
            {
                labelStatus.Text = "Invalid memory address!";
                labelStatus.ForeColor = Color.Red;
                return false;
            }

            return true;
        }
    }
}
