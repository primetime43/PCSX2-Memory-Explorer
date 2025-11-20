using Common;
using System.Collections.Generic;

namespace Ratchet___Clank.Config
{
    public class RatchetClank2Config : IGameMemoryConfig
    {
        public string GameName => "Ratchet & Clank: Going Commando";

        public List<MemoryValue> GetMemoryValues()
        {
            var memoryValues = new List<MemoryValue>();

            // MISC Category
            memoryValues.Add(new MemoryValue("Bolts", 0x001A7A00, "Int32", "Misc", "Currency amount"));

            // TODO: Add more addresses for Ratchet & Clank 2 when discovered

            return memoryValues;
        }
    }
}
