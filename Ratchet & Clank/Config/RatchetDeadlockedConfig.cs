using Common;
using System.Collections.Generic;

namespace Ratchet___Clank.Config
{
    public class RatchetDeadlockedConfig : IGameMemoryConfig
    {
        public string GameName => "Ratchet: Deadlocked (NTSC)";

        public List<MemoryValue> GetMemoryValues()
        {
            var memoryValues = new List<MemoryValue>();

            // Player Position & Movement
            memoryValues.Add(new MemoryValue("Player X", 0x0016F080, "Float", "Player Position", "X position"));
            memoryValues.Add(new MemoryValue("Player Y", 0x0016F084, "Float", "Player Position", "Y position"));
            memoryValues.Add(new MemoryValue("Player Z", 0x0016F088, "Float", "Player Position", "Z position"));
            memoryValues.Add(new MemoryValue("Player Rotation", 0x0016F090, "Float", "Player Position", "Rotation angle"));
            memoryValues.Add(new MemoryValue("Player Speed X", 0x0016F0A0, "Float", "Player Position", "Movement speed X axis"));
            memoryValues.Add(new MemoryValue("Player Speed Y", 0x0016F0A4, "Float", "Player Position", "Movement speed Y axis"));
            memoryValues.Add(new MemoryValue("Player Speed Z", 0x0016F0A8, "Float", "Player Position", "Movement speed Z axis"));
            memoryValues.Add(new MemoryValue("Strafe Mode", 0x0016F0C0, "Int32", "Player Position", "Strafe mode enabled"));
            memoryValues.Add(new MemoryValue("Jump State", 0x0016F0B8, "Int32", "Player Position", "Jump/air state"));

            // Player Stats
            memoryValues.Add(new MemoryValue("Ratchet HP", 0x00171B42, "Int16", "Player Stats", "Current health points"));
            memoryValues.Add(new MemoryValue("Ratchet Max HP", 0x00171B44, "Int16", "Player Stats", "Maximum health capacity"));
            memoryValues.Add(new MemoryValue("HP Experience", 0x00171B48, "Int32", "Player Stats", "Health experience points"));
            memoryValues.Add(new MemoryValue("Player 1 Skin", 0x00171B52, "Int16", "Player Stats", "Ratchet skin ID"));
            memoryValues.Add(new MemoryValue("Death Count", 0x00171D10, "Int32", "Player Stats", "Total deaths"));

            // Currency & Points
            memoryValues.Add(new MemoryValue("Bolts", 0x00171B40, "Int32", "Currency", "Currency amount"));
            memoryValues.Add(new MemoryValue("Dread Points", 0x00171B4C, "Int32", "Currency", "DreadZone points"));
            memoryValues.Add(new MemoryValue("Skill Points", 0x00171B50, "Int32", "Currency", "Total skill points"));

            // DreadZone Progress
            memoryValues.Add(new MemoryValue("DreadZone Rank", 0x00171B54, "Int16", "DreadZone", "Current DreadZone rank"));
            memoryValues.Add(new MemoryValue("DreadZone Medals", 0x00171B56, "Int16", "DreadZone", "Medals earned"));
            memoryValues.Add(new MemoryValue("DreadZone Progress Flags", 0x00171B58, "Int32", "DreadZone", "Progress flag bits"));

            // Bots
            memoryValues.Add(new MemoryValue("Bots Skin", 0x00171BA4, "Int16", "Bots", "Bot armor skin ID"));
            memoryValues.Add(new MemoryValue("Bot 1 Head Skin", 0x00171BA6, "Int8", "Bots", "Bot 1 head skin"));
            memoryValues.Add(new MemoryValue("Bot 2 Head Skin", 0x00171BA7, "Int8", "Bots", "Bot 2 head skin"));
            memoryValues.Add(new MemoryValue("Bot 1 HP", 0x00171BB0, "Int16", "Bots", "Bot 1 health points"));
            memoryValues.Add(new MemoryValue("Bot 2 HP", 0x00171BB2, "Int16", "Bots", "Bot 2 health points"));
            memoryValues.Add(new MemoryValue("Bot 1 Weapon", 0x00171BB4, "Int16", "Bots", "Bot 1 equipped weapon"));
            memoryValues.Add(new MemoryValue("Bot 2 Weapon", 0x00171BB6, "Int16", "Bots", "Bot 2 equipped weapon"));
            memoryValues.Add(new MemoryValue("Bot 1 XP", 0x00171BB8, "Int16", "Bots", "Bot 1 experience points"));
            memoryValues.Add(new MemoryValue("Bot 2 XP", 0x00171BBA, "Int16", "Bots", "Bot 2 experience points"));

            // Weapons
            memoryValues.Add(new MemoryValue("Weapon Selected", 0x001D4A24, "Int32", "Weapons", "Currently equipped weapon ID"));
            memoryValues.Add(new MemoryValue("Weapon Level", 0x001D4A28, "Int32", "Weapons", "Weapon upgrade level"));
            memoryValues.Add(new MemoryValue("Weapon XP", 0x001D4A2C, "Int32", "Weapons", "Weapon experience points"));
            memoryValues.Add(new MemoryValue("Weapon Ammo", 0x001D4A30, "Int32", "Weapons", "Current weapon ammo"));
            memoryValues.Add(new MemoryValue("Weapons Owned Flags", 0x001D4A20, "Int16", "Weapons", "Weapon ownership flags"));

            // Specific Weapons
            memoryValues.Add(new MemoryValue("Dual Vipers", 0x001D4A47, "Int8", "Weapons - Owned", "Dual Vipers owned"));
            memoryValues.Add(new MemoryValue("Magma Cannon", 0x001D4A8B, "Int8", "Weapons - Owned", "Magma Cannon owned"));
            memoryValues.Add(new MemoryValue("B6-Obliterator", 0x001D4B9B, "Int8", "Weapons - Owned", "B6-Obliterator owned"));
            memoryValues.Add(new MemoryValue("Holoshield Launcher", 0x001D4A4B, "Int8", "Weapons - Owned", "Holoshield Launcher owned"));
            memoryValues.Add(new MemoryValue("Arbiter", 0x001D4A4F, "Int8", "Weapons - Owned", "Arbiter owned"));
            memoryValues.Add(new MemoryValue("Fusion Rifle", 0x001D4A53, "Int8", "Weapons - Owned", "Fusion Rifle owned"));
            memoryValues.Add(new MemoryValue("Hunter Mine Launcher", 0x001D4A57, "Int8", "Weapons - Owned", "Hunter Mine Launcher owned"));
            memoryValues.Add(new MemoryValue("Mini-Turret Launcher", 0x001D4A5B, "Int8", "Weapons - Owned", "Mini-Turret Launcher owned"));
            memoryValues.Add(new MemoryValue("Raptor Launcher", 0x001D4A5F, "Int8", "Weapons - Owned", "Raptor Launcher owned"));

            // Weapon Selector Slots
            memoryValues.Add(new MemoryValue("Weapon Selector Slot 1", 0x001D4A10, "Int8", "Weapon Slots", "Quick select slot 1"));
            memoryValues.Add(new MemoryValue("Weapon Selector Slot 2", 0x001D4A11, "Int8", "Weapon Slots", "Quick select slot 2"));
            memoryValues.Add(new MemoryValue("Weapon Selector Slot 3", 0x001D4A12, "Int8", "Weapon Slots", "Quick select slot 3"));
            memoryValues.Add(new MemoryValue("Weapon Selector Slot 4", 0x001D4A13, "Int8", "Weapon Slots", "Quick select slot 4"));
            memoryValues.Add(new MemoryValue("Weapon Selector Slot 5", 0x001D4A14, "Int8", "Weapon Slots", "Quick select slot 5"));
            memoryValues.Add(new MemoryValue("Weapon Selector Slot 6", 0x001D4A15, "Int8", "Weapon Slots", "Quick select slot 6"));
            memoryValues.Add(new MemoryValue("Weapon Selector Slot 7", 0x001D4A16, "Int8", "Weapon Slots", "Quick select slot 7"));
            memoryValues.Add(new MemoryValue("Weapon Selector Slot 8", 0x001D4A17, "Int8", "Weapon Slots", "Quick select slot 8"));

            // Alpha Mods
            memoryValues.Add(new MemoryValue("Alpha Mods Weapon 1", 0x001D4A60, "Int8", "Alpha Mods", "Weapon 1 alpha mods"));
            memoryValues.Add(new MemoryValue("Alpha Mods Weapon 2", 0x001D4A61, "Int8", "Alpha Mods", "Weapon 2 alpha mods"));
            memoryValues.Add(new MemoryValue("Alpha Mods Weapon 3", 0x001D4A62, "Int8", "Alpha Mods", "Weapon 3 alpha mods"));
            memoryValues.Add(new MemoryValue("Alpha Mods Weapon 4", 0x001D4A63, "Int8", "Alpha Mods", "Weapon 4 alpha mods"));
            memoryValues.Add(new MemoryValue("Alpha Mods Weapon 5", 0x001D4A64, "Int8", "Alpha Mods", "Weapon 5 alpha mods"));
            memoryValues.Add(new MemoryValue("Alpha Mods Weapon 6", 0x001D4A65, "Int8", "Alpha Mods", "Weapon 6 alpha mods"));
            memoryValues.Add(new MemoryValue("Alpha Mods Weapon 7", 0x001D4A66, "Int8", "Alpha Mods", "Weapon 7 alpha mods"));
            memoryValues.Add(new MemoryValue("Alpha Mods Weapon 8", 0x001D4A67, "Int8", "Alpha Mods", "Weapon 8 alpha mods"));
            memoryValues.Add(new MemoryValue("Alpha Mods Weapon 9", 0x001D4A68, "Int8", "Alpha Mods", "Weapon 9 alpha mods"));
            memoryValues.Add(new MemoryValue("Alpha Mods Weapon 10", 0x001D4A69, "Int8", "Alpha Mods", "Weapon 10 alpha mods"));

            // Wrench
            memoryValues.Add(new MemoryValue("Wrench Force", 0x00171BA8, "Int32", "Wrench", "Wrench damage force"));
            memoryValues.Add(new MemoryValue("Wrench Swings", 0x00171BA0, "Int32", "Wrench", "Wrench swing count"));

            // Gadgets
            memoryValues.Add(new MemoryValue("Gravity Boots", 0x00171BAE, "Int8", "Gadgets", "Gravity boots equipped"));
            memoryValues.Add(new MemoryValue("Charge Boots", 0x00171BAF, "Int8", "Gadgets", "Charge boots equipped"));
            memoryValues.Add(new MemoryValue("Gadgets Flags", 0x001D4A22, "Int16", "Gadgets", "Gadget ownership flags"));

            // Hoverbike
            memoryValues.Add(new MemoryValue("Hoverbike HP", 0x0028C4B0, "Int32", "Hoverbike", "Hoverbike health points"));
            memoryValues.Add(new MemoryValue("Hoverbike Boost", 0x0028C4B4, "Float", "Hoverbike", "Hoverbike boost energy"));
            memoryValues.Add(new MemoryValue("Hoverbike Position X", 0x0028C4D0, "Float", "Hoverbike", "Hoverbike X position"));
            memoryValues.Add(new MemoryValue("Hoverbike Position Y", 0x0028C4D4, "Float", "Hoverbike", "Hoverbike Y position"));
            memoryValues.Add(new MemoryValue("Hoverbike Position Z", 0x0028C4D8, "Float", "Hoverbike", "Hoverbike Z position"));
            memoryValues.Add(new MemoryValue("Hoverbike Speed", 0x0028C4E0, "Float", "Hoverbike", "Hoverbike speed"));
            memoryValues.Add(new MemoryValue("Hoverbike Timer", 0x0028C4E4, "Int32", "Hoverbike", "Hoverbike race timer"));

            // Landstalker
            memoryValues.Add(new MemoryValue("Landstalker HP", 0x0030B640, "Int32", "Landstalker", "Landstalker health points"));
            memoryValues.Add(new MemoryValue("Landstalker Ammo", 0x0030B648, "Int32", "Landstalker", "Landstalker ammo"));
            memoryValues.Add(new MemoryValue("Landstalker Rockets", 0x0030B64C, "Int32", "Landstalker", "Landstalker rocket count"));
            memoryValues.Add(new MemoryValue("Landstalker Position X", 0x0030B670, "Float", "Landstalker", "Landstalker X position"));
            memoryValues.Add(new MemoryValue("Landstalker Position Y", 0x0030B674, "Float", "Landstalker", "Landstalker Y position"));
            memoryValues.Add(new MemoryValue("Landstalker Position Z", 0x0030B678, "Float", "Landstalker", "Landstalker Z position"));
            memoryValues.Add(new MemoryValue("Landstalker Rotation", 0x0030B680, "Float", "Landstalker", "Landstalker rotation angle"));

            // Camera
            memoryValues.Add(new MemoryValue("Camera X", 0x0036AA10, "Float", "Camera", "Camera X position"));
            memoryValues.Add(new MemoryValue("Camera Y", 0x0036AA14, "Float", "Camera", "Camera Y position"));
            memoryValues.Add(new MemoryValue("Camera Z", 0x0036AA18, "Float", "Camera", "Camera Z position"));
            memoryValues.Add(new MemoryValue("Camera Rotation", 0x0036AA20, "Float", "Camera", "Camera rotation angle"));
            memoryValues.Add(new MemoryValue("Camera Mode", 0x0036AA28, "Int32", "Camera", "Camera state/mode"));
            memoryValues.Add(new MemoryValue("Camera Speed", 0x002306B4, "Float", "Camera", "Camera movement speed"));
            memoryValues.Add(new MemoryValue("Camera Vertical Distance", 0x0036A990, "Float", "Camera", "Vertical distance from player"));
            memoryValues.Add(new MemoryValue("Camera Height", 0x0036A998, "Float", "Camera", "Height above player"));

            // Arena
            memoryValues.Add(new MemoryValue("Arena ID", 0x00171C40, "Int32", "Arena", "Current arena ID"));
            memoryValues.Add(new MemoryValue("Arena Round ID", 0x00171C44, "Int32", "Arena", "Current round ID"));
            memoryValues.Add(new MemoryValue("Arena Reward Bolts", 0x00171C48, "Int32", "Arena", "Bolt reward amount"));
            memoryValues.Add(new MemoryValue("Arena Reward XP", 0x00171C4C, "Int32", "Arena", "XP reward amount"));
            memoryValues.Add(new MemoryValue("Arena Reward Mods", 0x00171C50, "Int32", "Arena", "Mod reward amount"));
            memoryValues.Add(new MemoryValue("Bonus Round Counter", 0x00171C60, "Int32", "Arena", "Bonus round counter"));
            memoryValues.Add(new MemoryValue("Arena Challenge Pointer", 0x00171C40, "Int32", "Arena", "Arena challenge pointer"));

            // Game Progress
            memoryValues.Add(new MemoryValue("Mission ID", 0x00171D08, "Int32", "Game Progress", "Current mission ID"));
            memoryValues.Add(new MemoryValue("Planet ID", 0x00171D04, "Int32", "Game Progress", "Current planet ID"));
            memoryValues.Add(new MemoryValue("Checkpoint ID", 0x00171D00, "Int32", "Game Progress", "Current checkpoint"));
            memoryValues.Add(new MemoryValue("Game Mode", 0x00171D00, "Int32", "Game Progress", "Current game mode"));
            memoryValues.Add(new MemoryValue("Difficulty", 0x00171B4E, "Int16", "Game Progress", "Game difficulty level"));
            memoryValues.Add(new MemoryValue("Challenge Mode Flag", 0x00171B4A, "Int16", "Game Progress", "Challenge mode enabled"));

            // Audio Settings
            memoryValues.Add(new MemoryValue("Sound", 0x00171D40, "Int32", "Audio", "Master sound toggle"));
            memoryValues.Add(new MemoryValue("Music Volume", 0x00171D44, "Int32", "Audio", "Music volume level"));
            memoryValues.Add(new MemoryValue("Effects Volume", 0x00171D48, "Int32", "Audio", "Sound effects volume"));
            memoryValues.Add(new MemoryValue("Dialogue Volume", 0x00171D4C, "Int32", "Audio", "Dialogue volume level"));

            // Display Settings
            memoryValues.Add(new MemoryValue("Widescreen", 0x00171DEB, "Int8", "Display", "Widescreen mode enabled"));
            memoryValues.Add(new MemoryValue("Progressive Scan", 0x0021DE6C, "Int32", "Display", "Progressive scan enabled"));
            memoryValues.Add(new MemoryValue("Subtitles", 0x00171D3E, "Int16", "Display", "Subtitles enabled"));
            memoryValues.Add(new MemoryValue("Help Text", 0x00171D3D, "Int8", "Display", "Help text enabled"));

            // Menu/UI
            memoryValues.Add(new MemoryValue("HUD State", 0x00171B90, "Int32", "Menu", "HUD display state"));
            memoryValues.Add(new MemoryValue("Menu Cursor", 0x00171D98, "Int32", "Menu", "Menu cursor position"));
            memoryValues.Add(new MemoryValue("Menu State", 0x00171D94, "Int32", "Menu", "Menu state"));
            memoryValues.Add(new MemoryValue("Pause ID", 0x00171D8C, "Int32", "Menu", "Pause menu ID"));

            // Vendor/Shop
            memoryValues.Add(new MemoryValue("Vendor Item ID", 0x00171DF0, "Int32", "Vendor", "Selected vendor item"));
            memoryValues.Add(new MemoryValue("Vendor Price", 0x00171DF4, "Int32", "Vendor", "Item price"));
            memoryValues.Add(new MemoryValue("Vendor Confirm Flag", 0x00171DF8, "Int32", "Vendor", "Purchase confirmation"));
            memoryValues.Add(new MemoryValue("Vendor Inventory", 0x00171DFC, "Int32", "Vendor", "Vendor inventory state"));

            // Game Engine
            memoryValues.Add(new MemoryValue("Global Timer", 0x00171D20, "Int32", "Engine", "Global timer counter"));
            memoryValues.Add(new MemoryValue("Frame Counter", 0x00171D1C, "Int32", "Engine", "Frame count"));
            memoryValues.Add(new MemoryValue("Enemy HP", 0x00200000, "Int32", "Engine", "Enemy health pointer"));
            memoryValues.Add(new MemoryValue("Enemy Count", 0x001A0000, "Int32", "Engine", "Active enemy count"));
            memoryValues.Add(new MemoryValue("Script Flag", 0x001ACF14, "Int32", "Engine", "Script execution flag"));
            memoryValues.Add(new MemoryValue("Collision Flag", 0x0016F09C, "Int32", "Engine", "Collision detection flag"));
            memoryValues.Add(new MemoryValue("Load Zone ID", 0x0016F0A2, "Int16", "Engine", "Load zone trigger ID"));

            // Cheats & Flags
            memoryValues.Add(new MemoryValue("Invincibility", 0x0016F091, "Int8", "Cheats", "Invincibility mode"));
            memoryValues.Add(new MemoryValue("Infinite Ammo Flag", 0x001D4A31, "Int8", "Cheats", "Unlimited ammo"));
            memoryValues.Add(new MemoryValue("Infinite Health", 0x00171B42, "Int16", "Cheats", "Unlimited health"));
            memoryValues.Add(new MemoryValue("Infinite Bolts", 0x00171B40, "Int32", "Cheats", "Unlimited currency"));
            memoryValues.Add(new MemoryValue("Input Lock", 0x00171E10, "Int32", "Cheats", "Lock controller input"));
            memoryValues.Add(new MemoryValue("Movement Lock", 0x0016F0C8, "Int32", "Cheats", "Lock player movement"));
            memoryValues.Add(new MemoryValue("AI Freeze", 0x0016F0CC, "Int32", "Cheats", "Freeze enemy AI"));
            memoryValues.Add(new MemoryValue("Cheat Flags", 0x00171DEC, "Int32", "Cheats", "Cheat code flags"));

            // Advanced Pointers
            memoryValues.Add(new MemoryValue("Level Pointer", 0x0016E000, "Int32", "Advanced", "Level data pointer"));
            memoryValues.Add(new MemoryValue("Ratchet Pointer", 0x0016F000, "Int32", "Advanced", "Ratchet entity pointer"));
            memoryValues.Add(new MemoryValue("Texture Pointer", 0x001F0000, "Int32", "Advanced", "Texture memory pointer"));
            memoryValues.Add(new MemoryValue("Vehicle Pointer", 0x0028C480, "Int32", "Advanced", "Vehicle entity pointer"));

            return memoryValues;
        }
    }
}
