namespace Common.Managers
{
    public class BaseAddressManager
    {
        public IntPtr EEmemBaseAddress { get; private set; }
        public IntPtr IOPmemBaseAddress { get; private set; }
        public IntPtr VUmemBaseAddress { get; private set; }

        public bool ReadBaseAddressesFromFile(string filePath)
        {
            try
            {
                string[] lines = File.ReadAllLines(filePath);
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
    }
}
