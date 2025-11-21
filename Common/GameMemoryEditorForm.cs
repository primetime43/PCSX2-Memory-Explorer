using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Common.Operations;

namespace Common
{
    public partial class GameMemoryEditorForm : Form
    {
        private IGameMemoryConfig _gameConfig;
        private IntPtr _processHandle;
        private IntPtr _baseAddress;
        private List<MemoryValue> _allMemoryValues;
        private List<MemoryValue> _filteredMemoryValues;
        private Dictionary<int, string> _frozenValues = new Dictionary<int, string>(); // Address -> Value to freeze

        public GameMemoryEditorForm(IGameMemoryConfig gameConfig)
        {
            InitializeComponent();
            _gameConfig = gameConfig;
            _allMemoryValues = gameConfig.GetMemoryValues();
            _filteredMemoryValues = new List<MemoryValue>(_allMemoryValues);

            // Set the game name
            labelGameName.Text = $"{gameConfig.GameName} - Memory Editor";
            this.Text = $"{gameConfig.GameName} - Memory Editor";

            // Initialize the DataGridView
            InitializeDataGridView();

            // Populate category dropdown
            PopulateCategoryDropdown();

            // Set process handle and base address from shared resources
            _processHandle = SharedResources.ProcessHandle;
            _baseAddress = SharedResources.BaseAddressManager.EEmemBaseAddress;
        }

