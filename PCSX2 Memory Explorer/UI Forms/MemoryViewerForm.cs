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
        private IntPtr _currentAddress;
        private const int PAGE_SIZE = 512; // Show 512 bytes per page

        // Selection tracking
        private long _selectedAddress = -1;
        private byte[] _selectedBytes = null;

        public MemoryViewerForm()
        {
            InitializeComponent();
            SetupTooltips();

            // Enable mouse wheel scrolling
            this.MouseWheel += MemoryViewerForm_MouseWheel;
            richTextBoxMemory.MouseWheel += MemoryViewerForm_MouseWheel;

            // Enable keyboard navigation
            this.KeyPreview = true;
            this.KeyDown += MemoryViewerForm_KeyDown;
        }

        private void MemoryViewerForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.PageDown:
                    ScrollMemory(PAGE_SIZE);
                    e.Handled = true;
                    break;
                case Keys.PageUp:
                    ScrollMemory(-PAGE_SIZE);
                    e.Handled = true;
                    break;
                case Keys.Down:
                    ScrollMemory(16); // One row
                    e.Handled = true;
                    break;
                case Keys.Up:
                    ScrollMemory(-16); // One row
                    e.Handled = true;
                    break;
                case Keys.Home:
                    if (e.Control)
                    {
                        // Ctrl+Home: Go to address 0
                        _currentAddress = IntPtr.Zero;
                        textBoxAddress.Text = "0x0";
                        RefreshMemoryView();
                        e.Handled = true;
                    }
                    break;
            }
        }

        private void SetupTooltips()
        {
            ToolTip tooltip = new ToolTip();
            tooltip.AutoPopDelay = 10000; // Show for 10 seconds
            tooltip.InitialDelay = 500;
            tooltip.ReshowDelay = 200;

            string rawAddressTooltip =
                "Raw Address vs Offset:\n\n" +
                "• Offset (unchecked): Shows PS2 memory offsets (e.g., 0x001A7A00)\n" +
                "  These are the addresses you find in game guides and cheat tables.\n" +
                "  They never change between PCSX2 sessions.\n\n" +
                "• Raw Address (checked): Shows actual process memory addresses (e.g., 0x7FF680000000)\n" +
                "  Formula: Raw Address = EEmem Base + Offset\n" +
                "  These change every time you restart PCSX2.\n\n" +
                "Example:\n" +
                "  EEmem Base: 0x7FF680000000\n" +
                "  Offset:     0x001A7A00\n" +
                "  Raw Addr:   0x7FF6801A7A00\n\n" +
                "Use offsets for modding/cheating, use raw addresses for debugging.";

            tooltip.SetToolTip(checkBoxDisplayRawAddresses, rawAddressTooltip);
        }

        private void MemoryViewerForm_MouseWheel(object sender, MouseEventArgs e)
        {
            // Scroll up (negative delta) = previous, scroll down (positive delta) = next
            if (e.Delta > 0)
            {
                // Scroll up - go to previous page
                ScrollMemory(-PAGE_SIZE / 4); // Scroll by quarter page for smoother scrolling
            }
            else if (e.Delta < 0)
            {
                // Scroll down - go to next page
                ScrollMemory(PAGE_SIZE / 4);
            }
        }

        private void ScrollMemory(int offset)
        {
            long newOffset = _currentAddress.ToInt64() + offset;
            if (newOffset < 0)
                newOffset = 0;

            _currentAddress = new IntPtr(newOffset);
            textBoxAddress.Text = $"0x{newOffset:X}";
            RefreshMemoryView();
        }

        // Overload to open without specific address (defaults to 0x0)
        public void LoadMemory(IntPtr processHandle, IntPtr baseAddress)
        {
            LoadMemory(processHandle, baseAddress, IntPtr.Zero);
        }

        // Overload for backwards compatibility
        public void LoadMemory(IntPtr processHandle, IntPtr baseAddress, IntPtr addressOfFocus, int size)
        {
            LoadMemory(processHandle, baseAddress, addressOfFocus);
        }

        // Main method to load memory and display it in the RichTextBox
        public void LoadMemory(IntPtr processHandle, IntPtr baseAddress, IntPtr addressOfFocus)
        {
            // Store the parameters for reloading memory
            _processHandle = processHandle;
            _baseAddress = baseAddress;
            _currentAddress = addressOfFocus;

            // Update the address textbox
            long offset = _currentAddress.ToInt64();
            textBoxAddress.Text = $"0x{offset:X}";

            // Read and display memory
            RefreshMemoryView();
        }

        private void RefreshMemoryView()
        {
            StringBuilder sb = new StringBuilder();
            IntPtr startAddress = IntPtr.Add(_baseAddress, (int)_currentAddress.ToInt64());
            byte[] buffer = new byte[PAGE_SIZE];

            // Update memory range label
            long startOffset = _currentAddress.ToInt64();
            long endOffset = startOffset + PAGE_SIZE;
            labelMemoryRange.Text = $"Viewing: 0x{startOffset:X8} - 0x{endOffset:X8}";

            // Read memory in 16-byte rows for better hex editor format
            for (int i = 0; i < PAGE_SIZE; i += 16)
            {
                IntPtr currentAddress = startAddress + i;
                int rowSize = Math.Min(16, PAGE_SIZE - i);
                byte[] rowBuffer = new byte[rowSize];

                // Read memory for this row
                bool success = ReadProcessMemory(_processHandle, currentAddress, rowBuffer, rowSize, out int bytesRead);

                // Display address
                if (checkBoxDisplayRawAddresses.Checked)
                {
                    sb.AppendFormat("{0:X16}  ", currentAddress.ToInt64());
                }
                else
                {
                    sb.AppendFormat("{0:X8}  ", (currentAddress.ToInt64() - _baseAddress.ToInt64()));
                }

                // Display hex bytes
                if (success && bytesRead > 0)
                {
                    for (int j = 0; j < 16; j++)
                    {
                        if (j < bytesRead)
                        {
                            sb.AppendFormat("{0:X2} ", rowBuffer[j]);
                        }
                        else
                        {
                            sb.Append("   "); // Pad if we didn't read full 16 bytes
                        }

                        // Add extra space between 8-byte groups
                        if (j == 7)
                            sb.Append(" ");
                    }

                    // Display ASCII representation
                    sb.Append(" | ");
                    for (int j = 0; j < bytesRead; j++)
                    {
                        char c = (char)rowBuffer[j];
                        sb.Append(char.IsControl(c) ? '.' : c);
                    }
                }
                else
                {
                    sb.Append("?? ?? ?? ?? ?? ?? ?? ??  ?? ?? ?? ?? ?? ?? ?? ??");
                }

                sb.AppendLine();
            }

            richTextBoxMemory.Text = sb.ToString();
        }

        // Event handler for checkbox state change
        private void checkBoxDisplayRawAddresses_CheckedChanged(object sender, EventArgs e)
        {
            // Reload the memory view when the checkbox state changes
            RefreshMemoryView();
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            if (ParseAddressFromTextBox(out long offset))
            {
                _currentAddress = new IntPtr(offset);
                RefreshMemoryView();
            }
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            // Go back one page
            long newOffset = _currentAddress.ToInt64() - PAGE_SIZE;
            if (newOffset < 0)
                newOffset = 0;

            _currentAddress = new IntPtr(newOffset);
            textBoxAddress.Text = $"0x{newOffset:X}";
            RefreshMemoryView();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            // Go forward one page
            long newOffset = _currentAddress.ToInt64() + PAGE_SIZE;
            _currentAddress = new IntPtr(newOffset);
            textBoxAddress.Text = $"0x{newOffset:X}";
            RefreshMemoryView();
        }

        private bool ParseAddressFromTextBox(out long offset)
        {
            offset = 0;
            string addressText = textBoxAddress.Text.Trim();

            if (string.IsNullOrEmpty(addressText))
            {
                MessageBox.Show("Please enter an address!", "Invalid Address", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Remove 0x prefix if present
            if (addressText.StartsWith("0x", StringComparison.OrdinalIgnoreCase))
            {
                addressText = addressText.Substring(2);
            }

            // Try to parse as hex
            if (long.TryParse(addressText, System.Globalization.NumberStyles.HexNumber, null, out offset))
            {
                return true;
            }

            MessageBox.Show("Invalid address format! Use hex format (e.g., 0x1A7A00)", "Invalid Address", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        private void richTextBoxMemory_MouseUp(object sender, MouseEventArgs e)
        {
            // Get selected text and parse it to extract hex bytes
            string selectedText = richTextBoxMemory.SelectedText;
            if (string.IsNullOrWhiteSpace(selectedText))
            {
                return;
            }

            // Get the full text and selection position to find the address
            int selectionStart = richTextBoxMemory.SelectionStart;
            string fullText = richTextBoxMemory.Text;

            // Find the line that contains the selection start
            int lineStart = fullText.LastIndexOf('\n', Math.Max(0, selectionStart - 1)) + 1;
            int lineEnd = fullText.IndexOf('\n', selectionStart);
            if (lineEnd < 0) lineEnd = fullText.Length;

            string currentLine = fullText.Substring(lineStart, lineEnd - lineStart);

            // Parse address from the current line (first 8 or 16 hex characters)
            long baseAddress = _currentAddress.ToInt64();
            string[] lineParts = currentLine.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (lineParts.Length > 0)
            {
                string addressPart = lineParts[0];
                if ((addressPart.Length == 8 || addressPart.Length == 16) &&
                    long.TryParse(addressPart, System.Globalization.NumberStyles.HexNumber, null, out long lineAddr))
                {
                    baseAddress = lineAddr;
                }
            }

            // Now find which byte position in the line was selected
            // Count how many hex bytes appear before the selection in the current line
            int bytesBeforeSelection = 0;
            string lineBeforeSelection = currentLine.Substring(0, Math.Min(currentLine.Length, selectionStart - lineStart));

            // Count space-separated 2-char hex values before selection
            string[] beforeWords = lineBeforeSelection.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string word in beforeWords)
            {
                if (word.Length == 2 && byte.TryParse(word, System.Globalization.NumberStyles.HexNumber, null, out _))
                {
                    bytesBeforeSelection++;
                }
            }

            // Extract hex bytes from selection
            var bytes = new System.Collections.Generic.List<byte>();
            string[] words = selectedText.Split(new[] { ' ', '\t', '\r', '\n', '|' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string word in words)
            {
                // Try to parse as hex byte (exactly 2 hex digits)
                if (word.Length == 2 && byte.TryParse(word, System.Globalization.NumberStyles.HexNumber, null, out byte b))
                {
                    bytes.Add(b);
                }
            }

            // Update the data inspector if we got any bytes
            if (bytes.Count > 0)
            {
                _selectedAddress = baseAddress + bytesBeforeSelection;
                _selectedBytes = bytes.ToArray();
                UpdateDataInspector();
            }
        }

        private void UpdateDataInspector()
        {
            if (_selectedBytes == null || _selectedBytes.Length == 0)
            {
                labelSelectedAddress.Text = "Address: (select bytes)";
                labelInt8.Text = "Int8:  -";
                labelInt16.Text = "Int16: -";
                labelInt32.Text = "Int32: -";
                labelInt64.Text = "Int64: -";
                labelFloat.Text = "Float: -";
                labelDouble.Text = "Double: -";
                labelString.Text = "String: -";
                return;
            }

            labelSelectedAddress.Text = $"Address: 0x{_selectedAddress:X8} ({_selectedBytes.Length} bytes)";

            // Int8
            if (_selectedBytes.Length >= 1)
            {
                sbyte int8 = (sbyte)_selectedBytes[0];
                byte uint8 = _selectedBytes[0];
                labelInt8.Text = $"Int8:  {int8} (U: {uint8})";
            }

            // Int16
            if (_selectedBytes.Length >= 2)
            {
                short int16 = BitConverter.ToInt16(_selectedBytes, 0);
                ushort uint16 = BitConverter.ToUInt16(_selectedBytes, 0);
                labelInt16.Text = $"Int16: {int16} (U: {uint16})";
            }
            else
            {
                labelInt16.Text = "Int16: Need 2 bytes";
            }

            // Int32
            if (_selectedBytes.Length >= 4)
            {
                int int32 = BitConverter.ToInt32(_selectedBytes, 0);
                uint uint32 = BitConverter.ToUInt32(_selectedBytes, 0);
                labelInt32.Text = $"Int32: {int32} (U: {uint32})";
            }
            else
            {
                labelInt32.Text = "Int32: Need 4 bytes";
            }

            // Int64
            if (_selectedBytes.Length >= 8)
            {
                long int64 = BitConverter.ToInt64(_selectedBytes, 0);
                ulong uint64 = BitConverter.ToUInt64(_selectedBytes, 0);
                labelInt64.Text = $"Int64: {int64}";
            }
            else
            {
                labelInt64.Text = "Int64: Need 8 bytes";
            }

            // Float
            if (_selectedBytes.Length >= 4)
            {
                float floatVal = BitConverter.ToSingle(_selectedBytes, 0);
                labelFloat.Text = $"Float: {floatVal:F6}";
            }
            else
            {
                labelFloat.Text = "Float: Need 4 bytes";
            }

            // Double
            if (_selectedBytes.Length >= 8)
            {
                double doubleVal = BitConverter.ToDouble(_selectedBytes, 0);
                labelDouble.Text = $"Double: {doubleVal:F6}";
            }
            else
            {
                labelDouble.Text = "Double: Need 8 bytes";
            }

            // String (ASCII)
            StringBuilder sb = new StringBuilder();
            foreach (byte b in _selectedBytes)
            {
                if (b >= 32 && b < 127)
                    sb.Append((char)b);
                else
                    sb.Append('.');
            }
            labelString.Text = $"String: {sb.ToString()}";
        }

        private void buttonWriteValue_Click(object sender, EventArgs e)
        {
            if (_selectedAddress < 0)
            {
                MessageBox.Show("Please select bytes in the memory viewer first!", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string valueText = textBoxWriteValue.Text.Trim();
            if (string.IsNullOrEmpty(valueText))
            {
                MessageBox.Show("Please enter a value to write!", "No Value", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string dataType = comboBoxDataType.SelectedItem?.ToString() ?? "Int32";
            byte[] bytesToWrite = null;

            try
            {
                switch (dataType)
                {
                    case "Int8":
                        if (sbyte.TryParse(valueText, out sbyte int8))
                            bytesToWrite = new byte[] { (byte)int8 };
                        break;
                    case "Int16":
                        if (short.TryParse(valueText, out short int16))
                            bytesToWrite = BitConverter.GetBytes(int16);
                        break;
                    case "Int32":
                        if (int.TryParse(valueText, out int int32))
                            bytesToWrite = BitConverter.GetBytes(int32);
                        break;
                    case "Int64":
                        if (long.TryParse(valueText, out long int64))
                            bytesToWrite = BitConverter.GetBytes(int64);
                        break;
                    case "Float":
                        if (float.TryParse(valueText, out float floatVal))
                            bytesToWrite = BitConverter.GetBytes(floatVal);
                        break;
                    case "Double":
                        if (double.TryParse(valueText, out double doubleVal))
                            bytesToWrite = BitConverter.GetBytes(doubleVal);
                        break;
                }

                if (bytesToWrite == null)
                {
                    MessageBox.Show($"Invalid value for {dataType}!", "Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Write to memory
                IntPtr writeAddress = IntPtr.Add(_baseAddress, (int)_selectedAddress);
                if (Common.Operations.MemoryOperations.WriteMemory(_processHandle, writeAddress, bytesToWrite, out int bytesWritten))
                {
                    MessageBox.Show($"Successfully wrote {bytesWritten} bytes to 0x{_selectedAddress:X8}!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Refresh the memory view to show the changes
                    RefreshMemoryView();
                }
                else
                {
                    MessageBox.Show("Failed to write to memory!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
