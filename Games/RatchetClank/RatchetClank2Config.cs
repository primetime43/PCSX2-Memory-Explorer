using Common;
using System.Collections.Generic;

namespace Games.RatchetClank
{
    public class RatchetClank2Config : IGameMemoryConfig
    {
        public string GameName => "Ratchet & Clank: Going Commando (NTSC)";

        public List<MemoryValue> GetMemoryValues()
        {
            var memoryValues = new List<MemoryValue>();

            // Player Position & Movement
            memoryValues.Add(new MemoryValue("Ratchet X Coordinate", 0x00189EA0, "Float", "Player Position", "X position of Ratchet"));
            memoryValues.Add(new MemoryValue("Ratchet Y Coordinate", 0x00189EA4, "Float", "Player Position", "Y position of Ratchet"));
            memoryValues.Add(new MemoryValue("Ratchet Z Coordinate", 0x00189EA8, "Float", "Player Position", "Z position of Ratchet"));
            memoryValues.Add(new MemoryValue("Player Rotation", 0x00189EB0, "Float", "Player Position", "Ratchet's rotation angle"));
            memoryValues.Add(new MemoryValue("Player Speed X", 0x00189EC0, "Float", "Player Position", "Movement speed X axis"));
            memoryValues.Add(new MemoryValue("Player Speed Y", 0x00189EC4, "Float", "Player Position", "Movement speed Y axis"));
            memoryValues.Add(new MemoryValue("Player Speed Z", 0x00189EC8, "Float", "Player Position", "Movement speed Z axis"));

            // Player Stats
            memoryValues.Add(new MemoryValue("Nanotech (Health)", 0x0018C2EC, "Int32", "Player Stats", "Current health points"));
            memoryValues.Add(new MemoryValue("Nanotech XP", 0x001A7A0C, "Int32", "Player Stats", "Health experience points"));
            memoryValues.Add(new MemoryValue("Ratchet's State", 0x0018C0B4, "Int32", "Player Stats", "Current player state"));
            memoryValues.Add(new MemoryValue("Neutral Speed", 0x00189FD4, "Float", "Player Stats", "Base movement speed"));
            memoryValues.Add(new MemoryValue("Jump State", 0x0018C0B8, "Int32", "Player Stats", "Jump/air state"));
            memoryValues.Add(new MemoryValue("Current Armor", 0x0018C2F4, "Int32", "Player Stats", "Equipped armor ID"));
            memoryValues.Add(new MemoryValue("Armor Value", 0x0018C2F8, "Int32", "Player Stats", "Armor protection value"));

            // Currency & Resources
            memoryValues.Add(new MemoryValue("Bolts", 0x001A79F8, "Int32", "Currency", "Currency amount"));
            memoryValues.Add(new MemoryValue("Raritanium", 0x001A79FC, "Int32", "Currency", "Raritanium crystals"));
            memoryValues.Add(new MemoryValue("Crystals", 0x001A7A1A, "Int16", "Currency", "Crystal count"));
            memoryValues.Add(new MemoryValue("Arena Points", 0x001A8C3C, "Int32", "Currency", "Arena challenge points"));

            // Weapons
            memoryValues.Add(new MemoryValue("Current Weapon", 0x0018C240, "Int32", "Weapons", "Currently equipped weapon ID"));
            memoryValues.Add(new MemoryValue("Weapon Ammo", 0x0018C244, "Int32", "Weapons", "Current weapon ammo count"));
            memoryValues.Add(new MemoryValue("Wrench Attack", 0x0018C0BC, "Int32", "Weapons", "Wrench attack state"));
            memoryValues.Add(new MemoryValue("Wrench Damage", 0x0018C250, "Int32", "Weapons", "Wrench damage value"));
            memoryValues.Add(new MemoryValue("Weapon XP", 0x001A7A04, "Int32", "Weapons", "Weapon experience points"));
            memoryValues.Add(new MemoryValue("Weapon Level", 0x001A7A08, "Int32", "Weapons", "Weapon upgrade level"));

            // Weapon Quick Select
            memoryValues.Add(new MemoryValue("Weapon Cycle Slot 1", 0x001A79A8, "Int32", "Weapon Slots", "Weapon in cycle slot 1"));
            memoryValues.Add(new MemoryValue("Weapon Cycle Slot 2", 0x001A79AC, "Int32", "Weapon Slots", "Weapon in cycle slot 2"));
            memoryValues.Add(new MemoryValue("Weapon Cycle Slot 3", 0x001A79B0, "Int32", "Weapon Slots", "Weapon in cycle slot 3"));
            memoryValues.Add(new MemoryValue("Weapon Cycle Slot 4", 0x001A79B4, "Int32", "Weapon Slots", "Weapon in cycle slot 4"));
            memoryValues.Add(new MemoryValue("Weapon Cycle Slot 5", 0x001A79B8, "Int32", "Weapon Slots", "Weapon in cycle slot 5"));
            memoryValues.Add(new MemoryValue("Weapon Cycle Slot 6", 0x001A79BC, "Int32", "Weapon Slots", "Weapon in cycle slot 6"));
            memoryValues.Add(new MemoryValue("Weapon Cycle Slot 7", 0x001A79C0, "Int32", "Weapon Slots", "Weapon in cycle slot 7"));
            memoryValues.Add(new MemoryValue("Weapon Cycle Slot 8", 0x001A79C4, "Int32", "Weapon Slots", "Weapon in cycle slot 8"));
            memoryValues.Add(new MemoryValue("Weapon Cycle Slot 9", 0x001A79C8, "Int32", "Weapon Slots", "Weapon in cycle slot 9"));
            memoryValues.Add(new MemoryValue("Weapon Cycle Slot 10", 0x001A79CC, "Int32", "Weapon Slots", "Weapon in cycle slot 10"));
            memoryValues.Add(new MemoryValue("Weapon Quick Select 1", 0x001A79D0, "Int32", "Weapon Slots", "Quick select weapon 1"));
            memoryValues.Add(new MemoryValue("Weapon Quick Select 2", 0x001A79D4, "Int32", "Weapon Slots", "Quick select weapon 2"));
            memoryValues.Add(new MemoryValue("Weapon Quick Select 3", 0x001A79D8, "Int32", "Weapon Slots", "Quick select weapon 3"));
            memoryValues.Add(new MemoryValue("Weapon Quick Select 4", 0x001A79DC, "Int32", "Weapon Slots", "Quick select weapon 4"));
            memoryValues.Add(new MemoryValue("Weapon Quick Select 5", 0x001A79E0, "Int32", "Weapon Slots", "Quick select weapon 5"));
            memoryValues.Add(new MemoryValue("Weapon Quick Select 6", 0x001A79E4, "Int32", "Weapon Slots", "Quick select weapon 6"));
            memoryValues.Add(new MemoryValue("Weapon Quick Select 7", 0x001A79E8, "Int32", "Weapon Slots", "Quick select weapon 7"));
            memoryValues.Add(new MemoryValue("Weapon Quick Select 8", 0x001A79EC, "Int32", "Weapon Slots", "Quick select weapon 8"));

            // Gadgets & Items
            memoryValues.Add(new MemoryValue("Gravity Boots", 0x0018C324, "Int8", "Gadgets", "Gravity boots equipped"));
            memoryValues.Add(new MemoryValue("Charge Boots", 0x0018C325, "Int8", "Gadgets", "Charge boots equipped"));
            memoryValues.Add(new MemoryValue("Thruster Pack", 0x0018C326, "Int8", "Gadgets", "Thruster pack equipped"));
            memoryValues.Add(new MemoryValue("Map-O-Matic", 0x0018C327, "Int8", "Gadgets", "Map-o-matic equipped"));
            memoryValues.Add(new MemoryValue("Leviathan Flail", 0x0018C330, "Int8", "Gadgets", "Leviathan flail equipped"));
            memoryValues.Add(new MemoryValue("Strafe Mode", 0x0018C0C0, "Int32", "Gadgets", "Strafe mode enabled"));
            memoryValues.Add(new MemoryValue("Ghost Ratchet", 0x0018A010, "Int32", "Gadgets", "Ghost mode value"));

            // Multipliers & Bonuses
            memoryValues.Add(new MemoryValue("Health Multiplier", 0x0018C31C, "Int32", "Multipliers", "Health multiplier value"));
            memoryValues.Add(new MemoryValue("Bolt Multiplier", 0x001A79E8, "Int32", "Multipliers", "Bolt collection multiplier"));

            // Space Ship
            memoryValues.Add(new MemoryValue("Ship HP", 0x01A6C490, "Int32", "Space Ship", "Ship health points"));
            memoryValues.Add(new MemoryValue("Ship Shield", 0x01A6C4A0, "Int32", "Space Ship", "Ship shield strength"));
            memoryValues.Add(new MemoryValue("Ship Missiles", 0x01A6C4AC, "Int32", "Space Ship", "Ship missile count"));
            memoryValues.Add(new MemoryValue("Ship Guns", 0x01A6C49C, "Int32", "Space Ship", "Ship gun ammo"));
            memoryValues.Add(new MemoryValue("Ship Position X", 0x01B80090, "Float", "Space Ship", "Ship X coordinate"));
            memoryValues.Add(new MemoryValue("Ship Position Y", 0x01B80094, "Float", "Space Ship", "Ship Y coordinate"));
            memoryValues.Add(new MemoryValue("Ship Position Z", 0x01B80098, "Float", "Space Ship", "Ship Z coordinate"));
            memoryValues.Add(new MemoryValue("Ship Boost", 0x01A6C4B8, "Float", "Space Ship", "Ship boost energy"));
            memoryValues.Add(new MemoryValue("Ship Pitch", 0x01B80070, "Float", "Space Ship", "Ship pitch rotation"));
            memoryValues.Add(new MemoryValue("Ship Yaw", 0x01B80074, "Float", "Space Ship", "Ship yaw rotation"));
            memoryValues.Add(new MemoryValue("Ship Roll", 0x01B80078, "Float", "Space Ship", "Ship roll rotation"));
            memoryValues.Add(new MemoryValue("Ship Speed", 0x01A6C4B0, "Float", "Space Ship", "Ship current speed"));

            // Hoverbike Racing
            memoryValues.Add(new MemoryValue("Hoverbike Boost", 0x01E6ADAC, "Int32", "Hoverbike", "Hoverbike boost energy"));
            memoryValues.Add(new MemoryValue("Hoverbike Speed", 0x01E6AD98, "Float", "Hoverbike", "Hoverbike speed"));
            memoryValues.Add(new MemoryValue("Hoverbike Time", 0x01E6ADA8, "Int32", "Hoverbike", "Hoverbike race time"));
            memoryValues.Add(new MemoryValue("Hoverbike Position", 0x01E6AD90, "Float", "Hoverbike", "Hoverbike track position"));
            memoryValues.Add(new MemoryValue("Hoverbike Time Trial", 0x01E6AD80, "Int32", "Hoverbike", "Time trial mode"));
            memoryValues.Add(new MemoryValue("Hoverbike Race State", 0x01E6AD88, "Int32", "Hoverbike", "Current race state"));
            memoryValues.Add(new MemoryValue("Barlow Race Lap", 0x001A8FE4, "Int32", "Hoverbike", "Current lap number"));
            memoryValues.Add(new MemoryValue("Barlow Boost Time", 0x01E6ADA8, "Int32", "Hoverbike", "Boost duration"));
            memoryValues.Add(new MemoryValue("Barlow Boosts", 0x01E6ADAC, "Int32", "Hoverbike", "Number of boosts"));
            memoryValues.Add(new MemoryValue("Barlow Hoverbike State", 0x01E6AD70, "Int32", "Hoverbike", "Barlow race state"));

            // Arena
            memoryValues.Add(new MemoryValue("Arena Challenge ID", 0x001A8C44, "Int32", "Arena", "Current challenge ID"));
            memoryValues.Add(new MemoryValue("Arena Challenge Complete", 0x001A8C45, "Int8", "Arena", "Challenge completion flag"));
            memoryValues.Add(new MemoryValue("Arena Bolt Reward", 0x001A8C48, "Int32", "Arena", "Bolt reward amount"));
            memoryValues.Add(new MemoryValue("Arena Nanotech Reward", 0x001A8C4C, "Int32", "Arena", "Health reward amount"));
            memoryValues.Add(new MemoryValue("Arena Weapon Unlock", 0x001A8C50, "Int32", "Arena", "Unlocked weapon ID"));
            memoryValues.Add(new MemoryValue("Arena Multiplier", 0x001A8C54, "Int32", "Arena", "Arena score multiplier"));

            // Game Progress
            memoryValues.Add(new MemoryValue("Ship Selected Planet", 0x001CA310, "Int32", "Game Progress", "Currently selected planet"));
            memoryValues.Add(new MemoryValue("Planet ID", 0x0018C0B0, "Int32", "Game Progress", "Current planet ID"));
            memoryValues.Add(new MemoryValue("Checkpoint ID", 0x001CA30C, "Int32", "Game Progress", "Current checkpoint"));
            memoryValues.Add(new MemoryValue("Mission Progress ID", 0x001A7A34, "Int32", "Game Progress", "Mission progress tracker"));
            memoryValues.Add(new MemoryValue("Mission Script Flag", 0x001A7A38, "Int32", "Game Progress", "Mission script state"));
            memoryValues.Add(new MemoryValue("Cutscene ID", 0x001CA314, "Int32", "Game Progress", "Current cutscene ID"));
            memoryValues.Add(new MemoryValue("Skill Points", 0x001A7A28, "Int32", "Game Progress", "Total skill points"));
            memoryValues.Add(new MemoryValue("Skill Point Unlock Flags", 0x001A7A2C, "Int32", "Game Progress", "Unlocked skill points"));
            memoryValues.Add(new MemoryValue("NG+ Flag", 0x001A7A30, "Int32", "Game Progress", "New Game Plus flag"));
            memoryValues.Add(new MemoryValue("Difficulty", 0x0018C2F0, "Int32", "Game Progress", "Game difficulty level"));
            memoryValues.Add(new MemoryValue("Planet Completion Flag", 0x001A7A40, "Int32", "Game Progress", "Planet completion status"));
            memoryValues.Add(new MemoryValue("Raritanium Bomb Unlock", 0x001A7A44, "Int32", "Game Progress", "Raritanium bomb unlocked"));

            // Camera
            memoryValues.Add(new MemoryValue("Camera X", 0x001AF210, "Float", "Camera", "Camera X position"));
            memoryValues.Add(new MemoryValue("Camera Y", 0x001AF214, "Float", "Camera", "Camera Y position"));
            memoryValues.Add(new MemoryValue("Camera Z", 0x001AF218, "Float", "Camera", "Camera Z position"));
            memoryValues.Add(new MemoryValue("Camera Rotation", 0x001AF220, "Float", "Camera", "Camera rotation angle"));
            memoryValues.Add(new MemoryValue("Camera Zoom", 0x001AF228, "Float", "Camera", "Camera zoom level"));
            memoryValues.Add(new MemoryValue("Camera State", 0x001AF230, "Int32", "Camera", "Camera state/mode"));

            // Audio Settings
            memoryValues.Add(new MemoryValue("Planet Music ID", 0x001AF240, "Int32", "Audio", "Current music track ID"));
            memoryValues.Add(new MemoryValue("Music Volume", 0x001AF244, "Int32", "Audio", "Music volume level"));
            memoryValues.Add(new MemoryValue("Sound Volume", 0x001AF248, "Int32", "Audio", "Sound effects volume"));
            memoryValues.Add(new MemoryValue("Voice Volume", 0x001AF24C, "Int32", "Audio", "Voice volume level"));
            memoryValues.Add(new MemoryValue("Game Volume", 0x001AF250, "Int32", "Audio", "Master game volume"));

            // Display Settings
            memoryValues.Add(new MemoryValue("Brightness", 0x001AF254, "Int32", "Display", "Screen brightness"));

            // Controller Settings
            memoryValues.Add(new MemoryValue("Vibration", 0x001AF258, "Int32", "Controller", "Vibration enabled"));
            memoryValues.Add(new MemoryValue("Controller Mode", 0x001AF25C, "Int32", "Controller", "Controller configuration"));

            // Menu/UI
            memoryValues.Add(new MemoryValue("Pause Menu ID", 0x001AF260, "Int32", "Menu", "Pause menu state"));
            memoryValues.Add(new MemoryValue("Menu Cursor", 0x001AF264, "Int32", "Menu", "Menu cursor position"));
            memoryValues.Add(new MemoryValue("Menu Selected Item", 0x001AF268, "Int32", "Menu", "Selected menu item"));

            // Save Data
            memoryValues.Add(new MemoryValue("Save Slot", 0x001AF26C, "Int32", "Save Data", "Current save slot"));
            memoryValues.Add(new MemoryValue("Save Planet", 0x001AF270, "Int32", "Save Data", "Saved planet ID"));
            memoryValues.Add(new MemoryValue("Save Time", 0x001AF274, "Int32", "Save Data", "Total playtime"));
            memoryValues.Add(new MemoryValue("Save Bolts", 0x001AF278, "Int32", "Save Data", "Saved bolts amount"));
            memoryValues.Add(new MemoryValue("Save HP", 0x001AF27C, "Int32", "Save Data", "Saved health"));
            memoryValues.Add(new MemoryValue("Save Quick Select", 0x001AF280, "Int32", "Save Data", "Saved quick select"));
            memoryValues.Add(new MemoryValue("Save Weapons", 0x001AF284, "Int32", "Save Data", "Saved weapon data"));
            memoryValues.Add(new MemoryValue("Save Armor", 0x001AF288, "Int32", "Save Data", "Saved armor data"));
            memoryValues.Add(new MemoryValue("Save Progress", 0x001AF28C, "Int32", "Save Data", "Saved progress data"));

            // Vendor/Shop
            memoryValues.Add(new MemoryValue("Megacorp Vendor Price", 0x001A79F0, "Int32", "Vendor", "Item price at vendor"));
            memoryValues.Add(new MemoryValue("Vendor Item ID", 0x001A79EC, "Int32", "Vendor", "Selected vendor item"));
            memoryValues.Add(new MemoryValue("Vendor Purchase Flag", 0x001A79F4, "Int32", "Vendor", "Purchase completion flag"));
            memoryValues.Add(new MemoryValue("Vendor Inventory", 0x001A79E4, "Int32", "Vendor", "Vendor inventory state"));

            // Game Engine
            memoryValues.Add(new MemoryValue("Game Timer", 0x001CA300, "Int32", "Engine", "Game timer counter"));
            memoryValues.Add(new MemoryValue("Frame Counter", 0x001CA2FC, "Int32", "Engine", "Frame count"));
            memoryValues.Add(new MemoryValue("Load Zone Trigger", 0x001AED18, "Int32", "Engine", "Load zone trigger"));
            memoryValues.Add(new MemoryValue("Collision Flag", 0x0018A014, "Int32", "Engine", "Collision detection flag"));
            memoryValues.Add(new MemoryValue("Boss", 0x01B12710, "Int32", "Engine", "Boss entity pointer"));
            memoryValues.Add(new MemoryValue("Enemies in Level", 0x001AED04, "Int32", "Engine", "Active enemy count"));
            memoryValues.Add(new MemoryValue("Wrench Only Flag", 0x001AED00, "Int32", "Engine", "Wrench-only mode flag"));
            memoryValues.Add(new MemoryValue("Frequent Script Flag", 0x001AED10, "Int32", "Engine", "Frequent script execution"));
            memoryValues.Add(new MemoryValue("Airship on Tabora", 0x001395D4, "Int32", "Engine", "Airship state on Tabora"));

            // Cheats & Flags
            memoryValues.Add(new MemoryValue("Invulnerability", 0x0018C320, "Int32", "Cheats", "Invincibility mode"));
            memoryValues.Add(new MemoryValue("Infinite Ammo", 0x0018C328, "Int32", "Cheats", "Unlimited ammo"));
            memoryValues.Add(new MemoryValue("Infinite Bolts", 0x001A79F8, "Int32", "Cheats", "Unlimited currency"));
            memoryValues.Add(new MemoryValue("Infinite Charge Boots", 0x0018C325, "Int8", "Cheats", "Unlimited charge boots"));
            memoryValues.Add(new MemoryValue("Infinite Health", 0x0018C2EC, "Int32", "Cheats", "Unlimited health"));
            memoryValues.Add(new MemoryValue("Movement Lock", 0x00189FD8, "Int32", "Cheats", "Lock player movement"));
            memoryValues.Add(new MemoryValue("Input Lock", 0x001AF33C, "Int32", "Cheats", "Lock controller input"));
            memoryValues.Add(new MemoryValue("AI Freeze", 0x001AF340, "Int32", "Cheats", "Freeze enemy AI"));
            memoryValues.Add(new MemoryValue("Ship Lock", 0x01A6C4C0, "Int32", "Cheats", "Lock ship controls"));
            memoryValues.Add(new MemoryValue("Gadgets Flag", 0x0018C31D, "Int8", "Cheats", "All gadgets unlocked"));
            memoryValues.Add(new MemoryValue("Weapons Flag", 0x0018C31E, "Int8", "Cheats", "All weapons unlocked"));

            // Advanced Pointers
            memoryValues.Add(new MemoryValue("Texture Pointer", 0x001F0000, "Int32", "Advanced", "Texture memory pointer"));
            memoryValues.Add(new MemoryValue("Level Pointer", 0x001CA200, "Int32", "Advanced", "Level data pointer"));
            memoryValues.Add(new MemoryValue("Ratchet Pointer", 0x0018C000, "Int32", "Advanced", "Ratchet entity pointer"));

            return memoryValues;
        }
    }
}
