using Common;
using System.Collections.Generic;

namespace Games.RatchetClank
{
    public class RatchetSizeMattersConfig : IGameMemoryConfig
    {
        public string GameName => "Ratchet & Clank: Size Matters (NTSC)";

        public List<MemoryValue> GetMemoryValues()
        {
            var memoryValues = new List<MemoryValue>();

            // Lacerator
            memoryValues.Add(new MemoryValue("Lacerator - Level", 0x00f3ea44, "Int32", "Weapons - Lacerator", "Weapon level (0=Level 1, 3=Level 4)"));
            memoryValues.Add(new MemoryValue("Lacerator - Ammo", 0x00f3ea48, "Int32", "Weapons - Lacerator", "Current ammo"));
            memoryValues.Add(new MemoryValue("Lacerator - EXP", 0x00f3ea4c, "Int32", "Weapons - Lacerator", "Experience points"));
            memoryValues.Add(new MemoryValue("Lacerator - Mod 1", 0x00f3ea54, "Int8", "Weapons - Lacerator", "Mod slot 1"));
            memoryValues.Add(new MemoryValue("Lacerator - Mod 2", 0x00f3ea55, "Int8", "Weapons - Lacerator", "Mod slot 2"));

            // Concussion Gun
            memoryValues.Add(new MemoryValue("Concussion Gun - Level", 0x00f3ea9c, "Int32", "Weapons - Concussion Gun", "Weapon level"));
            memoryValues.Add(new MemoryValue("Concussion Gun - Ammo", 0x00f3eaa0, "Int32", "Weapons - Concussion Gun", "Current ammo"));
            memoryValues.Add(new MemoryValue("Concussion Gun - EXP", 0x00f3eaa4, "Int32", "Weapons - Concussion Gun", "Experience points"));
            memoryValues.Add(new MemoryValue("Concussion Gun - Mod 1", 0x00f3eaac, "Int8", "Weapons - Concussion Gun", "Mod slot 1"));
            memoryValues.Add(new MemoryValue("Concussion Gun - Mod 2", 0x00f3eaad, "Int8", "Weapons - Concussion Gun", "Mod slot 2"));
            memoryValues.Add(new MemoryValue("Concussion Gun - Mod 3", 0x00f3eaae, "Int8", "Weapons - Concussion Gun", "Mod slot 3"));
            memoryValues.Add(new MemoryValue("Concussion Gun - Unlock Flag (USA)", 0x00f3eab4, "Int32", "Weapons - Concussion Gun", "Unlock flag (USA version)"));
            memoryValues.Add(new MemoryValue("Concussion Gun - Unlock Flag (EU)", 0x00f3eb34, "Int32", "Weapons - Concussion Gun", "Unlock flag (EU version)"));

            // Acid Bomb Glove
            memoryValues.Add(new MemoryValue("Acid Bomb Glove - Level", 0x00f3eaf4, "Int32", "Weapons - Acid Bomb Glove", "Weapon level"));
            memoryValues.Add(new MemoryValue("Acid Bomb Glove - Ammo", 0x00f3eaf8, "Int32", "Weapons - Acid Bomb Glove", "Current ammo"));
            memoryValues.Add(new MemoryValue("Acid Bomb Glove - EXP", 0x00f3eafc, "Int32", "Weapons - Acid Bomb Glove", "Experience points"));
            memoryValues.Add(new MemoryValue("Acid Bomb Glove - Mod 1", 0x00f3eb04, "Int8", "Weapons - Acid Bomb Glove", "Mod slot 1"));

            // Agents of Doom
            memoryValues.Add(new MemoryValue("Agents of Doom - Level", 0x00f3eb4c, "Int32", "Weapons - Agents of Doom", "Weapon level"));
            memoryValues.Add(new MemoryValue("Agents of Doom - EXP", 0x00f3eb54, "Int32", "Weapons - Agents of Doom", "Experience points"));
            memoryValues.Add(new MemoryValue("Agents of Doom - Mod 1", 0x00f3eb5c, "Int8", "Weapons - Agents of Doom", "Mod slot 1"));
            memoryValues.Add(new MemoryValue("Agents of Doom - Mod 2", 0x00f3eb5d, "Int8", "Weapons - Agents of Doom", "Mod slot 2"));
            memoryValues.Add(new MemoryValue("Agents of Doom - Unlock Flag", 0x00f3eb64, "Int32", "Weapons - Agents of Doom", "Unlock flag"));

            // Bee Mine Glove
            memoryValues.Add(new MemoryValue("Bee Mine Glove - EXP", 0x00f3ebac, "Int32", "Weapons - Bee Mine Glove", "Experience points"));
            memoryValues.Add(new MemoryValue("Bee Mine Glove - Unlock Flag", 0x00f3ebbc, "Int32", "Weapons - Bee Mine Glove", "Unlock flag"));

            // Static Barrier
            memoryValues.Add(new MemoryValue("Static Barrier - EXP", 0x00f3ec04, "Int32", "Weapons - Static Barrier", "Experience points"));
            memoryValues.Add(new MemoryValue("Static Barrier - Unlock Flag", 0x00f3ec14, "Int32", "Weapons - Static Barrier", "Unlock flag"));

            // Shock Rocket
            memoryValues.Add(new MemoryValue("Shock Rocket - EXP", 0x00f3ec5c, "Int32", "Weapons - Shock Rocket", "Experience points"));
            memoryValues.Add(new MemoryValue("Shock Rocket - Unlock Flag", 0x00f3ec6c, "Int32", "Weapons - Shock Rocket", "Unlock flag"));

            // Sniper Mine
            memoryValues.Add(new MemoryValue("Sniper Mine - EXP", 0x00f3ecb4, "Int32", "Weapons - Sniper Mine", "Experience points"));
            memoryValues.Add(new MemoryValue("Sniper Mine - Unlock Flag", 0x00f3ecc4, "Int32", "Weapons - Sniper Mine", "Unlock flag"));

            // Scorcher
            memoryValues.Add(new MemoryValue("Scorcher - EXP", 0x00f3ed0c, "Int32", "Weapons - Scorcher", "Experience points"));
            memoryValues.Add(new MemoryValue("Scorcher - Unlock Flag", 0x00f3ed1c, "Int32", "Weapons - Scorcher", "Unlock flag"));

            // Laser Tracer
            memoryValues.Add(new MemoryValue("Laser Tracer - EXP", 0x00f3ed64, "Int32", "Weapons - Laser Tracer", "Experience points"));
            memoryValues.Add(new MemoryValue("Laser Tracer - Unlock Flag", 0x00f3ed74, "Int32", "Weapons - Laser Tracer", "Unlock flag"));

            // Suck Cannon
            memoryValues.Add(new MemoryValue("Suck Cannon - EXP", 0x00f3edbc, "Int32", "Weapons - Suck Cannon", "Experience points"));
            memoryValues.Add(new MemoryValue("Suck Cannon - Unlock Flag", 0x00f3edcc, "Int32", "Weapons - Suck Cannon", "Unlock flag"));

            // Mootator
            memoryValues.Add(new MemoryValue("Mootator - EXP", 0x00f3ee14, "Int32", "Weapons - Mootator", "Experience points"));
            memoryValues.Add(new MemoryValue("Mootator - Unlock Flag", 0x00f3ee24, "Int32", "Weapons - Mootator", "Unlock flag"));

            // RYNO
            memoryValues.Add(new MemoryValue("RYNO - EXP", 0x00f3eec4, "Int32", "Weapons - RYNO", "Experience points"));
            memoryValues.Add(new MemoryValue("RYNO - Unlock Flag", 0x00f3eed4, "Int32", "Weapons - RYNO", "Unlock flag"));

            // Gadgets
            memoryValues.Add(new MemoryValue("Hypershot", 0x00f3ef2c, "Int32", "Gadgets", "Hypershot owned"));
            memoryValues.Add(new MemoryValue("Sprout-o-Matic", 0x00f3ef84, "Int32", "Gadgets", "Sprout-o-Matic owned"));
            memoryValues.Add(new MemoryValue("Polarizer", 0x00f3efdc, "Int32", "Gadgets", "Polarizer owned"));
            memoryValues.Add(new MemoryValue("PDA", 0x00f3f034, "Int32", "Gadgets", "PDA owned"));
            memoryValues.Add(new MemoryValue("Shrink Ray", 0x00f3f08c, "Int32", "Gadgets", "Shrink Ray owned"));
            memoryValues.Add(new MemoryValue("Bolt Grabber", 0x00f3f0e4, "Int32", "Gadgets", "Bolt Grabber owned"));
            memoryValues.Add(new MemoryValue("Map-o-Matic", 0x00f3f194, "Int32", "Gadgets", "Map-o-Matic owned"));

            // Current Weapon
            memoryValues.Add(new MemoryValue("Current Weapon - Ammo", 0x00f47b68, "Int32", "Current Weapon", "Current weapon ammo"));
            memoryValues.Add(new MemoryValue("Current Weapon - Max Ammo", 0x00f47b70, "Int32", "Current Weapon", "Current weapon max ammo"));
            memoryValues.Add(new MemoryValue("Currently Held Weapon/Gadget", 0x00f80e60, "Int32", "Current Weapon", "ID of currently equipped weapon or gadget"));

            // Armor - Currently Equipped
            memoryValues.Add(new MemoryValue("Equipped Body Armor", 0x01f4b354, "Int8", "Armor - Equipped", "Currently equipped body armor",
@"0x00 = None
0x01 = Wildfire
0x02 = Sludge Mk.9
0x03 = Crystallix
0x04 = Electroshock
0x05 = Mega-Bomb
0x06 = Hyperborean
0x07 = Chameleon"));
            memoryValues.Add(new MemoryValue("Equipped Helmet", 0x01f4b355, "Int8", "Armor - Equipped", "Currently equipped helmet",
@"0x00 = None
0x01 = Wildfire
0x02 = Sludge Mk.9
0x03 = Crystallix
0x04 = Electroshock
0x05 = Mega-Bomb
0x06 = Hyperborean
0x07 = Chameleon"));
            memoryValues.Add(new MemoryValue("Equipped Gloves", 0x01f4b356, "Int8", "Armor - Equipped", "Currently equipped gloves",
@"0x00 = None
0x01 = Wildfire
0x02 = Sludge Mk.9
0x03 = Crystallix
0x04 = Electroshock
0x05 = Mega-Bomb
0x06 = Hyperborean
0x07 = Chameleon"));
            memoryValues.Add(new MemoryValue("Equipped Boots", 0x01f4b358, "Int8", "Armor - Equipped", "Currently equipped boots",
@"0x00 = None
0x01 = Wildfire
0x02 = Sludge Mk.9
0x03 = Crystallix
0x04 = Electroshock
0x05 = Mega-Bomb
0x06 = Hyperborean
0x07 = Chameleon"));

            // Armor Unlock Flags
            memoryValues.Add(new MemoryValue("Armor Unlocked - Wildfire", 0x01f4b35a, "Int8", "Armor - Unlocked", "Wildfire armor pieces unlocked",
@"bit0 = Body Armor
bit1 = Helmet
bit2 = Gloves
bit4 = Boots"));
            memoryValues.Add(new MemoryValue("Armor Unlocked - Sludge Mk.9", 0x01f4b35b, "Int8", "Armor - Unlocked", "Sludge Mk.9 armor pieces unlocked",
@"bit0 = Body Armor
bit1 = Helmet
bit2 = Gloves
bit4 = Boots"));
            memoryValues.Add(new MemoryValue("Armor Unlocked - Crystallix", 0x01f4b35c, "Int8", "Armor - Unlocked", "Crystallix armor pieces unlocked",
@"bit0 = Body Armor
bit1 = Helmet
bit2 = Gloves
bit4 = Boots"));
            memoryValues.Add(new MemoryValue("Armor Unlocked - Electroshock", 0x01f4b35d, "Int8", "Armor - Unlocked", "Electroshock armor pieces unlocked",
@"bit0 = Body Armor
bit1 = Helmet
bit2 = Gloves
bit4 = Boots"));
            memoryValues.Add(new MemoryValue("Armor Unlocked - Mega-Bomb", 0x01f4b35e, "Int8", "Armor - Unlocked", "Mega-Bomb armor pieces unlocked",
@"bit0 = Body Armor
bit1 = Helmet
bit2 = Gloves
bit4 = Boots"));
            memoryValues.Add(new MemoryValue("Armor Unlocked - Hyperborean", 0x01f4b35f, "Int8", "Armor - Unlocked", "Hyperborean armor pieces unlocked",
@"bit0 = Body Armor
bit1 = Helmet
bit2 = Gloves
bit4 = Boots"));
            memoryValues.Add(new MemoryValue("Armor Unlocked - Chameleon", 0x01f4b360, "Int8", "Armor - Unlocked", "Chameleon armor pieces unlocked",
@"bit0 = Body Armor
bit1 = Helmet
bit2 = Gloves
bit4 = Boots"));

            // Missions
            memoryValues.Add(new MemoryValue("Pokitaru Missions", 0x01f4b3c4, "Int32", "Missions", "Pokitaru mission progress"));

            // Skill Points
            memoryValues.Add(new MemoryValue("Skill Points 1", 0x01f4b437, "Int8", "Skill Points", "Skill point bitflags",
@"bit0 = Train Faster
bit1 = Don't Rock the Boat
bit2 = Do Cows Get Crabby?
bit4 = Bury the Pygmies
bit5 = Lights, Camera, Action!
bit6 = Ship It"));
            memoryValues.Add(new MemoryValue("Skill Points 2", 0x01f4b438, "Int8", "Skill Points", "Skill point bitflags",
@"bit0 = Explosive Ordnance Disposal
bit1 = Super Lombax
bit2 = Be A Cool Skyboarder
bit4 = Shutout
bit5 = Terror of the Skies
bit6 = Ultimate Gladiator"));
            memoryValues.Add(new MemoryValue("Skill Points 3", 0x01f4b439, "Int8", "Skill Points", "Skill point bitflags",
@"bit0 = Friends Don't Hurt Friends
bit1 = Night Terrors
bit4 = Be An Awesome Skyboarder"));
            memoryValues.Add(new MemoryValue("Skill Points 4", 0x01f4b43a, "Int8", "Skill Points", "Skill point bitflags",
@"bit0 = Take Them Down a Shock
bit1 = High Tech Weapons Master
bit2 = No More Varmints!
bit4 = Ultimate Gladiator
bit5 = Wool Protest
bit6 = Bouncy, Bouncy, Bouncy"));
            memoryValues.Add(new MemoryValue("Skill Points 5", 0x01f4b43b, "Int8", "Skill Points", "Skill point bitflags",
@"bit0 = Not the Shock of Me Now
bit1 = Ratchet... Just Ratchet
bit4 = Elite Annihilation
bit5 = Storm the Front"));

            // Armor Sets Completed
            memoryValues.Add(new MemoryValue("Armor Sets Completed 1", 0x01f4b442, "Int8", "Armor Sets", "Completed armor set bitflags",
@"bit0 = Wildfire
bit1 = Sludge Mk. 9
bit2 = Crystallix
bit3 = Electroshock
bit4 = Mega-Bomb
bit5 = Hyperborean
bit6 = Chameleon
bit7 = Fire-Bomb"));
            memoryValues.Add(new MemoryValue("Armor Sets Completed 2", 0x01f4b443, "Int8", "Armor Sets", "Completed armor set bitflags",
@"bit0 = Shock Crystal
bit1 = Wildburst
bit2 = Triple Wave
bit3 = Ice II
bit4 = Stalker"));

            // Collectibles
            memoryValues.Add(new MemoryValue("Titanium Bolt Flags Start", 0x01f4b444, "Int32", "Collectibles", "Start of Titanium Bolt flags"));
            memoryValues.Add(new MemoryValue("Titanium Bolts Count", 0x01f4b449, "Int8", "Collectibles", "Total Titanium Bolts collected"));

            // Game Mode
            memoryValues.Add(new MemoryValue("Hardcore Mode Flag", 0x01f4b452, "Int8", "Game Mode", "Hardcore mode active (0xFF = Hardcore)"));

            // Skins
            memoryValues.Add(new MemoryValue("Skins Unlocked", 0x01f4b45a, "Int8", "Skins", "Unlocked skins bitflags",
@"bit0 = Default
bit1 = Plundering Pirate
bit2 = Ratchetzilla
bit4 = Tropical Vacation
bit5 = Kanga-Ratchet
bit6 = Hiro Ratchet"));
            memoryValues.Add(new MemoryValue("Current Skin", 0x01f4b45b, "Int8", "Skins", "Currently equipped skin ID"));

            // Cinematics
            memoryValues.Add(new MemoryValue("Cinematics 1", 0x01f4b462, "Int8", "Cinematics", "Watched cinematics bitflags",
@"bit0 = Introduction
bit1 = Abduction
bit2 = Technomites?"));
            memoryValues.Add(new MemoryValue("Cinematics 2", 0x01f4b466, "Int8", "Cinematics", "Watched cinematics bitflags",
@"bit0 = Arrival"));

            // Cheats
            memoryValues.Add(new MemoryValue("Cheat Bitflags", 0x01f4c440, "Int32", "Cheats", "Activated cheat codes"));

            // Currency & Progress
            memoryValues.Add(new MemoryValue("Current Bolts", 0x01f4c768, "Int32", "Currency", "Current bolt count"));
            memoryValues.Add(new MemoryValue("Map ID", 0x01f4c76c, "Int32", "Game State", "Current map/level ID",
@"0x00 = Main Menu
0x01 = Pokitaru"));
            memoryValues.Add(new MemoryValue("Challenge Mode (NG+)", 0x01f4c778, "Int32", "Game Mode", "Challenge Mode / New Game+ active"));

            return memoryValues;
        }
    }
}
