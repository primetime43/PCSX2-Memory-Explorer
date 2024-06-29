using Common;
using Common.Operations;
using System;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace Ratchet___Clank
{
    public partial class RatchetAndClankOne : Form
    {
        public RatchetAndClankOne()
        {
            InitializeComponent();
            loadComboBoxItems();
        }

        private void setBoltsBtn_Click(object sender, EventArgs e)
        {
            if (SharedResources.ProcessHandle != IntPtr.Zero && SharedResources.BaseAddressManager.EEmemBaseAddress != IntPtr.Zero)
            {
                IntPtr baseAddress = SharedResources.BaseAddressManager.EEmemBaseAddress + (int)MemoryAddresses.RA1_Address_MISC.Bolts;

                if (int.TryParse(textBoxBolts.Text, out int value))
                {
                    byte[] buffer = BitConverter.GetBytes(value);
                    bool success = MemoryOperations.WriteMemory(SharedResources.ProcessHandle, baseAddress, buffer, out int bytesWritten);

                    if (success && bytesWritten == buffer.Length)
                    {
                        MessageBox.Show("Memory write successful!");
                    }
                    else
                    {
                        MessageBox.Show("Memory write failed!");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid input in textBoxBolts!");
                }
            }
            else
            {
                MessageBox.Show("Not connected to process or base address is invalid!");
            }
        }

        private void readBoltsBtn_Click(object sender, EventArgs e)
        {
            if (SharedResources.ProcessHandle != IntPtr.Zero && SharedResources.BaseAddressManager.EEmemBaseAddress != IntPtr.Zero)
            {
                IntPtr baseAddress = SharedResources.BaseAddressManager.EEmemBaseAddress + (int)MemoryAddresses.RA1_Address_MISC.Bolts;

                byte[] buffer = new byte[4];
                bool success = MemoryOperations.ReadMemory(SharedResources.ProcessHandle, baseAddress, buffer, out int bytesRead);

                if (success && bytesRead == buffer.Length)
                {
                    int value = BitConverter.ToInt32(buffer, 0);
                    textBoxBolts.Text = value.ToString();
                    MessageBox.Show("Memory read successful!");
                }
                else
                {
                    MessageBox.Show("Memory read failed!");
                }
            }
            else
            {
                MessageBox.Show("Not connected to process or base address is invalid!");
            }
        }

        private void toggleItemBtn_Click(object sender, EventArgs e)
        {
            if (SharedResources.ProcessHandle != IntPtr.Zero && SharedResources.BaseAddressManager.EEmemBaseAddress != IntPtr.Zero)
            {
                IntPtr address = GetSelectedItemAddress();
                if (address == IntPtr.Zero)
                {
                    MessageBox.Show("Select a valid item from the dropdown!");
                    return;
                }

                byte[] buffer = new byte[1];
                bool success = MemoryOperations.ReadMemory(SharedResources.ProcessHandle, address, buffer, out int bytesRead);

                if (success && bytesRead == buffer.Length)
                {
                    buffer[0] = buffer[0] == 1 ? (byte)0 : (byte)1;
                    success = MemoryOperations.WriteMemory(SharedResources.ProcessHandle, address, buffer, out int bytesWritten);

                    if (success && bytesWritten == buffer.Length)
                    {
                        MessageBox.Show("Item toggle successful!");
                    }
                    else
                    {
                        MessageBox.Show("Item toggle failed!");
                    }
                }
                else
                {
                    MessageBox.Show("Memory read failed!");
                }
            }
            else
            {
                MessageBox.Show("Not connected to process or base address is invalid!");
            }
        }

        private void setAmmoBtn_Click(object sender, EventArgs e)
        {
            if (SharedResources.ProcessHandle != IntPtr.Zero && SharedResources.BaseAddressManager.EEmemBaseAddress != IntPtr.Zero)
            {
                string selectedAmmoItem = comboBoxAmmoItems.SelectedItem.ToString();
                Type ammoType = typeof(MemoryAddresses.RA1_Address_AMMO);
                FieldInfo ammoField = ammoType.GetField(selectedAmmoItem);

                if (ammoField != null)
                {
                    int offset = (int)ammoField.GetValue(null);
                    IntPtr baseAddress = SharedResources.BaseAddressManager.EEmemBaseAddress + offset;

                    if (int.TryParse(textBoxAmmo.Text, out int value))
                    {
                        byte[] buffer = BitConverter.GetBytes(value);
                        bool success = MemoryOperations.WriteMemory(SharedResources.ProcessHandle, baseAddress, buffer, out int bytesWritten);

                        if (success && bytesWritten == buffer.Length)
                        {
                            MessageBox.Show("Ammo set successfully!");
                        }
                        else
                        {
                            MessageBox.Show("Failed to set ammo!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid input in textBoxAmmo!");
                    }
                }
                else
                {
                    MessageBox.Show("Select a valid ammo item from the dropdown!");
                }
            }
            else
            {
                MessageBox.Show("Not connected to process or base address is invalid!");
            }
        }

        private void giveAllItems_Click(object sender, EventArgs e)
        {
            if (SharedResources.ProcessHandle != IntPtr.Zero && SharedResources.BaseAddressManager.EEmemBaseAddress != IntPtr.Zero)
            {
                var inventoryFields = typeof(MemoryAddresses.RA1_Address_INVENTORY).GetFields(BindingFlags.Public | BindingFlags.Static);
                var goldFields = typeof(MemoryAddresses.RA1_Address_GOLD).GetFields(BindingFlags.Public | BindingFlags.Static);

                foreach (var field in inventoryFields.Concat(goldFields))
                {
                    int offset = (int)field.GetValue(null);
                    IntPtr address = SharedResources.BaseAddressManager.EEmemBaseAddress + offset;
                    byte[] buffer = { 1 }; // Set value to 1 to mark as owned
                    MemoryOperations.WriteMemory(SharedResources.ProcessHandle, address, buffer, out _);
                }

                MessageBox.Show("All items given successfully!");
            }
            else
            {
                MessageBox.Show("Not connected to process or base address is invalid!");
            }
        }

        private IntPtr GetSelectedItemAddress()
        {
            string selectedItem = comboBoxItems.SelectedItem.ToString();

            // Check in RA1_Address_INVENTORY
            Type inventoryType = typeof(MemoryAddresses.RA1_Address_INVENTORY);
            FieldInfo inventoryField = inventoryType.GetField(selectedItem);
            if (inventoryField != null)
            {
                int offset = (int)inventoryField.GetValue(null);
                return SharedResources.BaseAddressManager.EEmemBaseAddress + offset;
            }

            // Check in RA1_Address_GOLD
            Type goldType = typeof(MemoryAddresses.RA1_Address_GOLD);
            FieldInfo goldField = goldType.GetField(selectedItem);
            if (goldField != null)
            {
                int offset = (int)goldField.GetValue(null);
                return SharedResources.BaseAddressManager.EEmemBaseAddress + offset;
            }

            return IntPtr.Zero;
        }

        private void loadComboBoxItems()
        {
            comboBoxItems.Items.AddRange(Enum.GetNames(typeof(MemoryAddresses.RA1_Address_INVENTORY)));
            comboBoxItems.Items.AddRange(Enum.GetNames(typeof(MemoryAddresses.RA1_Address_GOLD)));
            comboBoxItems.SelectedIndex = 0;

            comboBoxAmmoItems.Items.AddRange(Enum.GetNames(typeof(MemoryAddresses.RA1_Address_AMMO)));
            comboBoxAmmoItems.SelectedIndex = 0;
        }
    }
}
