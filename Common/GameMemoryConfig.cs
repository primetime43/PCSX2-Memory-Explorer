using System;
using System.Collections.Generic;

namespace Common
{
    /// <summary>
    /// Defines a memory value that can be read/written for a game
    /// </summary>
    public class MemoryValue
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public int Address { get; set; }
        public string DataType { get; set; } // "Int32", "Float", "Int16", etc.
        public string Description { get; set; }
        public string Notes { get; set; } // Detailed notes about valid values, etc.

        public MemoryValue(string name, int address, string dataType, string category = "General", string description = "", string notes = "")
        {
            Name = name;
            Address = address;
            DataType = dataType;
            Category = category;
            Description = description;
            Notes = notes;
        }
    }

    /// <summary>
    /// Base interface for game-specific memory configurations
    /// </summary>
    public interface IGameMemoryConfig
    {
        string GameName { get; }
        List<MemoryValue> GetMemoryValues();
    }
}
