using Common;
using System.Collections.Generic;

namespace Ratchet___Clank.Config
{
    public class SecretAgentClankConfig : IGameMemoryConfig
    {
        public string GameName => "Secret Agent Clank (PAL)";

        public List<MemoryValue> GetMemoryValues()
        {
            var memoryValues = new List<MemoryValue>();

            // Currency & Progression
            memoryValues.Add(new MemoryValue("Bolts", 0x002075C8, "Int32", "Currency", "Currency amount"));
            memoryValues.Add(new MemoryValue("Multiplier Bolts", 0x00206C2D, "Int8", "Currency", "Bolt multiplier value"));
            memoryValues.Add(new MemoryValue("Titanium Bolts", 0x00206C17, "Int8", "Currency", "Titanium bolt count"));
            memoryValues.Add(new MemoryValue("Enable/Disable Multiplier and NG+", 0x002075D4, "Int32", "Progression", "NG+ and multiplier toggle"));
            memoryValues.Add(new MemoryValue("Experience HP", 0x00220030, "Int32", "Progression", "Health experience points"));

            // Health - Boltaire
            memoryValues.Add(new MemoryValue("Boltaire HP", 0x01832828, "Int32", "Health - Boltaire", "Current HP on Boltaire"));
            memoryValues.Add(new MemoryValue("Boltaire Max HP", 0x0183282C, "Int32", "Health - Boltaire", "Maximum HP on Boltaire"));

            // Health - Jailbreak
            memoryValues.Add(new MemoryValue("Jailbreak HP", 0x016A25D4, "Int32", "Health - Jailbreak", "Current HP in Jailbreak"));
            memoryValues.Add(new MemoryValue("Jailbreak Max HP", 0x016A25D8, "Int32", "Health - Jailbreak", "Maximum HP in Jailbreak"));

            // Health - Rescue Clank
            memoryValues.Add(new MemoryValue("Rescue Clank HP P1", 0x01824EC0, "Int32", "Health - Rescue Clank", "Player 1 HP in Rescue Clank"));
            memoryValues.Add(new MemoryValue("Rescue Clank HP P2", 0x01825290, "Int32", "Health - Rescue Clank", "Player 2 HP in Rescue Clank"));
            memoryValues.Add(new MemoryValue("Rescue Clank HP P3", 0x01825660, "Int32", "Health - Rescue Clank", "Player 3 HP in Rescue Clank"));

            // Speed
            memoryValues.Add(new MemoryValue("Boltaire Speed", 0x018326EC, "Float", "Speed", "Movement speed on Boltaire"));
            memoryValues.Add(new MemoryValue("Asyanica Rooftops Speed", 0x0182907C, "Float", "Speed", "Movement speed on Asyanica Rooftops"));

            return memoryValues;
        }
    }
}
