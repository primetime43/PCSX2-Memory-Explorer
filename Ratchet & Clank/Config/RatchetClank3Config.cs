using Common;
using System.Collections.Generic;

namespace Ratchet___Clank.Config
{
    public class RatchetClank3Config : IGameMemoryConfig
    {
        public string GameName => "Ratchet & Clank 3: Up Your Arsenal (NTSC)";

        public List<MemoryValue> GetMemoryValues()
        {
            var memoryValues = new List<MemoryValue>();

            // Player Position & Movement
            memoryValues.Add(new MemoryValue("X Axis Position", 0x001A4C60, "Float", "Player Position", "X position of Ratchet"));
            memoryValues.Add(new MemoryValue("Y Axis Position", 0x001A4C64, "Float", "Player Position", "Y position of Ratchet"));
            memoryValues.Add(new MemoryValue("Z Axis Position", 0x001A4C68, "Float", "Player Position", "Z position of Ratchet"));
            memoryValues.Add(new MemoryValue("Player Rotation", 0x001A4C6C, "Float", "Player Position", "Ratchet's rotation angle"));
            memoryValues.Add(new MemoryValue("Player Speed X", 0x001A4C78, "Float", "Player Position", "Movement speed X axis"));
            memoryValues.Add(new MemoryValue("Player Speed Y", 0x001A4C7C, "Float", "Player Position", "Movement speed Y axis"));
            memoryValues.Add(new MemoryValue("Player Speed Z", 0x001A4C80, "Float", "Player Position", "Movement speed Z axis"));
            memoryValues.Add(new MemoryValue("Neutral Speed", 0x001A4D94, "Float", "Player Position", "Base movement speed"));

            // Player Stats
            memoryValues.Add(new MemoryValue("Ratchet HP", 0x001A7430, "Int32", "Player Stats", "Current health points"));
            memoryValues.Add(new MemoryValue("Ratchet Max HP", 0x001A7432, "Int16", "Player Stats", "Maximum health capacity"));
            memoryValues.Add(new MemoryValue("HP Experience", 0x00142694, "Int32", "Player Stats", "Health experience points"));
            memoryValues.Add(new MemoryValue("Armor Equipped", 0x001A7424, "Int32", "Player Stats", "Equipped armor ID"));
            memoryValues.Add(new MemoryValue("Armor Value", 0x001A7428, "Int32", "Player Stats", "Armor protection value"));

            // Currency
            memoryValues.Add(new MemoryValue("Bolts", 0x00142660, "Int32", "Currency", "Currency amount"));
            memoryValues.Add(new MemoryValue("Arena Points", 0x001A7408, "Int32", "Currency", "Arena challenge points"));

            // Weapons
            memoryValues.Add(new MemoryValue("Weapon Selected", 0x001A4D84, "Int32", "Weapons", "Currently equipped weapon ID"));
            memoryValues.Add(new MemoryValue("Weapon Ammo", 0x001A4D88, "Int32", "Weapons", "Current weapon ammo count"));
            memoryValues.Add(new MemoryValue("Weapon Level", 0x001A4D8C, "Int32", "Weapons", "Weapon upgrade level"));
            memoryValues.Add(new MemoryValue("Weapon XP", 0x001A4D90, "Int32", "Weapons", "Weapon experience points"));
            memoryValues.Add(new MemoryValue("Wrench Only Mode", 0x001A7420, "Int32", "Weapons", "Wrench-only mode flag"));
            memoryValues.Add(new MemoryValue("Wrench Swing", 0x001A4DD8, "Int32", "Weapons", "Wrench attack state"));

            // Gadgets & Items
            memoryValues.Add(new MemoryValue("Gravity Boots", 0x001A742C, "Int8", "Gadgets", "Gravity boots equipped"));
            memoryValues.Add(new MemoryValue("Charge Boots", 0x001A7434, "Int8", "Gadgets", "Charge boots equipped"));
            memoryValues.Add(new MemoryValue("Map-O-Matic", 0x001A7435, "Int8", "Gadgets", "Map-o-matic equipped"));
            memoryValues.Add(new MemoryValue("Hacker", 0x001A7436, "Int8", "Gadgets", "Hacker equipped"));
            memoryValues.Add(new MemoryValue("Dynocannon", 0x001A7437, "Int8", "Gadgets", "Dynocannon equipped"));
            memoryValues.Add(new MemoryValue("Strafe Mode", 0x001A4DE0, "Int32", "Gadgets", "Strafe mode enabled"));
            memoryValues.Add(new MemoryValue("Ghost Ratchet", 0x001A4DD0, "Int32", "Gadgets", "Ghost mode value"));

            // Qwark
            memoryValues.Add(new MemoryValue("HP Qwark", 0x001A7434, "Int32", "Qwark", "Qwark health points"));
            memoryValues.Add(new MemoryValue("Qwark Weapon Ammo", 0x001A66E8, "Int32", "Qwark", "Qwark's weapon ammo"));
            memoryValues.Add(new MemoryValue("Timer Qwark", 0x001426D0, "Int32", "Qwark", "Qwark timer"));
            memoryValues.Add(new MemoryValue("Token Qwark 1", 0x01651EF4, "Int32", "Qwark Tokens", "Qwark token #1"));
            memoryValues.Add(new MemoryValue("Token Qwark 2", 0x0175F134, "Int32", "Qwark Tokens", "Qwark token #2"));
            memoryValues.Add(new MemoryValue("Token Qwark 3", 0x01538454, "Int32", "Qwark Tokens", "Qwark token #3"));
            memoryValues.Add(new MemoryValue("Token Qwark 4", 0x017C9784, "Int32", "Qwark Tokens", "Qwark token #4"));
            memoryValues.Add(new MemoryValue("Token Qwark 5", 0x015AEF44, "Int32", "Qwark Tokens", "Qwark token #5"));
            memoryValues.Add(new MemoryValue("Token Qwark 6", 0x0172C9F4, "Int32", "Qwark Tokens", "Qwark token #6"));
            memoryValues.Add(new MemoryValue("Token Qwark 1 Special Edition", 0x01767444, "Int32", "Qwark Tokens", "Qwark token #1 (special edition)"));

            // Game Progress
            memoryValues.Add(new MemoryValue("Challenge Mode Number", 0x00142692, "Int16", "Game Progress", "Challenge mode playthrough count"));
            memoryValues.Add(new MemoryValue("NG+ Flag", 0x00142698, "Int32", "Game Progress", "New Game Plus flag"));
            memoryValues.Add(new MemoryValue("Difficulty", 0x0014269C, "Int32", "Game Progress", "Game difficulty level"));
            memoryValues.Add(new MemoryValue("Planet ID", 0x001A4C08, "Int32", "Game Progress", "Current planet ID"));
            memoryValues.Add(new MemoryValue("Checkpoint ID", 0x001A4C0C, "Int32", "Game Progress", "Current checkpoint"));
            memoryValues.Add(new MemoryValue("Mission ID", 0x001A7418, "Int32", "Game Progress", "Current mission ID"));
            memoryValues.Add(new MemoryValue("Cutscene ID", 0x001A4C10, "Int32", "Game Progress", "Current cutscene ID"));
            memoryValues.Add(new MemoryValue("Skill Points", 0x001A7400, "Int32", "Game Progress", "Total skill points"));
            memoryValues.Add(new MemoryValue("Skill Point Flags", 0x001A7410, "Int32", "Game Progress", "Unlocked skill points"));
            memoryValues.Add(new MemoryValue("Planet Completion Flags", 0x001A7448, "Int32", "Game Progress", "Planet completion status"));
            memoryValues.Add(new MemoryValue("Are Tyranoids Robots?", 0x0014275C, "Int32", "Game Progress", "Tyranoid classification flag"));

            // Arena
            memoryValues.Add(new MemoryValue("Arena Challenge ID", 0x001A7404, "Int32", "Arena", "Current challenge ID"));
            memoryValues.Add(new MemoryValue("Arena Reward", 0x001A740C, "Int32", "Arena", "Arena reward amount"));

            // Vid Comics
            memoryValues.Add(new MemoryValue("Vid Comic ID", 0x001426A0, "Int32", "Vid Comics", "Current vid comic ID"));
            memoryValues.Add(new MemoryValue("Vid Comic Health", 0x001D44C0, "Int32", "Vid Comics", "Vid comic health"));
            memoryValues.Add(new MemoryValue("Vid Comic Ammo", 0x001D44C8, "Int32", "Vid Comics", "Vid comic ammo"));
            memoryValues.Add(new MemoryValue("Vid Comic Bolts", 0x001D44D0, "Int32", "Vid Comics", "Vid comic bolts"));
            memoryValues.Add(new MemoryValue("Vid Comic Room", 0x001D44D8, "Int32", "Vid Comics", "Vid comic room number"));

            // Hoverbike
            memoryValues.Add(new MemoryValue("Hoverbike Speed", 0x001A5020, "Float", "Hoverbike", "Hoverbike speed"));
            memoryValues.Add(new MemoryValue("Hoverbike Boost", 0x001A5024, "Float", "Hoverbike", "Hoverbike boost energy"));
            memoryValues.Add(new MemoryValue("Hoverbike Timer", 0x001A501C, "Int32", "Hoverbike", "Hoverbike race timer"));

            // Hoverboard
            memoryValues.Add(new MemoryValue("Hoverboard Speed", 0x001A5090, "Float", "Hoverboard", "Hoverboard speed"));
            memoryValues.Add(new MemoryValue("Hoverboard Timer", 0x001A5094, "Int32", "Hoverboard", "Hoverboard race timer"));

            // Vehicles
            memoryValues.Add(new MemoryValue("Vehicle HP", 0x001D1400, "Int32", "Vehicles", "Vehicle health points"));
            memoryValues.Add(new MemoryValue("Vehicle Boost", 0x001D1404, "Float", "Vehicles", "Vehicle boost energy"));
            memoryValues.Add(new MemoryValue("Vehicle Position X", 0x001D1440, "Float", "Vehicles", "Vehicle X position"));
            memoryValues.Add(new MemoryValue("Vehicle Position Y", 0x001D1444, "Float", "Vehicles", "Vehicle Y position"));
            memoryValues.Add(new MemoryValue("Vehicle Position Z", 0x001D1448, "Float", "Vehicles", "Vehicle Z position"));
            memoryValues.Add(new MemoryValue("Airship Skin", 0x001D54D2, "Int16", "Vehicles", "Airship visual skin ID"));

            // Space Ship
            memoryValues.Add(new MemoryValue("Ship HP", 0x001D1400, "Int32", "Space Ship", "Ship health points"));
            memoryValues.Add(new MemoryValue("Ship Boost", 0x001D1404, "Float", "Space Ship", "Ship boost energy"));
            memoryValues.Add(new MemoryValue("Ship Missiles", 0x001D1414, "Int32", "Space Ship", "Ship missile count"));
            memoryValues.Add(new MemoryValue("Ship Speed", 0x001D1410, "Float", "Space Ship", "Ship current speed"));
            memoryValues.Add(new MemoryValue("Ship Position X", 0x001D1440, "Float", "Space Ship", "Ship X coordinate"));
            memoryValues.Add(new MemoryValue("Ship Position Y", 0x001D1444, "Float", "Space Ship", "Ship Y coordinate"));
            memoryValues.Add(new MemoryValue("Ship Position Z", 0x001D1448, "Float", "Space Ship", "Ship Z coordinate"));
            memoryValues.Add(new MemoryValue("Ship Pitch", 0x001D1450, "Float", "Space Ship", "Ship pitch rotation"));
            memoryValues.Add(new MemoryValue("Ship Yaw", 0x001D1454, "Float", "Space Ship", "Ship yaw rotation"));
            memoryValues.Add(new MemoryValue("Ship Roll", 0x001D1458, "Float", "Space Ship", "Ship roll rotation"));

            // Camera
            memoryValues.Add(new MemoryValue("Camera X", 0x001A4E10, "Float", "Camera", "Camera X position"));
            memoryValues.Add(new MemoryValue("Camera Y", 0x001A4E14, "Float", "Camera", "Camera Y position"));
            memoryValues.Add(new MemoryValue("Camera Z", 0x001A4E18, "Float", "Camera", "Camera Z position"));
            memoryValues.Add(new MemoryValue("Camera Rotation", 0x001A4E20, "Float", "Camera", "Camera rotation angle"));
            memoryValues.Add(new MemoryValue("Camera Zoom", 0x001A4E24, "Float", "Camera", "Camera zoom level"));
            memoryValues.Add(new MemoryValue("Camera Mode", 0x001A4E28, "Int32", "Camera", "Camera state/mode"));

            // Menu/UI
            memoryValues.Add(new MemoryValue("HUD State", 0x001A4E2C, "Int32", "Menu", "HUD display state"));
            memoryValues.Add(new MemoryValue("Menu Cursor", 0x001A4E38, "Int32", "Menu", "Menu cursor position"));
            memoryValues.Add(new MemoryValue("Menu State", 0x001A4E34, "Int32", "Menu", "Menu state"));
            memoryValues.Add(new MemoryValue("Pause ID", 0x001A4E30, "Int32", "Menu", "Pause menu ID"));

            // Audio Settings
            memoryValues.Add(new MemoryValue("Audio Volume", 0x001A4EA0, "Int32", "Audio", "Master audio volume"));
            memoryValues.Add(new MemoryValue("Music Volume", 0x001A4EA4, "Int32", "Audio", "Music volume level"));
            memoryValues.Add(new MemoryValue("SFX Volume", 0x001A4EA8, "Int32", "Audio", "Sound effects volume"));
            memoryValues.Add(new MemoryValue("Voice Volume", 0x001A4EAC, "Int32", "Audio", "Voice volume level"));

            // Display Settings
            memoryValues.Add(new MemoryValue("Brightness", 0x001A4EB0, "Int32", "Display", "Screen brightness"));

            // Controller Settings
            memoryValues.Add(new MemoryValue("Vibration", 0x001A4EB4, "Int32", "Controller", "Vibration enabled"));
            memoryValues.Add(new MemoryValue("Controller Mode", 0x001A4EB8, "Int32", "Controller", "Controller configuration"));

            // Vendor/Shop
            memoryValues.Add(new MemoryValue("Vendor Item ID", 0x001A4F10, "Int32", "Vendor", "Selected vendor item"));
            memoryValues.Add(new MemoryValue("Vendor Price", 0x001A4F14, "Int32", "Vendor", "Item price at vendor"));
            memoryValues.Add(new MemoryValue("Vendor Inventory", 0x001A4F18, "Int32", "Vendor", "Vendor inventory state"));
            memoryValues.Add(new MemoryValue("Vendor Confirm Flag", 0x001A4F1C, "Int32", "Vendor", "Purchase confirmation flag"));

            // Game Engine
            memoryValues.Add(new MemoryValue("Frame Counter", 0x001A3BF0, "Int32", "Engine", "Frame count"));
            memoryValues.Add(new MemoryValue("Global Timer", 0x001A3BF8, "Int32", "Engine", "Global timer counter"));
            memoryValues.Add(new MemoryValue("Enemy Count", 0x001ACF10, "Int32", "Engine", "Active enemy count"));
            memoryValues.Add(new MemoryValue("Enemy HP", 0x00200000, "Int32", "Engine", "Enemy health pointer"));
            memoryValues.Add(new MemoryValue("Load Zone Trigger", 0x001ACF18, "Int32", "Engine", "Load zone trigger"));
            memoryValues.Add(new MemoryValue("Collision Flag", 0x001A4C9C, "Int32", "Engine", "Collision detection flag"));
            memoryValues.Add(new MemoryValue("Script Flag", 0x001ACF14, "Int32", "Engine", "Script execution flag"));

            // Cheats & Flags
            memoryValues.Add(new MemoryValue("Infinite Ammo Flag", 0x001A7438, "Int32", "Cheats", "Unlimited ammo"));
            memoryValues.Add(new MemoryValue("Infinite Health Flag", 0x001A4C94, "Int32", "Cheats", "Unlimited health"));
            memoryValues.Add(new MemoryValue("Infinite Bolts", 0x00142660, "Int32", "Cheats", "Unlimited currency"));
            memoryValues.Add(new MemoryValue("Invincibility", 0x001A4C92, "Int32", "Cheats", "Invincibility mode"));
            memoryValues.Add(new MemoryValue("Movement Lock", 0x001A4DF0, "Int32", "Cheats", "Lock player movement"));
            memoryValues.Add(new MemoryValue("Input Lock", 0x001A4F00, "Int32", "Cheats", "Lock controller input"));
            memoryValues.Add(new MemoryValue("AI Freeze", 0x001A4DF4, "Int32", "Cheats", "Freeze enemy AI"));
            memoryValues.Add(new MemoryValue("Gadget Flags", 0x001A743C, "Int32", "Cheats", "All gadgets unlocked"));
            memoryValues.Add(new MemoryValue("Weapon Flags", 0x001A7440, "Int32", "Cheats", "All weapons unlocked"));

            // Advanced Pointers
            memoryValues.Add(new MemoryValue("Ratchet Model Pointer", 0x001A4C00, "Int32", "Advanced", "Ratchet model pointer"));
            memoryValues.Add(new MemoryValue("Ratchet Pointer", 0x001A4C00, "Int32", "Advanced", "Ratchet entity pointer"));
            memoryValues.Add(new MemoryValue("Level Pointer", 0x001A3C00, "Int32", "Advanced", "Level data pointer"));
            memoryValues.Add(new MemoryValue("Texture Pointer", 0x001F0000, "Int32", "Advanced", "Texture memory pointer"));

            return memoryValues;
        }
    }
}