        private void InitializeDataGridView()
        {
            dataGridViewMemory.Columns.Clear();
            dataGridViewMemory.Rows.Clear();

            // Define columns
            var freezeColumn = new DataGridViewCheckBoxColumn();
            freezeColumn.Name = "Freeze";
            freezeColumn.HeaderText = "Freeze";
            freezeColumn.Width = 50;
            dataGridViewMemory.Columns.Add(freezeColumn);

            dataGridViewMemory.Columns.Add("Name", "Name");
            dataGridViewMemory.Columns.Add("Category", "Category");
            dataGridViewMemory.Columns.Add("Address", "Address");
            dataGridViewMemory.Columns.Add("CurrentValue", "Current Value");
            dataGridViewMemory.Columns.Add("NewValue", "New Value");
            dataGridViewMemory.Columns.Add("DataType", "Data Type");
            dataGridViewMemory.Columns.Add("Description", "Description");

            // Set column properties - auto-fit content
            dataGridViewMemory.Columns["Freeze"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewMemory.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewMemory.Columns["Name"].ReadOnly = true;
            dataGridViewMemory.Columns["Category"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewMemory.Columns["Category"].ReadOnly = true;
            dataGridViewMemory.Columns["Address"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewMemory.Columns["Address"].ReadOnly = true;
            dataGridViewMemory.Columns["CurrentValue"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewMemory.Columns["CurrentValue"].ReadOnly = true;
            dataGridViewMemory.Columns["NewValue"].Width = 80;
            dataGridViewMemory.Columns["NewValue"].ReadOnly = false; // Editable
            dataGridViewMemory.Columns["DataType"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewMemory.Columns["DataType"].ReadOnly = true;
            dataGridViewMemory.Columns["Description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewMemory.Columns["Description"].ReadOnly = true;

            // Handle checkbox changes
            dataGridViewMemory.CellValueChanged += DataGridViewMemory_CellValueChanged;
            dataGridViewMemory.CurrentCellDirtyStateChanged += DataGridViewMemory_CurrentCellDirtyStateChanged;

            // Populate with memory values
            PopulateDataGridView();
        }

        private void PopulateCategoryDropdown()
        {
            comboBoxCategory.Items.Clear();
            comboBoxCategory.Items.Add("All");

            // Get unique categories
            var categories = _allMemoryValues.Select(mv => mv.Category).Distinct().OrderBy(c => c);
            foreach (var category in categories)
            {
                comboBoxCategory.Items.Add(category);
            }

            comboBoxCategory.SelectedIndex = 0; // Select "All" by default
        }

        private void PopulateDataGridView()
        {
            dataGridViewMemory.Rows.Clear();

            foreach (var memValue in _filteredMemoryValues)
            {
                int rowIndex = dataGridViewMemory.Rows.Add();
                DataGridViewRow row = dataGridViewMemory.Rows[rowIndex];

                row.Cells["Freeze"].Value = _frozenValues.ContainsKey(memValue.Address);
                row.Cells["Name"].Value = memValue.Name;
                row.Cells["Category"].Value = memValue.Category;
                row.Cells["Address"].Value = $"0x{memValue.Address:X8}";
                row.Cells["CurrentValue"].Value = "-";
                row.Cells["NewValue"].Value = "";
                row.Cells["DataType"].Value = memValue.DataType;
                row.Cells["Description"].Value = memValue.Description;

                // Store the MemoryValue object in the Tag for easy access
                row.Tag = memValue;
            }

            UpdateFreezeCountLabel();
        }

        private void buttonRefreshAll_Click(object sender, EventArgs e)
        {
            if (_processHandle == IntPtr.Zero || _baseAddress == IntPtr.Zero)
            {
                MessageBox.Show("Not connected to PCSX2! Please connect first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            RefreshAllValues();
        }

        private void RefreshAllValues()
        {
            foreach (DataGridViewRow row in dataGridViewMemory.Rows)
            {
                if (row.Tag is MemoryValue memValue)
                {
                    IntPtr address = IntPtr.Add(_baseAddress, memValue.Address);
                    string value = ReadMemoryValue(address, memValue.DataType);
                    row.Cells["CurrentValue"].Value = value;
                }
            }
        }

        private string ReadMemoryValue(IntPtr address, string dataType)
        {
            int size = GetDataTypeSize(dataType);
            byte[] buffer = new byte[size];

            if (MemoryOperations.ReadMemory(_processHandle, address, buffer, out int bytesRead) && bytesRead == size)
            {
                return ConvertBytesToString(buffer, dataType);
            }

            return "Error";
        }

        private int GetDataTypeSize(string dataType)
        {
            return dataType switch
            {
                "Int8" => 1,
                "Int16" => 2,
                "Int32" => 4,
                "Int64" => 8,
                "Float" => 4,
                "Double" => 8,
                _ => 4
            };
        }

        private string ConvertBytesToString(byte[] buffer, string dataType)
        {
            try
            {
                return dataType switch
                {
                    "Int8" => ((sbyte)buffer[0]).ToString(),
                    "Int16" => BitConverter.ToInt16(buffer, 0).ToString(),
                    "Int32" => BitConverter.ToInt32(buffer, 0).ToString(),
                    "Int64" => BitConverter.ToInt64(buffer, 0).ToString(),
                    "Float" => BitConverter.ToSingle(buffer, 0).ToString("F6"),
                    "Double" => BitConverter.ToDouble(buffer, 0).ToString("F6"),
                    _ => BitConverter.ToInt32(buffer, 0).ToString()
                };
            }
            catch
            {
                return "Error";
            }
        }

        private void buttonWriteAll_Click(object sender, EventArgs e)
        {
            if (_processHandle == IntPtr.Zero || _baseAddress == IntPtr.Zero)
            {
                MessageBox.Show("Not connected to PCSX2! Please connect first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int writeCount = 0;
            int errorCount = 0;

            foreach (DataGridViewRow row in dataGridViewMemory.Rows)
            {
                string newValueStr = row.Cells["NewValue"].Value?.ToString();
                if (string.IsNullOrWhiteSpace(newValueStr))
                    continue; // Skip rows with no new value

                if (row.Tag is MemoryValue memValue)
                {
                    IntPtr address = IntPtr.Add(_baseAddress, memValue.Address);
                    byte[] bytesToWrite = ConvertStringToBytes(newValueStr, memValue.DataType);

                    if (bytesToWrite != null)
                    {
                        if (MemoryOperations.WriteMemory(_processHandle, address, bytesToWrite, out int bytesWritten))
                        {
                            writeCount++;
                            row.Cells["NewValue"].Value = ""; // Clear after successful write
                        }
                        else
                        {
                            errorCount++;
                        }
                    }
                    else
                    {
                        errorCount++;
                    }
                }
            }

            MessageBox.Show($"Write complete!\nSuccessful: {writeCount}\nFailed: {errorCount}", "Write Results", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Refresh all values to show updated current values
            RefreshAllValues();
        }

        private byte[] ConvertStringToBytes(string valueStr, string dataType)
        {
            try
            {
                switch (dataType)
                {
                    case "Int8":
                        if (sbyte.TryParse(valueStr, out sbyte int8))
                            return new byte[] { (byte)int8 };
                        break;

                    case "Int16":
                        if (short.TryParse(valueStr, out short int16))
                            return BitConverter.GetBytes(int16);
                        break;

                    case "Int32":
                        if (int.TryParse(valueStr, out int int32))
                            return BitConverter.GetBytes(int32);
                        break;

                    case "Int64":
                        if (long.TryParse(valueStr, out long int64))
                            return BitConverter.GetBytes(int64);
                        break;

                    case "Float":
                        if (float.TryParse(valueStr, out float floatVal))
                            return BitConverter.GetBytes(floatVal);
                        break;

                    case "Double":
                        if (double.TryParse(valueStr, out double doubleVal))
                            return BitConverter.GetBytes(doubleVal);
                        break;
                }
            }
            catch
            {
                return null;
            }

            return null;
        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCategory = comboBoxCategory.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedCategory))
                return;

            if (selectedCategory == "All")
            {
                _filteredMemoryValues = new List<MemoryValue>(_allMemoryValues);
            }
            else
            {
                _filteredMemoryValues = _allMemoryValues.Where(mv => mv.Category == selectedCategory).ToList();
            }

            PopulateDataGridView();
        }

        private void checkBoxAutoRefresh_CheckedChanged(object sender, EventArgs e)
        {
            timerAutoRefresh.Enabled = checkBoxAutoRefresh.Checked;
        }

        private void timerAutoRefresh_Tick(object sender, EventArgs e)
        {
            RefreshAllValues();
        }

        private void DataGridViewMemory_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            // Commit checkbox changes immediately
            if (dataGridViewMemory.IsCurrentCellDirty &&
                dataGridViewMemory.CurrentCell is DataGridViewCheckBoxCell)
            {
                dataGridViewMemory.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void DataGridViewMemory_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            if (dataGridViewMemory.Columns[e.ColumnIndex].Name != "Freeze")
                return;

            DataGridViewRow row = dataGridViewMemory.Rows[e.RowIndex];
            if (row.Tag is not MemoryValue memValue)
                return;

            bool isFrozen = (bool)(row.Cells["Freeze"].Value ?? false);

            if (isFrozen)
            {
                // Get the current value to freeze
                string currentValue = row.Cells["CurrentValue"].Value?.ToString() ?? "";
                string newValue = row.Cells["NewValue"].Value?.ToString();

                // If NewValue is set, use that; otherwise use CurrentValue
                string valueToFreeze = !string.IsNullOrWhiteSpace(newValue) ? newValue : currentValue;

                if (valueToFreeze != "-" && valueToFreeze != "Error" && !string.IsNullOrWhiteSpace(valueToFreeze))
                {
                    _frozenValues[memValue.Address] = valueToFreeze;
                }
                else
                {
                    // Need to read the current value first
                    if (_processHandle != IntPtr.Zero && _baseAddress != IntPtr.Zero)
                    {
                        IntPtr address = IntPtr.Add(_baseAddress, memValue.Address);
                        string readValue = ReadMemoryValue(address, memValue.DataType);
                        if (readValue != "Error")
                        {
                            _frozenValues[memValue.Address] = readValue;
                            row.Cells["CurrentValue"].Value = readValue;
                        }
                    }
                }
            }
            else
            {
                _frozenValues.Remove(memValue.Address);
            }

            UpdateFreezeCountLabel();
        }

        private void timerFreeze_Tick(object sender, EventArgs e)
        {
            if (_processHandle == IntPtr.Zero || _baseAddress == IntPtr.Zero)
                return;

            if (_frozenValues.Count == 0)
                return;

            // Write all frozen values
            foreach (var memValue in _allMemoryValues)
            {
                if (_frozenValues.TryGetValue(memValue.Address, out string frozenValue))
                {
                    IntPtr address = IntPtr.Add(_baseAddress, memValue.Address);
                    byte[] bytesToWrite = ConvertStringToBytes(frozenValue, memValue.DataType);

                    if (bytesToWrite != null)
                    {
                        MemoryOperations.WriteMemory(_processHandle, address, bytesToWrite, out _);
                    }
                }
            }
        }

        private void UpdateFreezeCountLabel()
        {
            labelFreezeCount.Text = $"Frozen: {_frozenValues.Count} value{(_frozenValues.Count != 1 ? "s" : "")}";
        }
    }
}
