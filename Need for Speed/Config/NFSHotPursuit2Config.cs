using Common;
using System.Collections.Generic;

namespace Need_for_Speed.Config
{
    public class NFSHotPursuit2Config : IGameMemoryConfig
    {
        public string GameName => "Need for Speed: Hot Pursuit 2 (PS2)";

        public List<MemoryValue> GetMemoryValues()
        {
            var memoryValues = new List<MemoryValue>();

            // Game State & Menu
            memoryValues.Add(new MemoryValue("Primary Menu State", 0x002F0B08, "Int32", "Game State", "Menu state ID (use with demo/replay block)"));
            memoryValues.Add(new MemoryValue("Frontend/In Race Flag", 0x0030C778, "Int8", "Game State", "0x01=Menus, 0x00=In Race"));
            memoryValues.Add(new MemoryValue("Frontend/In Race Flag Alt", 0x01FE5DF8, "Int8", "Game State", "0x00=Menus, 0x01=In Race"));
            memoryValues.Add(new MemoryValue("Pause Flag", 0x00330E90, "Int8", "Game State", "0x00=Not Paused, 0x01=Paused"));
            memoryValues.Add(new MemoryValue("Primary Last Mode State", 0x0030C77C, "Int8", "Game State", "0x02=HP/WR, 0x03=Single, 0x04=Knockout, 0x05=Lap KO, 0x06=Free, 0x07=YTC, 0x08=Champ, 0x09=UR"));
            memoryValues.Add(new MemoryValue("Last Confirmed UR/CH Event", 0x0030C780, "Int8", "Game State", "0x01-0x20 (Event 1-32)"));

            // Player Settings
            memoryValues.Add(new MemoryValue("Last Saved Player Count", 0x002FC058, "Int8", "Settings", "0x01=1P, 0x02=2P"));
            memoryValues.Add(new MemoryValue("Last Saved Race Type", 0x002FC05C, "Int8", "Settings", "0x03=Single, 0x04=Knockout, 0x05=Lap KO, 0x06=Freerun"));
            memoryValues.Add(new MemoryValue("Last Saved Skill Level WR/HP", 0x002FC064, "Int8", "Settings", "0x00=Beginner, 0x01=Advanced, 0x02=Expert"));
            memoryValues.Add(new MemoryValue("Last Saved Skill Level YTC", 0x002FC068, "Int8", "Settings", "0x00=Beginner, 0x01=Advanced, 0x02=Expert"));
            memoryValues.Add(new MemoryValue("Last Saved Units", 0x002FC19D, "Int8", "Settings", "0x00=MPH, 0x01=KM/H"));
            memoryValues.Add(new MemoryValue("Last Saved Rearview Mirror", 0x002FC19C, "Int8", "Settings", "Mirror setting"));
            memoryValues.Add(new MemoryValue("Last Saved Track Map", 0x002FC19E, "Int8", "Settings", "Track map setting"));
            memoryValues.Add(new MemoryValue("Last Saved Leaderboard", 0x002FC1A1, "Int8", "Settings", "Leaderboard setting"));
            memoryValues.Add(new MemoryValue("Last Saved Jump Cams", 0x002FC1A2, "Int8", "Settings", "Jump cameras setting"));
            memoryValues.Add(new MemoryValue("Last Saved Zone Cams", 0x002FC1A3, "Int8", "Settings", "Zone cameras setting"));

            // Audio Settings
            memoryValues.Add(new MemoryValue("Menu Music Volume", 0x002FC0E4, "Float", "Audio", "Menu music volume level"));
            memoryValues.Add(new MemoryValue("Racing Music Volume", 0x002FC0E8, "Float", "Audio", "Racing music volume level"));
            memoryValues.Add(new MemoryValue("Ambient SFX Volume", 0x002FC0EC, "Float", "Audio", "Ambient sound effects volume"));
            memoryValues.Add(new MemoryValue("Tire SFX Volume", 0x002FC0F0, "Float", "Audio", "Tire sound effects volume"));
            memoryValues.Add(new MemoryValue("Engine SFX Volume", 0x002FC0F4, "Float", "Audio", "Engine sound effects volume"));
            memoryValues.Add(new MemoryValue("Menu SFX Volume", 0x002FC0F8, "Float", "Audio", "Menu sound effects volume"));
            memoryValues.Add(new MemoryValue("Speech SFX Volume", 0x002FC0FC, "Float", "Audio", "Speech volume"));
            memoryValues.Add(new MemoryValue("Audio Mode", 0x002FC190, "Int8", "Audio", "Audio mode setting"));
            memoryValues.Add(new MemoryValue("Jukebox Type", 0x002FC192, "Int8", "Audio", "0x00=Rock, 0x01=Techno"));

            // Current Race Info
            memoryValues.Add(new MemoryValue("Current Track ID with Weather", 0x0031A898, "Int8", "Current Race", "Track+weather combo (see notes for full list)"));
            memoryValues.Add(new MemoryValue("Current Track Reverse Flag", 0x0031A8A4, "Int8", "Current Race", "0x00=Normal, 0x01=Reverse"));
            memoryValues.Add(new MemoryValue("Current Total Race Laps", 0x0031A8C4, "Int8", "Current Race", "Total laps in race"));
            memoryValues.Add(new MemoryValue("Current Opponent Count", 0x0031A8CC, "Int8", "Current Race", "Number of opponents"));
            memoryValues.Add(new MemoryValue("Current Race Skill Level", 0x0031AB8C, "Int32", "Current Race", "Skill level for this race"));
            memoryValues.Add(new MemoryValue("Current Race Skill Level Alt", 0x0031AB20, "Int32", "Current Race", "Alt skill level address"));
            memoryValues.Add(new MemoryValue("Player Starting Grid Position", 0x0031ABB4, "Int8", "Current Race", "Starting position on grid"));
            memoryValues.Add(new MemoryValue("Player ID Flag", 0x0031ABB8, "Int8", "Current Race", "0x01=User Controlled, 0x02=AI"));
            memoryValues.Add(new MemoryValue("Jump Cams Active", 0x0031AB8A, "Int8", "Current Race", "Jump cameras enabled"));
            memoryValues.Add(new MemoryValue("Zone Cams Active", 0x0031AB8B, "Int8", "Current Race", "0x00=Off, 0x01=On"));

            // Player Car & Performance
            memoryValues.Add(new MemoryValue("Current Player Car ID", 0x0031ABBC, "Int8", "Player Car", "Car ID (see notes for full list)"));
            memoryValues.Add(new MemoryValue("Last Saved Car Paint Color", 0x0030CE19, "Int8", "Player Car", "Paint color selection"));
            memoryValues.Add(new MemoryValue("Last Saved Car ID Challenge", 0x0030CE14, "Int8", "Player Car", "Car ID for Challenge mode"));
            memoryValues.Add(new MemoryValue("Last Saved Car ID Championship", 0x0030CE3C, "Int8", "Player Car", "Car ID for Championship"));
            memoryValues.Add(new MemoryValue("Last Saved Car ID Ultimate Racer", 0x0030CE44, "Int8", "Player Car", "Car ID for Ultimate Racer"));
            memoryValues.Add(new MemoryValue("Last Race Finish Place", 0x0031B750, "Int32", "Player Car", "Finishing position (1=first)"));
            memoryValues.Add(new MemoryValue("Last Race Completion Time", 0x0031B754, "Int32", "Player Car", "Completion time"));
            memoryValues.Add(new MemoryValue("Current Strikes", 0x008E9D20, "Int32", "Player Car", "Busted strikes"));

            // NFS Points & Progression
            memoryValues.Add(new MemoryValue("NFS Points", 0x002FC400, "Int32", "Progression", "Total NFS points"));
            memoryValues.Add(new MemoryValue("NFS Points Alt", 0x0030CE54, "Int32", "Progression", "Alt NFS points address"));
            memoryValues.Add(new MemoryValue("UR/CH Event Info Screen", 0x002FC1C0, "Int8", "Progression", "0x00=Not Viewing, 0x02=Viewing"));
            memoryValues.Add(new MemoryValue("Last Selected Track", 0x002FC1A4, "Int32", "Progression", "Last hovered track"));
            memoryValues.Add(new MemoryValue("Last Selected Weather", 0x002FC1B0, "Int32", "Progression", "0=Sunny, 1=Overcast, 2=Sunset, 4=Dawn"));
            memoryValues.Add(new MemoryValue("Last Selected UR Event", 0x002FC1B8, "Int32", "Progression", "Ultimate Racer event number"));
            memoryValues.Add(new MemoryValue("Last Selected CH Event", 0x002FC1BC, "Int32", "Progression", "Championship event number"));
            memoryValues.Add(new MemoryValue("Last Saved Total Laps Challenge", 0x002FC1A8, "Int8", "Progression", "Total laps for challenge mode"));

            // Car Unlocks (Sample - there are 50+ unlock flags)
            memoryValues.Add(new MemoryValue("HSV GTS NFS Unlock", 0x0030C708, "Int8", "Unlocks", "HSV GTS NFS unlock flag"));
            memoryValues.Add(new MemoryValue("Mercedes CLK GTR Unlock", 0x0030C70C, "Int8", "Unlocks", "CLK GTR unlock flag"));
            memoryValues.Add(new MemoryValue("BMW M5 PD Unlock", 0x0030C710, "Int8", "Unlocks", "BMW M5 cop unlock flag"));
            memoryValues.Add(new MemoryValue("Mercedes CL55 AMG NFS Unlock", 0x0030C714, "Int8", "Unlocks", "CL55 AMG unlock flag"));
            memoryValues.Add(new MemoryValue("Ferrari F50 NFS Unlock", 0x0030C720, "Int8", "Unlocks", "Ferrari F50 unlock flag"));
            memoryValues.Add(new MemoryValue("Lamborghini Murciélago PD Unlock", 0x0030C724, "Int8", "Unlocks", "Lambo cop unlock flag"));
            memoryValues.Add(new MemoryValue("McLaren F1 NFS Unlock", 0x0030C76C, "Int8", "Unlocks", "McLaren F1 unlock flag"));
            memoryValues.Add(new MemoryValue("McLaren F1 LM NFS Unlock", 0x0030C774, "Int8", "Unlocks", "McLaren F1 LM unlock flag"));

            // Best Lap Times (Sample - there are 200+ lap time addresses)
            memoryValues.Add(new MemoryValue("Coastal Parklands Class A Best Lap", 0x0030A808, "Int32", "Best Laps", "CP Class A best lap time"));
            memoryValues.Add(new MemoryValue("National Forest Class A Best Lap", 0x0030A998, "Int32", "Best Laps", "NF Class A best lap time"));
            memoryValues.Add(new MemoryValue("Desert Heat Class A Best Lap", 0x0030ACB8, "Int32", "Best Laps", "DH Class A best lap time"));
            memoryValues.Add(new MemoryValue("Ancient Ruins Class A Best Lap", 0x0030B168, "Int32", "Best Laps", "AR Class A best lap time"));
            memoryValues.Add(new MemoryValue("Calypso Coast Class A Best Lap", 0x0030B2F8, "Int32", "Best Laps", "CC Class A best lap time"));
            memoryValues.Add(new MemoryValue("Fall Winds Class A Best Lap", 0x0030B618, "Int32", "Best Laps", "FW Class A best lap time"));
            memoryValues.Add(new MemoryValue("Alpine Trail Class A Best Lap", 0x0030B7A8, "Int32", "Best Laps", "AT Class A best lap time"));
            memoryValues.Add(new MemoryValue("Island Outskirts Class A Best Lap", 0x0030BAC8, "Int32", "Best Laps", "IO Class A best lap time"));

            // Best Total Times (Sample - there are 400+ total time addresses)
            memoryValues.Add(new MemoryValue("Coastal Parklands Class A 2 Laps", 0x002FC730, "Int32", "Best Times", "CP Class A 2-lap total"));
            memoryValues.Add(new MemoryValue("Coastal Parklands Class A 4 Laps", 0x002FC780, "Int32", "Best Times", "CP Class A 4-lap total"));
            memoryValues.Add(new MemoryValue("Coastal Parklands Class A 8 Laps", 0x002FC820, "Int32", "Best Times", "CP Class A 8-lap total"));
            memoryValues.Add(new MemoryValue("National Forest Class A 2 Laps", 0x002FD540, "Int32", "Best Times", "NF Class A 2-lap total"));
            memoryValues.Add(new MemoryValue("Desert Heat Class A 2 Laps", 0x002FF160, "Int32", "Best Times", "DH Class A 2-lap total"));

            // Ultimate Racer Events (Sample - 32 events total)
            memoryValues.Add(new MemoryValue("Ultimate Racer Event 1 Time", 0x002FC2D8, "Int32", "Ultimate Racer", "UR Event 1 time (÷40 for 0.01 sec)"));
            memoryValues.Add(new MemoryValue("Ultimate Racer Event 2 Time", 0x002FC2DC, "Int32", "Ultimate Racer", "UR Event 2 time"));
            memoryValues.Add(new MemoryValue("Ultimate Racer Event 3 Time", 0x002FC2E0, "Int32", "Ultimate Racer", "UR Event 3 time"));
            memoryValues.Add(new MemoryValue("Ultimate Racer Event 7 Race", 0x002FC394, "Int8", "Ultimate Racer", "0=Incomplete, 1=First, 2=Second, etc."));
            memoryValues.Add(new MemoryValue("Ultimate Racer Event 32", 0x002FC39E, "Int8", "Ultimate Racer", "Event 32 completion (0x01=First)"));

            // Championship Events (Sample - 32 events total)
            memoryValues.Add(new MemoryValue("Championship Event 1", 0x002FC2B8, "Int8", "Championship", "0x01=1st place"));
            memoryValues.Add(new MemoryValue("Championship Event 2 Time", 0x002FC1D8, "Int32", "Championship", "Event 2 time"));
            memoryValues.Add(new MemoryValue("Championship Event 5 Knockout", 0x002FC1DC, "Int32", "Championship", "Event 5 knockout result"));
            memoryValues.Add(new MemoryValue("Championship Event 11 Time", 0x002FC220, "Int32", "Championship", "Time under 3:10.00 to pass"));
            memoryValues.Add(new MemoryValue("Championship Event 32", 0x002FC2C6, "Int8", "Championship", "Event 32 (0x01=1st)"));

            // Cheat Flags (Sample - there are 50+ cheat flags)
            memoryValues.Add(new MemoryValue("Motion Blur Cheat", 0x0031D858, "Int8", "Cheats", "Motion blur effect"));
            memoryValues.Add(new MemoryValue("Black and White Cheat", 0x0031D890, "Int8", "Cheats", "B&W mode"));
            memoryValues.Add(new MemoryValue("Foggy Weather Cheat", 0x0031D8C8, "Int8", "Cheats", "Foggy weather"));
            memoryValues.Add(new MemoryValue("R/C Cars Cheat", 0x0031D900, "Int8", "Cheats", "RC car mode"));
            memoryValues.Add(new MemoryValue("Video Mode Cheat", 0x0031D938, "Int8", "Cheats", "Video mode with scan lines"));
            memoryValues.Add(new MemoryValue("Chrome Paint Cheat", 0x0031DA18, "Int8", "Cheats", "Chrome paint unlock"));
            memoryValues.Add(new MemoryValue("McLaren F1 Cheat", 0x0031DA50, "Int8", "Cheats", "McLaren F1 unlock cheat"));
            memoryValues.Add(new MemoryValue("Ferrari F50 Cheat", 0x0031DC48, "Int8", "Cheats", "Ferrari F50 unlock cheat"));

            // Track Unlocks (Sample - there are 20+ track unlock flags)
            memoryValues.Add(new MemoryValue("Coastal Parklands II Unlock", 0x0031E460, "Int8", "Track Unlocks", "CP II unlock flag"));
            memoryValues.Add(new MemoryValue("National Forest Unlock", 0x0031E498, "Int8", "Track Unlocks", "NF unlock flag"));
            memoryValues.Add(new MemoryValue("Desert Heat II Unlock", 0x0031E540, "Int8", "Track Unlocks", "DH II unlock flag"));
            memoryValues.Add(new MemoryValue("Ancient Ruins II Unlock", 0x0031E658, "Int8", "Track Unlocks", "AR II unlock flag"));
            memoryValues.Add(new MemoryValue("Alpine Trail Unlock", 0x0031E770, "Int8", "Track Unlocks", "AT unlock flag"));
            memoryValues.Add(new MemoryValue("Tropical Circuit Unlock", 0x0031E8F8, "Int8", "Track Unlocks", "TC unlock flag"));

            // Pointers (Base addresses for advanced use)
            memoryValues.Add(new MemoryValue("Driven Distance Pointer", 0x002C84BC, "Int32", "Pointers", "Pointer (+0x3a8) to driven distance"));
            memoryValues.Add(new MemoryValue("Player Car Info Pointer", 0x002C966C, "Int32", "Pointers", "Pointer (+0x78) to camera info"));
            memoryValues.Add(new MemoryValue("Car Nebula Menu Pointer", 0x002F96E0, "Int32", "Pointers", "Pointer to car selection menu"));
            memoryValues.Add(new MemoryValue("Misc Car Data Pointer", 0x002F96EC, "Int32", "Pointers", "Pointer (+0x220=Gear, +0x228=Turbo)"));
            memoryValues.Add(new MemoryValue("Race Progress Info Pointer", 0x003301F0, "Int32", "Pointers", "Pointer to race progress data (lap, pos, time, etc.)"));
            memoryValues.Add(new MemoryValue("Car RPM Pointer", 0x0032FFCC, "Int32", "Pointers", "Pointer (+0x3c) to car RPM"));
            memoryValues.Add(new MemoryValue("In Race Options Pointer", 0x00330728, "Int32", "Pointers", "Pointer to in-race options & stats"));
            memoryValues.Add(new MemoryValue("Audio Menu Pointer", 0x003316F8, "Int32", "Pointers", "Pointer to audio menu data"));
            memoryValues.Add(new MemoryValue("HP/YTC Stats Pointer", 0x00331BEC, "Int32", "Pointers", "Pointer to Hot Pursuit/YTC stats"));

            // Debug Menu Flags
            memoryValues.Add(new MemoryValue("DEBUG - ENV Mapping", 0x003306A0, "Int8", "Debug", "Environment mapping debug flag"));
            memoryValues.Add(new MemoryValue("DEBUG - Car Collision", 0x003306A4, "Int8", "Debug", "Car to car collision debug flag"));
            memoryValues.Add(new MemoryValue("DEBUG - Show Info", 0x00330814, "Int8", "Debug", "Show debug info flag"));
            memoryValues.Add(new MemoryValue("DEBUG - Super Easy AI", 0x00330A58, "Int8", "Debug", "0x00=Off, 0x01=On"));

            return memoryValues;
        }
    }
}
