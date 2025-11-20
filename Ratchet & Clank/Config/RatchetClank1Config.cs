using Common;
using System.Collections.Generic;

namespace Ratchet___Clank.Config
{
    public class RatchetClank1Config : IGameMemoryConfig
    {
        public string GameName => "Ratchet & Clank 1 (NTSC)";

        public List<MemoryValue> GetMemoryValues()
        {
            var memoryValues = new List<MemoryValue>();

            // MISC Category
            memoryValues.Add(new MemoryValue("State", 0x001413D4, "Int32", "Misc", "Game state value"));
            memoryValues.Add(new MemoryValue("X Coordinate", 0x0013F3D0, "Float", "Misc", "Player X position"));
            memoryValues.Add(new MemoryValue("Y Coordinate", 0x0013F3D4, "Float", "Misc", "Player Y position"));
            memoryValues.Add(new MemoryValue("Z Coordinate", 0x0013F3D8, "Float", "Misc", "Player Z position"));
            memoryValues.Add(new MemoryValue("Rotation", 0x0013F3E8, "Float", "Misc", "Player rotation angle"));
            memoryValues.Add(new MemoryValue("Bolts", 0x0015ED98, "Int32", "Misc", "Currency amount"));
            memoryValues.Add(new MemoryValue("Running Speed", 0x0013F5E4, "Float", "Misc", "Player movement speed"));
            memoryValues.Add(new MemoryValue("Nanotech (Health)", 0x001415F8, "Int8", "Misc", "Current health value"));

            // AMMO Category
            memoryValues.Add(new MemoryValue("Bomb Glove Ammo", 0x0013D450, "Int32", "Ammo", "Bomb Glove ammunition"));
            memoryValues.Add(new MemoryValue("Devastator Ammo", 0x0013D454, "Int32", "Ammo", "Devastator ammunition"));
            memoryValues.Add(new MemoryValue("Visibomb Gun Ammo", 0x0013D45C, "Int32", "Ammo", "Visibomb Gun ammunition"));
            memoryValues.Add(new MemoryValue("Blaster Ammo", 0x0013D464, "Int32", "Ammo", "Blaster ammunition"));
            memoryValues.Add(new MemoryValue("Pyrocitor Ammo", 0x0013D468, "Int32", "Ammo", "Pyrocitor ammunition"));
            memoryValues.Add(new MemoryValue("Mine Glove Ammo", 0x0013D46C, "Int32", "Ammo", "Mine Glove ammunition"));
            memoryValues.Add(new MemoryValue("Tesla Claw Ammo", 0x0013D474, "Int32", "Ammo", "Tesla Claw ammunition"));
            memoryValues.Add(new MemoryValue("Glove of Doom Ammo", 0x0013D478, "Int32", "Ammo", "Glove of Doom ammunition"));
            memoryValues.Add(new MemoryValue("RYNO Ammo", 0x0013D484, "Int32", "Ammo", "RYNO ammunition"));
            memoryValues.Add(new MemoryValue("Drone Device Ammo", 0x0013D488, "Int32", "Ammo", "Drone Device ammunition"));
            memoryValues.Add(new MemoryValue("Decoy Glove Ammo", 0x0013D48C, "Int32", "Ammo", "Decoy Glove ammunition"));

            // INVENTORY Category - Gadgets
            memoryValues.Add(new MemoryValue("Heli-Pack", 0x0013D4C2, "Int8", "Inventory - Gadgets", "0 = Not Owned, 1 = Owned"));
            memoryValues.Add(new MemoryValue("Thruster-Pack", 0x0013D4C3, "Int8", "Inventory - Gadgets", "0 = Not Owned, 1 = Owned"));
            memoryValues.Add(new MemoryValue("Hydro-Pack", 0x0013D4C4, "Int8", "Inventory - Gadgets", "0 = Not Owned, 1 = Owned"));
            memoryValues.Add(new MemoryValue("Sonic Summoner", 0x0013D4C5, "Int8", "Inventory - Gadgets", "0 = Not Owned, 1 = Owned"));
            memoryValues.Add(new MemoryValue("O2 Mask", 0x0013D4C6, "Int8", "Inventory - Gadgets", "0 = Not Owned, 1 = Owned"));
            memoryValues.Add(new MemoryValue("Pilot's Helmet", 0x0013D4C7, "Int8", "Inventory - Gadgets", "0 = Not Owned, 1 = Owned"));
            memoryValues.Add(new MemoryValue("Magneboots", 0x0013D4DC, "Int8", "Inventory - Gadgets", "0 = Not Owned, 1 = Owned"));
            memoryValues.Add(new MemoryValue("Grindboots", 0x0013D4DD, "Int8", "Inventory - Gadgets", "0 = Not Owned, 1 = Owned"));
            memoryValues.Add(new MemoryValue("Hoverboard", 0x0013D4DE, "Int8", "Inventory - Gadgets", "0 = Not Owned, 1 = Owned"));
            memoryValues.Add(new MemoryValue("Trespasser", 0x0013D4DA, "Int8", "Inventory - Gadgets", "0 = Not Owned, 1 = Owned"));
            memoryValues.Add(new MemoryValue("Metal Detector", 0x0013D4DB, "Int8", "Inventory - Gadgets", "0 = Not Owned, 1 = Owned"));
            memoryValues.Add(new MemoryValue("Holo-disguise", 0x0013D4E0, "Int8", "Inventory - Gadgets", "0 = Not Owned, 1 = Owned"));
            memoryValues.Add(new MemoryValue("PDA", 0x0013D4E1, "Int8", "Inventory - Gadgets", "0 = Not Owned, 1 = Owned"));
            memoryValues.Add(new MemoryValue("Map-o-Matic", 0x0013D4E2, "Int8", "Inventory - Gadgets", "0 = Not Owned, 1 = Owned"));
            memoryValues.Add(new MemoryValue("Bolt Grabber", 0x0013D4E3, "Int8", "Inventory - Gadgets", "0 = Not Owned, 1 = Owned"));
            memoryValues.Add(new MemoryValue("Persuader", 0x0013D4E4, "Int8", "Inventory - Gadgets", "0 = Not Owned, 1 = Owned"));

            // INVENTORY Category - Weapons
            memoryValues.Add(new MemoryValue("Wrench", 0x0013D4C8, "Int8", "Inventory - Weapons", "0 = Not Owned, 1 = Owned"));
            memoryValues.Add(new MemoryValue("Suck Cannon", 0x0013D4C9, "Int8", "Inventory - Weapons", "0 = Not Owned, 1 = Owned"));
            memoryValues.Add(new MemoryValue("Bomb Glove", 0x0013D4CA, "Int8", "Inventory - Weapons", "0 = Not Owned, 1 = Owned"));
            memoryValues.Add(new MemoryValue("Devastator", 0x0013D4CB, "Int8", "Inventory - Weapons", "0 = Not Owned, 1 = Owned"));
            memoryValues.Add(new MemoryValue("Swingshot", 0x0013D4CC, "Int8", "Inventory - Weapons", "0 = Not Owned, 1 = Owned"));
            memoryValues.Add(new MemoryValue("Visibomb Gun", 0x0013D4CD, "Int8", "Inventory - Weapons", "0 = Not Owned, 1 = Owned"));
            memoryValues.Add(new MemoryValue("Taunter", 0x0013D4CE, "Int8", "Inventory - Weapons", "0 = Not Owned, 1 = Owned"));
            memoryValues.Add(new MemoryValue("Blaster", 0x0013D4CF, "Int8", "Inventory - Weapons", "0 = Not Owned, 1 = Owned"));
            memoryValues.Add(new MemoryValue("Pyrocitor", 0x0013D4D0, "Int8", "Inventory - Weapons", "0 = Not Owned, 1 = Owned"));
            memoryValues.Add(new MemoryValue("Mine Glove", 0x0013D4D1, "Int8", "Inventory - Weapons", "0 = Not Owned, 1 = Owned"));
            memoryValues.Add(new MemoryValue("Walloper", 0x0013D4D2, "Int8", "Inventory - Weapons", "0 = Not Owned, 1 = Owned"));
            memoryValues.Add(new MemoryValue("Tesla Claw", 0x0013D4D3, "Int8", "Inventory - Weapons", "0 = Not Owned, 1 = Owned"));
            memoryValues.Add(new MemoryValue("Glove of Doom", 0x0013D4D4, "Int8", "Inventory - Weapons", "0 = Not Owned, 1 = Owned"));
            memoryValues.Add(new MemoryValue("Morph-O-Ray", 0x0013D4D5, "Int8", "Inventory - Weapons", "0 = Not Owned, 1 = Owned"));
            memoryValues.Add(new MemoryValue("Hydrodisplacer", 0x0013D4D6, "Int8", "Inventory - Weapons", "0 = Not Owned, 1 = Owned"));
            memoryValues.Add(new MemoryValue("RYNO", 0x0013D4D7, "Int8", "Inventory - Weapons", "0 = Not Owned, 1 = Owned"));
            memoryValues.Add(new MemoryValue("Drone Device", 0x0013D4D8, "Int8", "Inventory - Weapons", "0 = Not Owned, 1 = Owned"));
            memoryValues.Add(new MemoryValue("Decoy Glove", 0x0013D4D9, "Int8", "Inventory - Weapons", "0 = Not Owned, 1 = Owned"));

            // INVENTORY Category - Upgrades
            memoryValues.Add(new MemoryValue("Premium Nanotech", 0x0013D3BC, "Int8", "Inventory - Upgrades", "0 = Not Owned, 1 = Owned"));
            memoryValues.Add(new MemoryValue("Ultra Nanotech", 0x0013D3BD, "Int8", "Inventory - Upgrades", "0 = Not Owned, 1 = Owned"));
            memoryValues.Add(new MemoryValue("Zoomerator", 0x0013D4E5, "Int8", "Inventory - Upgrades", "0 = Not Owned, 1 = Owned"));
            memoryValues.Add(new MemoryValue("Raritanium", 0x0013D4E6, "Int8", "Inventory - Upgrades", "0 = Not Owned, 1 = Owned"));
            memoryValues.Add(new MemoryValue("Codebot", 0x0013D4E7, "Int8", "Inventory - Upgrades", "0 = Not Owned, 1 = Owned"));

            // GOLD Weapons Category
            memoryValues.Add(new MemoryValue("Gold Wrench", 0x0013E528, "Int8", "Gold Weapons", "0 = Not Owned, 1 = Owned"));
            memoryValues.Add(new MemoryValue("Gold Bomb Glove", 0x0013E52A, "Int8", "Gold Weapons", "0 = Not Owned, 1 = Owned"));
            memoryValues.Add(new MemoryValue("Gold Devastator", 0x0013E52B, "Int8", "Gold Weapons", "0 = Not Owned, 1 = Owned"));
            memoryValues.Add(new MemoryValue("Gold Visibomb Gun", 0x0013E52D, "Int8", "Gold Weapons", "0 = Not Owned, 1 = Owned"));
            memoryValues.Add(new MemoryValue("Gold Blaster", 0x0013E52F, "Int8", "Gold Weapons", "0 = Not Owned, 1 = Owned"));
            memoryValues.Add(new MemoryValue("Gold Pyrocitor", 0x0013E530, "Int8", "Gold Weapons", "0 = Not Owned, 1 = Owned"));
            memoryValues.Add(new MemoryValue("Gold Mine Glove", 0x0013E531, "Int8", "Gold Weapons", "0 = Not Owned, 1 = Owned"));
            memoryValues.Add(new MemoryValue("Gold Tesla Claw", 0x0013E533, "Int8", "Gold Weapons", "0 = Not Owned, 1 = Owned"));
            memoryValues.Add(new MemoryValue("Gold Glove of Doom", 0x0013E534, "Int8", "Gold Weapons", "0 = Not Owned, 1 = Owned"));
            memoryValues.Add(new MemoryValue("Gold Morph-O-Ray", 0x0013E535, "Int8", "Gold Weapons", "0 = Not Owned, 1 = Owned"));
            memoryValues.Add(new MemoryValue("Gold RYNO", 0x0013E537, "Int8", "Gold Weapons", "0 = Not Owned, 1 = Owned"));

            return memoryValues;
        }
    }
}
