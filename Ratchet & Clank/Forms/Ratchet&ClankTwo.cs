using Common;
using Common.Operations;

namespace Ratchet___Clank
{
    public partial class RatchetAndClankTwo : Form
    {
        public RatchetAndClankTwo()
        {
            InitializeComponent();
        }

        private void setBoltsBtn_Click(object sender, EventArgs e)
        {
            if (SharedResources.ProcessHandle != IntPtr.Zero && SharedResources.BaseAddressManager.EEmemBaseAddress != IntPtr.Zero)
            {
                IntPtr baseAddress = SharedResources.BaseAddressManager.EEmemBaseAddress + (int)MemoryAddresses.RA2_Address.Bolts;

                if (int.TryParse(textBoxBolts.Text, out int value))
                {
                    byte[] buffer = BitConverter.GetBytes(value);
                    bool success = MemoryOperations.WriteMemory(SharedResources.ProcessHandle, baseAddress, buffer, out int bytesWritten);

                    if (success && bytesWritten == buffer.Length)
                    {
                        //MessageBox.Show("Memory write successful!");
                    }
                    else
                    {
                        //MessageBox.Show("Memory write failed!");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid input in textBox1!");
                }
            }
            else
            {
                MessageBox.Show("Not connected to process or base address is invalid!");
            }
        }
    }
}
