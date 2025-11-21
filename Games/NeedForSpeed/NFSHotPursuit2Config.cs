using Common;
using System.Collections.Generic;

namespace Games.NeedForSpeed
{
    public class NFSHotPursuit2Config : IGameMemoryConfig
    {
        public string GameName => "Need for Speed: Hot Pursuit 2 (PS2)";

        public List<MemoryValue> GetMemoryValues()
        {
            var memoryValues = new List<MemoryValue>();

            // Version & Boot Info
            memoryValues.Add(new MemoryValue("Serial ASCII", 0x000155D2, "Int32", "Boot", "Version identifier",
@"NTSC Greatest Hits = US_203.6
PAL = ES_507.3
PAL Greatest Hits = ES_507.3
Kor = PM_675.2
Asia = PM_651.8"));
            memoryValues.Add(new MemoryValue("MAIN.ELF Lookup", 0x002AB040, "Int32", "Boot", "0x4E49414D = MAIN.ELF loaded"));

            // Primary Menu State
            memoryValues.Add(new MemoryValue("Primary Menu State", 0x002F0B08, "Int32", "Game State", "Menu state ID",
@"Both 0x002F0B08 & 0x002F0B10 MUST be 0x00 when making in-race achievements to block Demo/Replay mode!

0x01A8AF1C = Intro FMVs/Press Start
0x01A9DE30 = Bootup MC Check
0x01BC86B4 = Loading
0x01A6AF34 = Main Menu
0x01A6C0EC = Hot Pursuit
0x01A9F2D4 = Ultimate Racer
0x01A6E2E8 = You're the Cop
0x01A6D2C4 = World Racing
0x01A9F2D4 = Championship
0x01A82738 = Challenge
0x01A83C18 = Setup
0x01A8BC10 = Options
0x01A9259C = Audio
0x01A9B230 = Jukebox
0x01A98A50 = Controller
0x01A85AF8 = Controller Config
0x01A8F03C = Display
0x01A9AB54 = Calibrate Display Offset
0x01A9DE68 = Save/Load
0x01A9D3EC = MC Access
0x01A8D3F8 = Player Options
0x01A94CE0 = Player Names
0x01A6F5A8 = 1P Car Nebula
0x01A74534 = 2P Car Nebula
0x01A7F40C = Track Nebula
0x01A89254 = Credits Selection
0x01AA189C = Demo Mode
0x01AA1EDC = Replay Mode
0x01AB156C = In Race MC Access"));
            memoryValues.Add(new MemoryValue("Frontend/In Race Flag", 0x0030C778, "Int8", "Game State", "0x01=Menus, 0x00=In Race",
@"Can get stuck at 0x00 while in menus if demo mode is triggered."));
            memoryValues.Add(new MemoryValue("Frontend/In Race Flag Alt", 0x01FE5DF8, "Int8", "Game State", "0x00=Menus, 0x01=In Race"));
            memoryValues.Add(new MemoryValue("Pause Flag", 0x00330E90, "Int8", "Game State", "0x00=Not Paused, 0x01=Paused"));
            memoryValues.Add(new MemoryValue("Primary Last Mode State", 0x0030C77C, "Int8", "Game State", "Last game mode",
@"0x02 = HP/WR Quick Race
0x03 = Single Race
0x04 = Knockout
0x05 = Lap Knockout
0x06 = Free Run
0x07 = YTC (You're the Cop)
0x08 = Championship
0x09 = Ultimate Racer"));
            memoryValues.Add(new MemoryValue("Last Confirmed UR/CH Event", 0x0030C780, "Int8", "Game State", "0x01-0x20 (Event 1-32)"));
            memoryValues.Add(new MemoryValue("Time", 0x00330C78, "Int32", "Game State", "Freezing drastically affects gameplay!"));
            memoryValues.Add(new MemoryValue("Frames Elapsed", 0x00330C80, "Int32", "Game State", "Don't use for timing - starts during cutscene"));

            // Player Settings - Race Type
            memoryValues.Add(new MemoryValue("Last Saved Player Count", 0x002FC058, "Int8", "Settings", "0x01=1P, 0x02=2P"));
            memoryValues.Add(new MemoryValue("Last Saved Race Type", 0x002FC05C, "Int8", "Settings", "0x03=Single, 0x04=Knockout, 0x05=Lap KO, 0x06=Freerun"));
            memoryValues.Add(new MemoryValue("Last Saved Skill Level WR/HP", 0x002FC064, "Int8", "Settings", "0x00=Beginner, 0x01=Advanced, 0x02=Expert"));
            memoryValues.Add(new MemoryValue("Last Saved Skill Level YTC", 0x002FC068, "Int8", "Settings", "0x00=Beginner, 0x01=Advanced, 0x02=Expert"));

            // Single Race Settings
            memoryValues.Add(new MemoryValue("Last Saved Opponent Count WR", 0x002FC074, "Int8", "Settings WR", "0x01=One, 0x02=Full Grid"));
            memoryValues.Add(new MemoryValue("Last Saved Opponent Count HP", 0x002FC078, "Int8", "Settings HP", "0x01=One, 0x02=Full Grid"));
            memoryValues.Add(new MemoryValue("Last Saved Opponent Type", 0x002FC07C, "Int8", "Settings", "0x00=Random, 0x01=Same"));
            memoryValues.Add(new MemoryValue("Last Saved Catch-up WR/HP", 0x002FC080, "Int8", "Settings", "0x00=Off, 0x01=On"));
            memoryValues.Add(new MemoryValue("Last Saved Traffic WR", 0x002FC084, "Int8", "Settings WR", "0x00=Min, 0x01=Mod, 0x02=Max, 0x03=Off"));
            memoryValues.Add(new MemoryValue("Last Saved Traffic HP", 0x002FC088, "Int8", "Settings HP", "0x00=Min, 0x01=Mod, 0x02=Max, 0x03=Off"));
            memoryValues.Add(new MemoryValue("Last Saved Damage WR/HP", 0x002FC08C, "Int8", "Settings", "0x00=Off, 0x01=On"));

            // YTC Settings
            memoryValues.Add(new MemoryValue("Last Saved Catch-up YTC", 0x002FC098, "Int8", "Settings YTC", "0x00=Off, 0x01=On"));
            memoryValues.Add(new MemoryValue("Last Saved Traffic YTC", 0x002FC09C, "Int8", "Settings YTC", "0x00=Min, 0x01=Mod, 0x02=Max, 0x03=Off"));
            memoryValues.Add(new MemoryValue("Last Saved Damage YTC", 0x002FC0A0, "Int8", "Settings YTC", "0x00=Off, 0x01=On"));

            // Free Run Settings
            memoryValues.Add(new MemoryValue("Last Saved Traffic Free Run WR", 0x002FC0A4, "Int8", "Settings Free Run", "0x00=Min, 0x01=Mod, 0x02=Max, 0x03=Off"));
            memoryValues.Add(new MemoryValue("Last Saved Traffic Free Run HP", 0x002FC0A8, "Int8", "Settings Free Run", "0x00=Min, 0x01=Mod, 0x02=Max, 0x03=Off"));
            memoryValues.Add(new MemoryValue("Last Saved Damage Free Run", 0x002FC0AC, "Int8", "Settings Free Run", "0x00=Off, 0x01=On"));

            // Knockout Settings
            memoryValues.Add(new MemoryValue("Last Saved Opponent Count Knockout WR", 0x002FC0B0, "Int8", "Settings Knockout", "0x03-0x07 (3-7/Full Grid)"));
            memoryValues.Add(new MemoryValue("Last Saved Opponent Type Knockout WR", 0x002FC0B4, "Int8", "Settings Knockout", "0x00=Random, 0x01=Same"));
            memoryValues.Add(new MemoryValue("Last Saved Catch-up Knockout WR", 0x002FC0B8, "Int8", "Settings Knockout", "0x00=Off, 0x01=On"));
            memoryValues.Add(new MemoryValue("Last Saved Traffic Knockout WR", 0x002FC0BC, "Int8", "Settings Knockout", "0x00=Min, 0x01=Mod, 0x02=Max, 0x03=Off"));
            memoryValues.Add(new MemoryValue("Last Saved Traffic Knockout HP", 0x002FC0C0, "Int8", "Settings Knockout", "0x00=Min, 0x01=Mod, 0x02=Max, 0x03=Off"));
            memoryValues.Add(new MemoryValue("Last Saved Tracks Knockout", 0x002FC0C4, "Int8", "Settings Knockout", "0x00=Random, 0x01=Same"));
            memoryValues.Add(new MemoryValue("Last Saved Damage Knockout WR", 0x002FC0C8, "Int8", "Settings Knockout", "0x00=Off, 0x01=On"));

            // Lap Knockout Settings
            memoryValues.Add(new MemoryValue("Last Saved Opponent Count Lap KO WR", 0x002FC0CC, "Int8", "Settings Lap KO", "0x00=Min, 0x01=Mod, 0x02=Max, 0x03=Off"));
            memoryValues.Add(new MemoryValue("Last Saved Opponent Type Lap KO WR", 0x002FC0D0, "Int8", "Settings Lap KO", "0x00=Random, 0x01=Same"));
            memoryValues.Add(new MemoryValue("Last Saved Catch-up Lap KO WR", 0x002FC0D4, "Int8", "Settings Lap KO", "0x00=Off, 0x01=On"));
            memoryValues.Add(new MemoryValue("Last Saved Traffic Lap KO WR", 0x002FC0D8, "Int8", "Settings Lap KO", "0x00=Min, 0x01=Mod, 0x02=Max, 0x03=Off"));
            memoryValues.Add(new MemoryValue("Last Saved Traffic Lap KO HP", 0x002FC0DC, "Int8", "Settings Lap KO", "0x00=Min, 0x01=Mod, 0x02=Max, 0x03=Off"));
            memoryValues.Add(new MemoryValue("Last Saved Damage Lap KO WR", 0x002FC0E0, "Int8", "Settings Lap KO", "0x00=Off, 0x01=On"));

            // Audio Settings
            memoryValues.Add(new MemoryValue("Menu Music Volume", 0x002FC0E4, "Float", "Audio", "Menu music volume"));
            memoryValues.Add(new MemoryValue("Racing Music Volume", 0x002FC0E8, "Float", "Audio", "Racing music volume"));
            memoryValues.Add(new MemoryValue("Ambient SFX Volume", 0x002FC0EC, "Float", "Audio", "Ambient sound effects"));
            memoryValues.Add(new MemoryValue("Tire SFX Volume", 0x002FC0F0, "Float", "Audio", "Tire sound effects"));
            memoryValues.Add(new MemoryValue("Engine SFX Volume", 0x002FC0F4, "Float", "Audio", "Engine sound effects"));
            memoryValues.Add(new MemoryValue("Menu SFX Volume", 0x002FC0F8, "Float", "Audio", "Menu sound effects"));
            memoryValues.Add(new MemoryValue("Speech SFX Volume", 0x002FC0FC, "Float", "Audio", "Speech volume"));
            memoryValues.Add(new MemoryValue("Audio Mode", 0x002FC190, "Int8", "Audio", "Audio mode setting"));
            memoryValues.Add(new MemoryValue("Jukebox Type", 0x002FC192, "Int8", "Audio", "0x00=Rock, 0x01=Techno"));

            // Display Settings
            memoryValues.Add(new MemoryValue("Last Saved Rearview Mirror", 0x002FC19C, "Int8", "Display", "Mirror setting"));
            memoryValues.Add(new MemoryValue("Last Saved Units", 0x002FC19D, "Int8", "Display", "0x00=MPH, 0x01=KM/H"));
            memoryValues.Add(new MemoryValue("Last Saved Track Map", 0x002FC19E, "Int8", "Display", "Track map setting"));
            memoryValues.Add(new MemoryValue("Last Saved Leaderboard", 0x002FC1A1, "Int8", "Display", "Leaderboard setting"));
            memoryValues.Add(new MemoryValue("Last Saved Jump Cams", 0x002FC1A2, "Int8", "Display", "Jump cameras setting"));
            memoryValues.Add(new MemoryValue("Last Saved Zone Cams", 0x002FC1A3, "Int8", "Display", "Zone cameras setting"));

            // Track/Event Selection
            memoryValues.Add(new MemoryValue("Last Selected Track", 0x002FC1A4, "Int32", "Selection", "Track ID",
@"0x0B = Coastal Parklands
0x0C = National Forest
0x0D = Scenic Drive
0x15 = Desert Heat
0x16 = Outback
0x17 = Rocky Canyons
0x1F = Ancient Ruins
0x20 = Calypso Coast
0x21 = Mediterranean
0x29 = Fall Winds
0x2A = Alpine Trail
0x2B = Autumn Crossing
0x3D = Island Outskirts
0x3E = Palm City Island
0x3F = Tropical Circuit"));
            memoryValues.Add(new MemoryValue("Last Saved Total Laps Challenge", 0x002FC1A8, "Int8", "Selection", "Total laps for challenge mode"));
            memoryValues.Add(new MemoryValue("Last Selected Weather", 0x002FC1B0, "Int32", "Selection", "0=Sunny, 1=Overcast, 2=Sunset, 4=Dawn"));
            memoryValues.Add(new MemoryValue("Last Selected UR Event", 0x002FC1B8, "Int32", "Selection", "Ultimate Racer event number"));
            memoryValues.Add(new MemoryValue("Last Selected CH Event", 0x002FC1BC, "Int32", "Selection", "Championship event number"));
            memoryValues.Add(new MemoryValue("UR/CH Event Info Screen", 0x002FC1C0, "Int8", "Selection", "0x00=Not Viewing, 0x02=Viewing"));

            // Championship Events
            memoryValues.Add(new MemoryValue("Championship Event 2 Time", 0x002FC1D8, "Int32", "Championship", "Event 2 time"));
            memoryValues.Add(new MemoryValue("Championship Event 5 Knockout", 0x002FC1DC, "Int32", "Championship", "Event 5 knockout result"));
            memoryValues.Add(new MemoryValue("Championship Event 6", 0x002FC1EC, "Int32", "Championship", "3-Race Tournament (26 pts/race, 78 total)"));
            memoryValues.Add(new MemoryValue("Championship Event 8 Best Time", 0x002FC1FC, "Int32", "Championship", "Event 8 best time"));
            memoryValues.Add(new MemoryValue("Championship Event 9", 0x002FC200, "Int64", "Championship", "5-Race Tournament (130 pts total)",
@"Every two bytes is a different player's points.
Your points are at offset +0x00.
10=1st, 6=2nd, 4=3rd, 3=4th, 2=5th, 1=6th, 0=7th
26 points per race, 5 races = 130 total"));
            memoryValues.Add(new MemoryValue("Championship Event 10", 0x002FC210, "Int64", "Championship", "5-Race Tournament (see event 9)"));
            memoryValues.Add(new MemoryValue("Championship Event 11", 0x002FC220, "Int32", "Championship", "Time under 3:10.00 to pass"));
            memoryValues.Add(new MemoryValue("Championship Event 12", 0x002FC224, "Int32", "Championship", "4bit is player finishing place"));
            memoryValues.Add(new MemoryValue("Championship Event 14", 0x002FC234, "Int32", "Championship", "4bit is player finishing place"));
            memoryValues.Add(new MemoryValue("Championship Event 15", 0x002FC244, "Int64", "Championship", "4-Race Tournament (104 pts total)"));
            memoryValues.Add(new MemoryValue("Championship Event 17", 0x002FC254, "Int32", "Championship", "4bit is player finishing place"));
            memoryValues.Add(new MemoryValue("Championship Event 18", 0x002FC264, "Int64", "Championship", "6-Race Tournament (156 pts total)"));
            memoryValues.Add(new MemoryValue("Championship Event 24", 0x002FC274, "Int32", "Championship", "Time under 3:30.00 to pass"));
            memoryValues.Add(new MemoryValue("Championship Event 25", 0x002FC278, "Int32", "Championship", "4bit is player finishing place"));
            memoryValues.Add(new MemoryValue("Championship Event 26", 0x002FC288, "Int32", "Championship", "4bit is player finishing place"));
            memoryValues.Add(new MemoryValue("Championship Event 27", 0x002FC298, "Int64", "Championship", "4-Race Tournament (104 pts total)"));
            memoryValues.Add(new MemoryValue("Championship Event 28", 0x002FC2A8, "Int64", "Championship", "7-Race Tournament (182 pts total)"));
            memoryValues.Add(new MemoryValue("Championship Event 1", 0x002FC2B8, "Int8", "Championship", "0x01=1st place"));
            memoryValues.Add(new MemoryValue("Championship Event 3", 0x002FC2B9, "Int8", "Championship", "0x01=1st place"));
            memoryValues.Add(new MemoryValue("Championship Event 4", 0x002FC2BA, "Int8", "Championship", "0x01=1st place"));
            memoryValues.Add(new MemoryValue("Championship Event 7", 0x002FC2BB, "Int8", "Championship", "0x01=1st place"));
            memoryValues.Add(new MemoryValue("Championship Event 13", 0x002FC2BC, "Int8", "Championship", "0x01=1st place"));
            memoryValues.Add(new MemoryValue("Championship Event 16", 0x002FC2BD, "Int8", "Championship", "0x01=1st place"));
            memoryValues.Add(new MemoryValue("Championship Event 19", 0x002FC2BE, "Int8", "Championship", "0x01=1st place"));
            memoryValues.Add(new MemoryValue("Championship Event 20", 0x002FC2BF, "Int8", "Championship", "0x01=1st place"));
            memoryValues.Add(new MemoryValue("Championship Event 21", 0x002FC2C0, "Int8", "Championship", "0x01=1st place"));
            memoryValues.Add(new MemoryValue("Championship Event 22", 0x002FC2C1, "Int8", "Championship", "0x01=1st place"));
            memoryValues.Add(new MemoryValue("Championship Event 23", 0x002FC2C2, "Int8", "Championship", "0x01=1st place"));
            memoryValues.Add(new MemoryValue("Championship Event 29", 0x002FC2C3, "Int8", "Championship", "0x01=1st place"));
            memoryValues.Add(new MemoryValue("Championship Event 30", 0x002FC2C4, "Int8", "Championship", "0x01=1st place"));
            memoryValues.Add(new MemoryValue("Championship Event 31", 0x002FC2C5, "Int8", "Championship", "0x01=1st place"));
            memoryValues.Add(new MemoryValue("Championship Event 32", 0x002FC2C6, "Int8", "Championship", "0x01=1st place (also Ultimate Racer)"));

            // Ultimate Racer Events
            memoryValues.Add(new MemoryValue("Ultimate Racer Event 1 Time", 0x002FC2D8, "Int32", "Ultimate Racer", "Time (÷40 for 0.01 sec)"));
            memoryValues.Add(new MemoryValue("Ultimate Racer Event 2 Time", 0x002FC2DC, "Int32", "Ultimate Racer", "Time"));
            memoryValues.Add(new MemoryValue("Ultimate Racer Event 3 Time", 0x002FC2E0, "Int32", "Ultimate Racer", "Time"));
            memoryValues.Add(new MemoryValue("Ultimate Racer Event 4 Knockout", 0x002FC2E4, "Int32", "Ultimate Racer", "Last byte is place finished"));
            memoryValues.Add(new MemoryValue("Ultimate Racer Event 4 Options", 0x002FC2EC, "Int32", "Ultimate Racer", "Car options used?"));
            memoryValues.Add(new MemoryValue("Ultimate Racer Event 5 Time", 0x002FC2F4, "Int32", "Ultimate Racer", "Time (higher is better)"));
            memoryValues.Add(new MemoryValue("Ultimate Racer Event 6 Knockout", 0x002FC2F8, "Int32", "Ultimate Racer", "Knockout result"));
            memoryValues.Add(new MemoryValue("Ultimate Racer Event 8 Knockout", 0x002FC308, "Int32", "Ultimate Racer", "Knockout result"));
            memoryValues.Add(new MemoryValue("Ultimate Racer Event 9 Time", 0x002FC318, "Int32", "Ultimate Racer", "Time (higher is better)"));
            memoryValues.Add(new MemoryValue("Ultimate Racer Event 13 Time", 0x002FC31C, "Int32", "Ultimate Racer", "Time (higher is better)"));
            memoryValues.Add(new MemoryValue("Ultimate Racer Event 14 Multi-race", 0x002FC320, "Int32", "Ultimate Racer", "5-race tournament (115 pts total)",
@"Every two bytes is a CPU tournament point total.
Last two bytes is point total for Player.
23 pts = 1 of 5, 46 pts = 2 of 5, 69 pts = 3 of 5
92 pts = 4 of 5, 115 (0x73) pts = 5 of 5 completed"));
            memoryValues.Add(new MemoryValue("Ultimate Racer Event 15 Multi-race", 0x002FC330, "Int32", "Ultimate Racer", "Multi-race (see event 14)"));
            memoryValues.Add(new MemoryValue("Ultimate Racer Event 17 Best Time", 0x002FC340, "Int32", "Ultimate Racer", "Best time"));
            memoryValues.Add(new MemoryValue("Ultimate Racer Event 18 Best Time", 0x002FC344, "Int32", "Ultimate Racer", "Best time"));
            memoryValues.Add(new MemoryValue("Ultimate Racer Event 19 Best Time", 0x002FC348, "Int32", "Ultimate Racer", "Best time"));
            memoryValues.Add(new MemoryValue("Ultimate Racer Event 24 Best Time", 0x002FC34C, "Int32", "Ultimate Racer", "Best time"));
            memoryValues.Add(new MemoryValue("Ultimate Racer Event 25 Knockout", 0x002FC350, "Int32", "Ultimate Racer", "Last byte is final place"));
            memoryValues.Add(new MemoryValue("Ultimate Racer Event 26 Knockout", 0x002FC360, "Int32", "Ultimate Racer", "Lower4 = passed (1 if player wins)"));
            memoryValues.Add(new MemoryValue("Ultimate Racer Event 27 Best Time", 0x002FC370, "Int32", "Ultimate Racer", "Best time"));
            memoryValues.Add(new MemoryValue("Ultimate Racer Event 28 Multi-race", 0x002FC374, "Int32", "Ultimate Racer", "8-race (184 pts total)"));
            memoryValues.Add(new MemoryValue("Ultimate Racer Event 29 Multi-race", 0x002FC384, "Int32", "Ultimate Racer", "8-race (184 pts total)"));
            memoryValues.Add(new MemoryValue("Ultimate Racer Event 7 Race", 0x002FC394, "Int8", "Ultimate Racer", "0=Incomplete, 1=First, 2=Second"));
            memoryValues.Add(new MemoryValue("Ultimate Racer Event 10 Race", 0x002FC395, "Int8", "Ultimate Racer", "Race result"));
            memoryValues.Add(new MemoryValue("Ultimate Racer Event 11 Knockout", 0x002FC396, "Int8", "Ultimate Racer", "0x01=First"));
            memoryValues.Add(new MemoryValue("Ultimate Racer Event 12 Knockout", 0x002FC397, "Int8", "Ultimate Racer", "0x01=First"));
            memoryValues.Add(new MemoryValue("Ultimate Racer Event 16 Race", 0x002FC398, "Int8", "Ultimate Racer", "0x01=First"));
            memoryValues.Add(new MemoryValue("Ultimate Racer Event 20 Race", 0x002FC399, "Int8", "Ultimate Racer", "0x01=First"));
            memoryValues.Add(new MemoryValue("Ultimate Racer Event 21 Race", 0x002FC39A, "Int8", "Ultimate Racer", "0x01=First"));
            memoryValues.Add(new MemoryValue("Ultimate Racer Event 22 Race", 0x002FC39B, "Int8", "Ultimate Racer", "0x01=First"));
            memoryValues.Add(new MemoryValue("Ultimate Racer Event 23 Race", 0x002FC39C, "Int8", "Ultimate Racer", "0x01=First"));
            memoryValues.Add(new MemoryValue("Ultimate Racer Event 30 Race", 0x002FC39D, "Int8", "Ultimate Racer", "0x01=First"));
            memoryValues.Add(new MemoryValue("Ultimate Racer Event 31 Race", 0x002FC39E, "Int8", "Ultimate Racer", "0x01=First"));
            memoryValues.Add(new MemoryValue("Event 32 Pointer", 0x002FC3D8, "Int32", "Ultimate Racer", "Points to Event 32 for UR & Championship"));

            // NFS Points
            memoryValues.Add(new MemoryValue("NFS Points", 0x002FC400, "Int32", "Progression", "Total NFS points"));
            memoryValues.Add(new MemoryValue("NFS Points Alt", 0x0030CE54, "Int32", "Progression", "Alt NFS points address"));

            // Best Total Times - Coastal Parklands
            memoryValues.Add(new MemoryValue("CP Class A 2 Laps", 0x002FC730, "Int32", "Best Times CP", "Coastal Parklands Class A"));
            memoryValues.Add(new MemoryValue("CP Class A 4 Laps", 0x002FC780, "Int32", "Best Times CP", "Coastal Parklands Class A"));
            memoryValues.Add(new MemoryValue("CP Class A 8 Laps", 0x002FC820, "Int32", "Best Times CP", "Coastal Parklands Class A"));
            memoryValues.Add(new MemoryValue("CP II Class A 2 Laps", 0x002FC898, "Int32", "Best Times CP", "Coastal Parklands II Class A"));
            memoryValues.Add(new MemoryValue("CP II Class A 4 Laps", 0x002FC8E8, "Int32", "Best Times CP", "Coastal Parklands II Class A"));
            memoryValues.Add(new MemoryValue("CP II Class A 8 Laps", 0x002FC988, "Int32", "Best Times CP", "Coastal Parklands II Class A"));
            memoryValues.Add(new MemoryValue("CP Class B 2 Laps", 0x002FCA00, "Int32", "Best Times CP", "Coastal Parklands Class B"));
            memoryValues.Add(new MemoryValue("CP Class B 4 Laps", 0x002FCA50, "Int32", "Best Times CP", "Coastal Parklands Class B"));
            memoryValues.Add(new MemoryValue("CP Class B 8 Laps", 0x002FCAF0, "Int32", "Best Times CP", "Coastal Parklands Class B"));
            memoryValues.Add(new MemoryValue("CP II Class B 2 Laps", 0x002FCB68, "Int32", "Best Times CP", "Coastal Parklands II Class B"));
            memoryValues.Add(new MemoryValue("CP II Class B 4 Laps", 0x002FCBB8, "Int32", "Best Times CP", "Coastal Parklands II Class B"));
            memoryValues.Add(new MemoryValue("CP II Class B 8 Laps", 0x002FCC58, "Int32", "Best Times CP", "Coastal Parklands II Class B"));
            memoryValues.Add(new MemoryValue("CP Class C 2 Laps", 0x002FCCD0, "Int32", "Best Times CP", "Coastal Parklands Class C"));
            memoryValues.Add(new MemoryValue("CP Class C 4 Laps", 0x002FCD20, "Int32", "Best Times CP", "Coastal Parklands Class C"));
            memoryValues.Add(new MemoryValue("CP Class C 8 Laps", 0x002FCDC0, "Int32", "Best Times CP", "Coastal Parklands Class C"));
            memoryValues.Add(new MemoryValue("CP II Class C 2 Laps", 0x002FCE38, "Int32", "Best Times CP", "Coastal Parklands II Class C"));
            memoryValues.Add(new MemoryValue("CP II Class C 4 Laps", 0x002FCE88, "Int32", "Best Times CP", "Coastal Parklands II Class C"));
            memoryValues.Add(new MemoryValue("CP II Class C 8 Laps", 0x002FCF28, "Int32", "Best Times CP", "Coastal Parklands II Class C"));
            memoryValues.Add(new MemoryValue("CP Class D Event", 0x002FCF78, "Int32", "Best Times CP", "Coastal Parklands Class D 1 lap Event"));
            memoryValues.Add(new MemoryValue("CP Class D 2 Laps", 0x002FCFA0, "Int32", "Best Times CP", "Coastal Parklands Class D"));
            memoryValues.Add(new MemoryValue("CP Class D 4 Laps", 0x002FCFF0, "Int32", "Best Times CP", "Coastal Parklands Class D"));
            memoryValues.Add(new MemoryValue("CP Class D 8 Laps", 0x002FD090, "Int32", "Best Times CP", "Coastal Parklands Class D"));
            memoryValues.Add(new MemoryValue("CP II Class D 2 Laps", 0x002FD108, "Int32", "Best Times CP", "Coastal Parklands II Class D"));
            memoryValues.Add(new MemoryValue("CP II Class D 4 Laps", 0x002FD158, "Int32", "Best Times CP", "Coastal Parklands II Class D"));
            memoryValues.Add(new MemoryValue("CP II Class D 8 Laps", 0x002FD1F8, "Int32", "Best Times CP", "Coastal Parklands II Class D"));
            memoryValues.Add(new MemoryValue("CP Class E 2 Laps", 0x002FD270, "Int32", "Best Times CP", "Coastal Parklands Class E"));
            memoryValues.Add(new MemoryValue("CP Class E 4 Laps", 0x002FD2C0, "Int32", "Best Times CP", "Coastal Parklands Class E"));
            memoryValues.Add(new MemoryValue("CP Class E 8 Laps", 0x002FD360, "Int32", "Best Times CP", "Coastal Parklands Class E"));
            memoryValues.Add(new MemoryValue("CP II Class E 2 Laps", 0x002FD3D8, "Int32", "Best Times CP", "Coastal Parklands II Class E"));
            memoryValues.Add(new MemoryValue("CP II Class E 4 Laps", 0x002FD428, "Int32", "Best Times CP", "Coastal Parklands II Class E"));
            memoryValues.Add(new MemoryValue("CP II Class E 8 Laps", 0x002FD4C8, "Int32", "Best Times CP", "Coastal Parklands II Class E"));

            // Best Total Times - National Forest
            memoryValues.Add(new MemoryValue("NF Class A 2 Laps", 0x002FD540, "Int32", "Best Times NF", "National Forest Class A"));
            memoryValues.Add(new MemoryValue("NF Class A 4 Laps", 0x002FD590, "Int32", "Best Times NF", "National Forest Class A"));
            memoryValues.Add(new MemoryValue("NF Class A 8 Laps", 0x002FD630, "Int32", "Best Times NF", "National Forest Class A"));
            memoryValues.Add(new MemoryValue("NF II Class A 2 Laps", 0x002FD6A8, "Int32", "Best Times NF", "National Forest II Class A"));
            memoryValues.Add(new MemoryValue("NF II Class A 4 Laps", 0x002FD6F8, "Int32", "Best Times NF", "National Forest II Class A"));
            memoryValues.Add(new MemoryValue("NF II Class A 8 Laps", 0x002FD798, "Int32", "Best Times NF", "National Forest II Class A"));
            memoryValues.Add(new MemoryValue("NF Class E Event", 0x002FE058, "Int32", "Best Times NF", "National Forest Class E Championship Event 5 1 lap"));

            // Best Total Times - Desert Heat
            memoryValues.Add(new MemoryValue("DH Class A 2 Laps", 0x002FF160, "Int32", "Best Times DH", "Desert Heat Class A"));
            memoryValues.Add(new MemoryValue("DH Class A 4 Laps", 0x002FF1B0, "Int32", "Best Times DH", "Desert Heat Class A"));
            memoryValues.Add(new MemoryValue("DH Class A 8 Laps", 0x002FF250, "Int32", "Best Times DH", "Desert Heat Class A"));

            // Best Lap Times - All Tracks
            memoryValues.Add(new MemoryValue("CP Class A Best Lap", 0x0030A808, "Int32", "Best Laps", "Coastal Parklands Class A"));
            memoryValues.Add(new MemoryValue("CP II Class A Best Lap", 0x0030A830, "Int32", "Best Laps", "Coastal Parklands II Class A"));
            memoryValues.Add(new MemoryValue("CP Class B Best Lap", 0x0030A858, "Int32", "Best Laps", "Coastal Parklands Class B"));
            memoryValues.Add(new MemoryValue("CP II Class B Best Lap", 0x0030A880, "Int32", "Best Laps", "Coastal Parklands II Class B"));
            memoryValues.Add(new MemoryValue("CP Class C Best Lap", 0x0030A8A8, "Int32", "Best Laps", "Coastal Parklands Class C"));
            memoryValues.Add(new MemoryValue("CP II Class C Best Lap", 0x0030A8D0, "Int32", "Best Laps", "Coastal Parklands II Class C"));
            memoryValues.Add(new MemoryValue("CP Class D Best Lap", 0x0030A8F8, "Int32", "Best Laps", "Coastal Parklands Class D"));
            memoryValues.Add(new MemoryValue("CP II Class D Best Lap", 0x0030A920, "Int32", "Best Laps", "Coastal Parklands II Class D"));
            memoryValues.Add(new MemoryValue("CP Class E Best Lap", 0x0030A948, "Int32", "Best Laps", "Coastal Parklands Class E"));
            memoryValues.Add(new MemoryValue("CP II Class E Best Lap", 0x0030A970, "Int32", "Best Laps", "Coastal Parklands II Class E"));
            memoryValues.Add(new MemoryValue("NF Class A Best Lap", 0x0030A998, "Int32", "Best Laps", "National Forest Class A"));
            memoryValues.Add(new MemoryValue("NF II Class A Best Lap", 0x0030A9C0, "Int32", "Best Laps", "National Forest II Class A"));
            memoryValues.Add(new MemoryValue("DH Class A Best Lap", 0x0030ACB8, "Int32", "Best Laps", "Desert Heat Class A"));
            memoryValues.Add(new MemoryValue("AR Class A Best Lap", 0x0030B168, "Int32", "Best Laps", "Ancient Ruins Class A"));
            memoryValues.Add(new MemoryValue("CC Class A Best Lap", 0x0030B2F8, "Int32", "Best Laps", "Calypso Coast Class A"));
            memoryValues.Add(new MemoryValue("FW Class A Best Lap", 0x0030B618, "Int32", "Best Laps", "Fall Winds Class A"));
            memoryValues.Add(new MemoryValue("AT Class A Best Lap", 0x0030B7A8, "Int32", "Best Laps", "Alpine Trail Class A"));
            memoryValues.Add(new MemoryValue("IO Class A Best Lap", 0x0030BAC8, "Int32", "Best Laps", "Island Outskirts Class A"));
            memoryValues.Add(new MemoryValue("PCI Class A Best Lap", 0x0030BC58, "Int32", "Best Laps", "Palm City Island Class A"));
            memoryValues.Add(new MemoryValue("TC Class A Best Lap", 0x0030BDE8, "Int32", "Best Laps", "Tropical Circuit Class A"));

            // Car Unlock Flags - Clean Race / Lead All Laps
            memoryValues.Add(new MemoryValue("HSV GTS NFS Unlock", 0x0030C708, "Int8", "Unlocks", "Clean race, Single Race, 1P, 4 laps, Advanced AI"));
            memoryValues.Add(new MemoryValue("Mercedes CLK GTR Unlock", 0x0030C70C, "Int8", "Unlocks", "Clean race, Single Race, 1P, 8 laps, Advanced AI"));
            memoryValues.Add(new MemoryValue("BMW M5 PD Unlock", 0x0030C710, "Int8", "Unlocks", "Lead all laps [1P, 2 laps, HP, Full Grid, Advanced] YTC"));
            memoryValues.Add(new MemoryValue("Mercedes CL55 AMG NFS Unlock", 0x0030C714, "Int8", "Unlocks", "Lead all laps [1P, 2 laps, WR, Full Grid, Advanced]"));
            memoryValues.Add(new MemoryValue("Mustang SVT Cobra R PD Unlock", 0x0030C718, "Int8", "Unlocks", "Lead all laps [1P, 4 laps, HP, Full Grid, Advanced] YTC"));
            memoryValues.Add(new MemoryValue("Vauxhall VX 220 NFS Unlock", 0x0030C71C, "Int8", "Unlocks", "Lead all laps [1P, 4 laps, WR, Full Grid, Advanced]"));
            memoryValues.Add(new MemoryValue("Ferrari F50 NFS Unlock", 0x0030C720, "Int8", "Unlocks", "Lead all laps [1P, 8 laps, WR, Full Grid, Advanced]"));
            memoryValues.Add(new MemoryValue("Lamborghini Murciélago PD Unlock", 0x0030C724, "Int8", "Unlocks", "Win Knockout [1P, HP, Advanced] YTC"));
            memoryValues.Add(new MemoryValue("Ford TS50 NFS Unlock", 0x0030C728, "Int8", "Unlocks", "Win Knockout [1P, WR, Advanced]"));
            memoryValues.Add(new MemoryValue("Corvette Z06 PD Unlock", 0x0030C72C, "Int8", "Unlocks", "Win Lap Knockout [1P, HP, Advanced] YTC"));

            // Car Unlock Flags - NFS Points
            memoryValues.Add(new MemoryValue("HSV GTS Unlock (50K)", 0x0030C730, "Int8", "Unlocks", "50,000 NFS Points"));
            memoryValues.Add(new MemoryValue("BMW Z8 Unlock (100K)", 0x0030C734, "Int8", "Unlocks", "100,000 NFS Points"));
            memoryValues.Add(new MemoryValue("Jaguar XKR NFS Unlock (150K)", 0x0030C738, "Int8", "Unlocks", "150,000 NFS Points"));
            memoryValues.Add(new MemoryValue("Ferrari 550 Barchetta Unlock (200K)", 0x0030C73C, "Int8", "Unlocks", "200,000 NFS Points"));
            memoryValues.Add(new MemoryValue("Lotus Elise NFS Unlock (250K)", 0x0030C740, "Int8", "Unlocks", "250,000 NFS Points"));
            memoryValues.Add(new MemoryValue("Ferrari F50 Unlock (300K)", 0x0030C744, "Int8", "Unlocks", "300,000 NFS Points"));
            memoryValues.Add(new MemoryValue("Aston Martin V12 NFS Unlock (400K)", 0x0030C748, "Int8", "Unlocks", "400,000 NFS Points"));
            memoryValues.Add(new MemoryValue("Mustang SVT Cobra R NFS Unlock (500K)", 0x0030C74C, "Int8", "Unlocks", "500,000 NFS Points"));
            memoryValues.Add(new MemoryValue("Porsche 911 Turbo NFS Unlock (750K)", 0x0030C750, "Int8", "Unlocks", "750,000 NFS Points"));
            memoryValues.Add(new MemoryValue("Ferrari 550 Barchetta NFS Unlock (1M)", 0x0030C754, "Int8", "Unlocks", "1,000,000 NFS Points"));
            memoryValues.Add(new MemoryValue("Dodge Viper GTS NFS Unlock (1.5M)", 0x0030C758, "Int8", "Unlocks", "1,500,000 NFS Points"));
            memoryValues.Add(new MemoryValue("Lamborghini Diablo NFS Unlock (2M)", 0x0030C75C, "Int8", "Unlocks", "2,000,000 NFS Points"));
            memoryValues.Add(new MemoryValue("Corvette Z06 NFS Unlock (2.5M)", 0x0030C760, "Int8", "Unlocks", "2,500,000 NFS Points"));
            memoryValues.Add(new MemoryValue("Lamborghini Murciélago NFS Unlock (3M)", 0x0030C764, "Int8", "Unlocks", "3,000,000 NFS Points"));
            memoryValues.Add(new MemoryValue("Porsche Carrera GT NFS Unlock (3.5M)", 0x0030C768, "Int8", "Unlocks", "3,500,000 NFS Points"));
            memoryValues.Add(new MemoryValue("McLaren F1 NFS Unlock (4M)", 0x0030C76C, "Int8", "Unlocks", "4,000,000 NFS Points"));
            memoryValues.Add(new MemoryValue("Mercedes CLK GTR NFS Unlock (4.5M)", 0x0030C770, "Int8", "Unlocks", "4,500,000 NFS Points"));
            memoryValues.Add(new MemoryValue("McLaren F1 LM NFS Unlock (5M)", 0x0030C774, "Int8", "Unlocks", "5,000,000 NFS Points"));

            // Player Saved Data
            memoryValues.Add(new MemoryValue("P1 Last Saved Split Time", 0x0030CDD2, "Int8", "Player Data", "P1 split time setting"));
            memoryValues.Add(new MemoryValue("P1 Last Saved Camera Spring", 0x0030CDD4, "Int8", "Player Data", "P1 camera spring setting"));
            memoryValues.Add(new MemoryValue("P1 Last Saved Lookback", 0x0030CDD8, "Int8", "Player Data", "P1 lookback setting"));
            memoryValues.Add(new MemoryValue("P1 Last Saved Position", 0x0030CDDC, "Int8", "Player Data", "Bit4 - P1 position"));
            memoryValues.Add(new MemoryValue("P1 Last Saved Lap Info", 0x0030CDDD, "Int8", "Player Data", "P1 lap info"));
            memoryValues.Add(new MemoryValue("P1 Last Saved Score", 0x0030CDF8, "Int8", "Player Data", "P1 score"));
            memoryValues.Add(new MemoryValue("Last Saved Car ID Challenge", 0x0030CE14, "Int8", "Player Data", "Car ID for Challenge Mode"));
            memoryValues.Add(new MemoryValue("Last Saved Car Paint Color", 0x0030CE19, "Int8", "Player Data", "Can also apply NFS paint to base model"));
            memoryValues.Add(new MemoryValue("Last Saved Car ID Championship", 0x0030CE3C, "Int8", "Player Data", "Car ID for Championship"));
            memoryValues.Add(new MemoryValue("Last Saved Car ID Ultimate Racer", 0x0030CE44, "Int8", "Player Data", "Car ID for Ultimate Racer"));
            memoryValues.Add(new MemoryValue("P2 Last Saved Split Time", 0x0030D4A2, "Int8", "Player Data", "P2 split time setting"));

            // Current Race Info
            memoryValues.Add(new MemoryValue("Current Track ID with Weather", 0x0031A898, "Int8", "Current Race", "Track+weather combo",
@"0x0B = Coastal Parklands Sunny
0x0E = Coastal Parklands Overcast
0x0C = National Forest Sunny
0x0F = National Forest Overcast
0x0D = Scenic Drive Sunny
0x10 = Scenic Drive Overcast
0x15 = Desert Heat Sunny
0x18 = Desert Heat Overcast
0x16 = Outback Sunny
0x19 = Outback Overcast
0x17 = Rocky Canyons Sunny
0x1A = Rocky Canyons Overcast
0x1F = Ancient Ruins Sunny
0x22 = Ancient Ruins Sunset
0x20 = Calypso Coast Sunny
0x23 = Calypso Coast Sunset
0x21 = Mediterranean Sunny
0x24 = Mediterranean Sunset
0x29 = Fall Winds Sunny
0x2C = Fall Winds Dawn
0x2A = Alpine Trail Sunny
0x2D = Alpine Trail Dawn
0x2B = Autumn Crossing Sunny
0x2E = Autumn Crossing Dawn
0x3D = Island Outskirts Sunny
0x40 = Island Outskirts Sunset
0x3E = Palm City Island Sunny
0x41 = Palm City Island Sunset
0x3F = Tropical Circuit Sunny
0x42 = Tropical Circuit Sunset"));
            memoryValues.Add(new MemoryValue("Current Track Reverse Flag", 0x0031A8A4, "Int8", "Current Race", "0x00=Normal, 0x01=Reverse"));
            memoryValues.Add(new MemoryValue("Current Total Race Laps", 0x0031A8C4, "Int8", "Current Race", "Total laps in race"));
            memoryValues.Add(new MemoryValue("Current Opponent Count", 0x0031A8CC, "Int8", "Current Race", "Number of opponents"));
            memoryValues.Add(new MemoryValue("Current Race Skill Level Alt", 0x0031AB20, "Int32", "Current Race", "Alt skill level address"));
            memoryValues.Add(new MemoryValue("Player Name ASCII", 0x0031AB38, "Int32", "Current Race", "Player name in ASCII"));
            memoryValues.Add(new MemoryValue("Jump Cams Active", 0x0031AB8A, "Int8", "Current Race", "Jump cameras enabled"));
            memoryValues.Add(new MemoryValue("Zone Cams Active", 0x0031AB8B, "Int8", "Current Race", "0x00=Off, 0x01=On"));
            memoryValues.Add(new MemoryValue("Current Race Skill Level", 0x0031AB8C, "Int32", "Current Race", "Skill level for this race"));
            memoryValues.Add(new MemoryValue("Player Starting Grid Position", 0x0031ABB4, "Int8", "Current Race", "Always 8th for WR or 4th for HP single race with full grid"));
            memoryValues.Add(new MemoryValue("Player ID Flag", 0x0031ABB8, "Int8", "Current Race", "0x01=User Controlled, 0x02=AI"));
            memoryValues.Add(new MemoryValue("Current Player Car ID", 0x0031ABBC, "Int8", "Current Race", "Car ID",
@"Standard Cars:
0x0D = Ford TS50
0x29 = Lotus Elise
0x2B = Mercedes-Benz CL55 AMG
0x25 = Opel Speedster
0x23 = Vauxhall VX 220
0x13 = BMW M5
0x0F = HSV GTS
0x1B = Jaguar XKR
0x1D = Aston Martin V12 Vanquish
0x14 = BMW Z8
0x15 = Ferrari 360 Spider
0x19 = Ferrari 550 Barchetta
0x0B = Mustang SVT Cobra R
0x00 = Corvette Z06
0x02 = Dodge Viper GTS
0x17 = Ferrari F50
0x2D = Lamborghini Diablo 6.0
0x2F = Lamborghini Murciélago
0x27 = Porsche 911 Turbo
0x11 = Porsche Carrera GT
0x07 = McLaren F1
0x09 = McLaren F1 LM
0x05 = Mercedes-Benz CLK GTR

NFS Cars:
0x0E = Ford TS50 NFS
0x2A = Lotus Elise NFS
0x2C = Mercedes-Benz CL55 AMG NFS
0x24 = Vauxhall VX 220 NFS
0x10 = HSV GTS NFS
0x1C = Jaguar XKR NFS
0x16 = Ferrari 360 Modena Challenge NFS
0x1A = Ferrari 550 Barchetta NFS
0x0C = Mustang SVT Cobra R NFS
0x1E = Aston Martin V12 Vanquish NFS
0x01 = Corvette Z06 NFS
0x03 = Dodge Viper GTS NFS
0x18 = Ferrari F50 NFS
0x2E = Lamborghini Diablo 6.0 NFS
0x30 = Lamborghini Murciélago NFS
0x28 = Porsche 911 Turbo NFS
0x12 = Porsche Carrera GT NFS
0x08 = McLaren F1 NFS
0x0A = McLaren F1 LM NFS
0x06 = Mercedes-Benz CLK GTR NFS

Cop Cars:
0x04 = Ford Crown Victoria COP
0x1F = BMW M5 COP
0x22 = Mustang SVT Cobra R COP
0x21 = Corvette Z06 COP
0x20 = Lamborghini Murciélago COP

Traffic:
0x31 = Delivery Truck
0x32 = Pickup Truck
0x35 = SUV
0x3A = Sedan
0x3C = Taxi
0x3D = Van"));

            // AI Data
            memoryValues.Add(new MemoryValue("AI 1 Start Pos", 0x0031ABCC, "Int8", "AI Data", "AI 1 starting position"));
            memoryValues.Add(new MemoryValue("AI 1 ID", 0x0031ABD0, "Int8", "AI Data", "AI 1 racer ID"));
            memoryValues.Add(new MemoryValue("AI 1 Car ID", 0x0031ABD4, "Int8", "AI Data", "AI 1 car ID"));
            memoryValues.Add(new MemoryValue("AI 2 Start Pos", 0x0031ABE4, "Int8", "AI Data", "AI 2 starting position"));
            memoryValues.Add(new MemoryValue("AI 2 ID", 0x0031ABE8, "Int8", "AI Data", "AI 2 racer ID"));
            memoryValues.Add(new MemoryValue("AI 2 Car ID", 0x0031ABEC, "Int8", "AI Data", "AI 2 car ID"));
            memoryValues.Add(new MemoryValue("AI 3 Start Pos", 0x0031ABFC, "Int8", "AI Data", "AI 3 starting position"));
            memoryValues.Add(new MemoryValue("AI 3 ID", 0x0031AC00, "Int8", "AI Data", "AI 3 racer ID"));
            memoryValues.Add(new MemoryValue("AI 3 Car ID", 0x0031AC04, "Int8", "AI Data", "AI 3 car ID"));
            memoryValues.Add(new MemoryValue("AI 4 Start Pos", 0x0031AC14, "Int8", "AI Data", "AI 4 starting position"));
            memoryValues.Add(new MemoryValue("AI 4 ID", 0x0031AC18, "Int8", "AI Data", "AI 4 racer ID"));
            memoryValues.Add(new MemoryValue("AI 4 Car ID", 0x0031AC1C, "Int8", "AI Data", "AI 4 car ID"));
            memoryValues.Add(new MemoryValue("AI 5 Start Pos", 0x0031AC2C, "Int8", "AI Data", "AI 5 starting position"));
            memoryValues.Add(new MemoryValue("AI 5 ID", 0x0031AC30, "Int8", "AI Data", "AI 5 racer ID"));
            memoryValues.Add(new MemoryValue("AI 5 Car ID", 0x0031AC34, "Int8", "AI Data", "AI 5 car ID"));
            memoryValues.Add(new MemoryValue("AI 6 Start Pos", 0x0031AC44, "Int8", "AI Data", "AI 6 starting position"));
            memoryValues.Add(new MemoryValue("AI 6 ID", 0x0031AC48, "Int8", "AI Data", "AI 6 racer ID"));
            memoryValues.Add(new MemoryValue("AI 6 Car ID", 0x0031AC4C, "Int8", "AI Data", "AI 6 car ID"));
            memoryValues.Add(new MemoryValue("AI 7 Start Pos", 0x0031AC5C, "Int8", "AI Data", "AI 7 starting position"));
            memoryValues.Add(new MemoryValue("AI 7 ID", 0x0031AC60, "Int8", "AI Data", "AI 7 racer ID"));
            memoryValues.Add(new MemoryValue("AI 7 Car ID", 0x0031AC64, "Int8", "AI Data", "AI 7 car ID"));

            // Race Results
            memoryValues.Add(new MemoryValue("Last Race Finish Place", 0x0031B750, "Int32", "Results", "Finishing position (1=first)"));
            memoryValues.Add(new MemoryValue("Last Race Completion Time", 0x0031B754, "Int32", "Results", "Completion time"));
            memoryValues.Add(new MemoryValue("Last Race Completion Flag", 0x0031B758, "Int32", "Results", "Completion flag"));

            // Cheat Flags - Visual
            memoryValues.Add(new MemoryValue("Motion Blur Cheat", 0x0031D858, "Int8", "Cheats Visual", "Motion blur effect"));
            memoryValues.Add(new MemoryValue("Black and White Cheat", 0x0031D890, "Int8", "Cheats Visual", "B&W mode"));
            memoryValues.Add(new MemoryValue("Foggy Weather Cheat", 0x0031D8C8, "Int8", "Cheats Visual", "Foggy weather"));
            memoryValues.Add(new MemoryValue("R/C Cars Cheat", 0x0031D900, "Int8", "Cheats Visual", "RC car mode"));
            memoryValues.Add(new MemoryValue("Video Mode Cheat", 0x0031D938, "Int8", "Cheats Visual", "Video mode with scan lines"));
            memoryValues.Add(new MemoryValue("Unknown Cheat 1", 0x0031D970, "Int8", "Cheats Visual", "Cop Heli follows player?"));
            memoryValues.Add(new MemoryValue("Unknown Cheat 2", 0x0031D9A8, "Int8", "Cheats Visual", "Unknown effect"));
            memoryValues.Add(new MemoryValue("Unknown Cheat 3", 0x0031D9E0, "Int8", "Cheats Visual", "Unknown effect"));
            memoryValues.Add(new MemoryValue("Chrome Paint Cheat", 0x0031DA18, "Int8", "Cheats Visual", "Chrome paint unlock"));

            // Cheat Flags - Cars
            memoryValues.Add(new MemoryValue("McLaren F1 Cheat", 0x0031DA50, "Int8", "Cheats Cars", "McLaren F1 unlock"));
            memoryValues.Add(new MemoryValue("McLaren F1 NFS Cheat", 0x0031DA88, "Int8", "Cheats Cars", "McLaren F1 NFS unlock"));
            memoryValues.Add(new MemoryValue("McLaren F1 LM Cheat", 0x0031DAC0, "Int8", "Cheats Cars", "McLaren F1 LM unlock"));
            memoryValues.Add(new MemoryValue("McLaren F1 LM NFS Cheat", 0x0031DAF8, "Int8", "Cheats Cars", "McLaren F1 LM NFS unlock"));
            memoryValues.Add(new MemoryValue("Mercedes CLK GTR Cheat", 0x0031DB30, "Int8", "Cheats Cars", "CLK GTR unlock"));
            memoryValues.Add(new MemoryValue("Mercedes CLK GTR NFS Cheat", 0x0031DB68, "Int8", "Cheats Cars", "CLK GTR NFS unlock"));
            memoryValues.Add(new MemoryValue("Corvette Z06 Cheat", 0x0031DBA0, "Int8", "Cheats Cars", "Corvette Z06 unlock"));
            memoryValues.Add(new MemoryValue("Corvette Z06 NFS Cheat", 0x0031DBD8, "Int8", "Cheats Cars", "Corvette Z06 NFS unlock"));
            memoryValues.Add(new MemoryValue("Dodge Viper GTS NFS Cheat", 0x0031DC10, "Int8", "Cheats Cars", "Viper GTS NFS unlock"));
            memoryValues.Add(new MemoryValue("Ferrari F50 Cheat", 0x0031DC48, "Int8", "Cheats Cars", "Ferrari F50 unlock"));
            memoryValues.Add(new MemoryValue("Ferrari F50 NFS Cheat", 0x0031DC80, "Int8", "Cheats Cars", "Ferrari F50 NFS unlock"));
            memoryValues.Add(new MemoryValue("Lambo Diablo Cheat", 0x0031DCB8, "Int8", "Cheats Cars", "Lamborghini Diablo unlock"));
            memoryValues.Add(new MemoryValue("Lambo Diablo NFS Cheat", 0x0031DCF0, "Int8", "Cheats Cars", "Lamborghini Diablo NFS unlock"));
            memoryValues.Add(new MemoryValue("Lambo Murciélago Cheat", 0x0031DD28, "Int8", "Cheats Cars", "Lamborghini Murciélago unlock"));
            memoryValues.Add(new MemoryValue("Lambo Murciélago NFS Cheat", 0x0031DD60, "Int8", "Cheats Cars", "Lamborghini Murciélago NFS unlock"));
            memoryValues.Add(new MemoryValue("Porsche 911 NFS Cheat", 0x0031DD98, "Int8", "Cheats Cars", "Porsche 911 NFS unlock"));
            memoryValues.Add(new MemoryValue("Porsche Carrera GT Cheat", 0x0031DDD0, "Int8", "Cheats Cars", "Porsche Carrera GT unlock"));
            memoryValues.Add(new MemoryValue("Porsche Carrera GT NFS Cheat", 0x0031DE08, "Int8", "Cheats Cars", "Porsche Carrera GT NFS unlock"));
            memoryValues.Add(new MemoryValue("Aston Martin V12 Cheat", 0x0031DE40, "Int8", "Cheats Cars", "Aston Martin V12 unlock"));
            memoryValues.Add(new MemoryValue("Aston Martin V12 NFS Cheat", 0x0031DE78, "Int8", "Cheats Cars", "Aston Martin V12 NFS unlock"));
            memoryValues.Add(new MemoryValue("BMW Z8 Cheat", 0x0031DEB0, "Int8", "Cheats Cars", "BMW Z8 unlock"));
            memoryValues.Add(new MemoryValue("Ferrari 360 NFS Cheat", 0x0031DEE8, "Int8", "Cheats Cars", "Ferrari 360 NFS unlock"));
            memoryValues.Add(new MemoryValue("Ferrari 360 Spider Cheat", 0x0031DF20, "Int8", "Cheats Cars", "Ferrari 360 Spider unlock"));
            memoryValues.Add(new MemoryValue("Ferrari 550 Cheat", 0x0031DF58, "Int8", "Cheats Cars", "Ferrari 550 unlock"));
            memoryValues.Add(new MemoryValue("Ferrari 550 NFS Cheat", 0x0031DF90, "Int8", "Cheats Cars", "Ferrari 550 NFS unlock"));
            memoryValues.Add(new MemoryValue("Ford Mustang Cobra R NFS Cheat", 0x0031DFC8, "Int8", "Cheats Cars", "Mustang Cobra R NFS unlock"));
            memoryValues.Add(new MemoryValue("HSV Cheat", 0x0031E000, "Int8", "Cheats Cars", "HSV unlock"));
            memoryValues.Add(new MemoryValue("HSV NFS Cheat", 0x0031E038, "Int8", "Cheats Cars", "HSV NFS unlock"));
            memoryValues.Add(new MemoryValue("Jaguar XKR NFS Cheat", 0x0031E070, "Int8", "Cheats Cars", "Jaguar XKR NFS unlock"));
            memoryValues.Add(new MemoryValue("Ford TS50 Cheat", 0x0031E0A8, "Int8", "Cheats Cars", "Ford TS50 unlock"));
            memoryValues.Add(new MemoryValue("Ford TS50 NFS Cheat", 0x0031E0E0, "Int8", "Cheats Cars", "Ford TS50 NFS unlock"));
            memoryValues.Add(new MemoryValue("Lotus Elise Cheat", 0x0031E118, "Int8", "Cheats Cars", "Lotus Elise unlock"));
            memoryValues.Add(new MemoryValue("Lotus Elise NFS Cheat", 0x0031E150, "Int8", "Cheats Cars", "Lotus Elise NFS unlock"));
            memoryValues.Add(new MemoryValue("Mercedes CL55 Cheat", 0x0031E188, "Int8", "Cheats Cars", "Mercedes CL55 unlock"));
            memoryValues.Add(new MemoryValue("Mercedes CL55 NFS Cheat", 0x0031E1C0, "Int8", "Cheats Cars", "Mercedes CL55 NFS unlock"));
            memoryValues.Add(new MemoryValue("Opel Speedster NFS Cheat", 0x0031E1F8, "Int8", "Cheats Cars", "Opel Speedster NFS unlock"));
            memoryValues.Add(new MemoryValue("Vauxhall VX 220 NFS Cheat", 0x0031E230, "Int8", "Cheats Cars", "Vauxhall VX 220 NFS unlock"));

            // Cheat Flags - Cop Cars
            memoryValues.Add(new MemoryValue("Corvette Z06 YTC Cop Cheat", 0x0031E268, "Int8", "Cheats Cops", "Corvette Z06 YTC cop unlock"));
            memoryValues.Add(new MemoryValue("Corvette Z06 Cop Cheat", 0x0031E2A0, "Int8", "Cheats Cops", "Corvette Z06 cop unlock"));
            memoryValues.Add(new MemoryValue("Lambo Murciélago Cop YTC Cheat", 0x0031E2D8, "Int8", "Cheats Cops", "Lamborghini Murciélago cop YTC unlock"));
            memoryValues.Add(new MemoryValue("Lambo Murciélago Cop Cheat", 0x0031E310, "Int8", "Cheats Cops", "Lamborghini Murciélago cop Challenge unlock"));
            memoryValues.Add(new MemoryValue("Mustang Cobra R Cop YTC Cheat", 0x0031E348, "Int8", "Cheats Cops", "Mustang Cobra R cop YTC unlock"));
            memoryValues.Add(new MemoryValue("Mustang Cobra R Cop Cheat", 0x0031E380, "Int8", "Cheats Cops", "Mustang Cobra R cop Challenge unlock"));
            memoryValues.Add(new MemoryValue("BMW M5 Cop YTC Cheat", 0x0031E3B8, "Int8", "Cheats Cops", "BMW M5 cop YTC unlock"));
            memoryValues.Add(new MemoryValue("BMW M5 Cop Cheat", 0x0031E3F0, "Int8", "Cheats Cops", "BMW M5 cop Challenge unlock"));
            memoryValues.Add(new MemoryValue("Ford Crown Victoria Cheat", 0x0031E428, "Int8", "Cheats Cops", "Ford Crown Victoria Challenge unlock"));

            // Cheat Flags - Tracks
            memoryValues.Add(new MemoryValue("Coastal Parklands II Cheat", 0x0031E460, "Int8", "Cheats Tracks", "CP II unlock"));
            memoryValues.Add(new MemoryValue("National Forest Cheat", 0x0031E498, "Int8", "Cheats Tracks", "NF unlock"));
            memoryValues.Add(new MemoryValue("National Forest II Cheat", 0x0031E4D0, "Int8", "Cheats Tracks", "NF II unlock"));
            memoryValues.Add(new MemoryValue("Scenic Drive II Cheat", 0x0031E508, "Int8", "Cheats Tracks", "SD II unlock"));
            memoryValues.Add(new MemoryValue("Desert Heat II Cheat", 0x0031E540, "Int8", "Cheats Tracks", "DH II unlock"));
            memoryValues.Add(new MemoryValue("Outback Cheat", 0x0031E578, "Int8", "Cheats Tracks", "OB unlock"));
            memoryValues.Add(new MemoryValue("Outback II Cheat", 0x0031E5B0, "Int8", "Cheats Tracks", "OB II unlock"));
            memoryValues.Add(new MemoryValue("Rocky Canyons Cheat", 0x0031E5E8, "Int8", "Cheats Tracks", "RC unlock"));
            memoryValues.Add(new MemoryValue("Rocky Canyons II Cheat", 0x0031E620, "Int8", "Cheats Tracks", "RC II unlock"));
            memoryValues.Add(new MemoryValue("Ancient Ruins II Cheat", 0x0031E658, "Int8", "Cheats Tracks", "AR II unlock"));
            memoryValues.Add(new MemoryValue("Calypso Coast Cheat", 0x0031E690, "Int8", "Cheats Tracks", "CC unlock"));
            memoryValues.Add(new MemoryValue("Calypso Coast II Cheat", 0x0031E6C8, "Int8", "Cheats Tracks", "CC II unlock"));
            memoryValues.Add(new MemoryValue("Mediterranean II Cheat", 0x0031E700, "Int8", "Cheats Tracks", "MED II unlock"));
            memoryValues.Add(new MemoryValue("Fall Winds II Cheat", 0x0031E738, "Int8", "Cheats Tracks", "FW II unlock"));
            memoryValues.Add(new MemoryValue("Alpine Trail Cheat", 0x0031E770, "Int8", "Cheats Tracks", "AT unlock"));
            memoryValues.Add(new MemoryValue("Alpine Trail II Cheat", 0x0031E7A8, "Int8", "Cheats Tracks", "AT II unlock"));
            memoryValues.Add(new MemoryValue("Autumn Crossing Cheat", 0x0031E7E0, "Int8", "Cheats Tracks", "AC unlock"));
            memoryValues.Add(new MemoryValue("Autumn Crossing II Cheat", 0x0031E818, "Int8", "Cheats Tracks", "AC II unlock"));
            memoryValues.Add(new MemoryValue("Island Outskirts II Cheat", 0x0031E850, "Int8", "Cheats Tracks", "IO II unlock"));
            memoryValues.Add(new MemoryValue("Palm City Island Cheat", 0x0031E888, "Int8", "Cheats Tracks", "PCI unlock"));
            memoryValues.Add(new MemoryValue("Palm City Island II Cheat", 0x0031E8C0, "Int8", "Cheats Tracks", "PCI II unlock"));
            memoryValues.Add(new MemoryValue("Tropical Circuit Cheat", 0x0031E8F8, "Int8", "Cheats Tracks", "TC unlock"));
            memoryValues.Add(new MemoryValue("Tropical Circuit II Cheat", 0x0031E930, "Int8", "Cheats Tracks", "TC II unlock"));

            // Pointers
            memoryValues.Add(new MemoryValue("Driven Distance Pointer", 0x002C84BC, "Int32", "Pointers", "+0x3A8=[Float] Driven Distance"));
            memoryValues.Add(new MemoryValue("Player Car Info Pointer", 0x002C966C, "Int32", "Pointers", "+0x78=[32bit] Player Camera (0=Bumper,1=Far,2=Close,3=Cockpit)"));
            memoryValues.Add(new MemoryValue("Car Nebula Menu Pointer", 0x002F96E0, "Int32", "Pointers", "Pointer to car selection menu",
@"+0x00 = [32bit Pointer] Selected Car
  +0x0C = Selected Car ID
  +0x10 = Car Unlock Flag
  +0x14 = Car Paint Color"));
            memoryValues.Add(new MemoryValue("Misc Car Data Pointer", 0x002F96EC, "Int32", "Pointers", "+0x220=Gear(0=R,1=N,2-7=1-6), +0x228=Turbo"));
            memoryValues.Add(new MemoryValue("Car RPM Pointer", 0x0032FFCC, "Int32", "Pointers", "+0x3C=[Float] Car RPM"));
            memoryValues.Add(new MemoryValue("Race Progress Info Pointer", 0x003301F0, "Int32", "Pointers", "Race progress data",
@"+0x00 = [8bit] Race Startup
  0x01 = Scenery Cutscene
  0x02 = Pre-Countdown Cutscene
  0x03 = Race Countdown
  0x04 = Race Start
+0x10 = [32bit] Total Race Time (÷40 for milliseconds)
+0x14 = [32bit] Last Lap Time
+0x1C = [8bit][YTC] Total Busted Racers
+0x2C = [8bit] Current Lap (Player)
+0x2D = [8bit] Current Full Laps (Player)
+0x2F = [8bit] Current Race Position
+0x30 = [8bit] Finished Position (locks position if >0)
+0x36 = [8bit] Racer State
  0x00 = Racing, 0x01 = Finished
  0x02 = Arrested, 0x03 = Eliminated
  0x04 = YTC Win Msg
+0x84 = [32bit] Track Best Time (resets when not in-race)
+0xF0/+0x1B0/+0x270/+0x330/+0x3F0/+0x4B0/+0x570 = AI Finished Positions"));
            memoryValues.Add(new MemoryValue("In Race Options Pointer", 0x00330728, "Int32", "Pointers", "In-race options & stats",
@"+0x21 = [8bit] Vibration
+0x22 = [8bit] Handling (0=Classic, 1=Extreme)
+0x23 = [8bit] Transmission (0=Auto, 1=Manual, 2=Semi-Auto)
+0x26 = [8bit] Split time
+0x34 = [32bit] Player Name ASCII
+0x58 = [32bit] Zone Cam Flag (1=Spin, 2=Fireball)
+0xB4 = [Float] Car Speed Alt
+0xC4 = [32bit] Inrace Menu Flag
  0x01 = Paused, 0x02 = Racing
  0x06 = Game Over, 0x07 = Viewing Replay
+0x450 = [32bit] Heat Level
+0x5F4 = [32bit] In Race NFS Points
+0x5F8 = [32bit] Player Active Car Control
+0x654 = [32bit] Player Race Position
+0x658 = [32bit] Player Speed"));
            memoryValues.Add(new MemoryValue("In Race Options Pointer Alt", 0x00330730, "Int32", "Pointers", "Same structure as 0x00330728"));
            memoryValues.Add(new MemoryValue("Audio Menu Pointer", 0x003316F8, "Int32", "Pointers", "Audio menu data",
@"+0x64 = [Float] Menu Music
+0x68 = [Float] Racing Music
+0x6C = [Float] Ambient SFX
+0x70 = [Float] Tire SFX
+0x74 = [Float] Engine SFX
+0x78 = [Float] Menu SFX
+0x7C = [Float] Speech SFX
+0x110 = [8bit] Audio Mode"));
            memoryValues.Add(new MemoryValue("Cop AI Pointer", 0x00331BD8, "Int32", "Pointers", "Cop AI array",
@"+0x18 = Cop mode state (0x02 = Player is Cop)
+0x20 = [HP Mode flag] Always 0x10 in cop modes
+0xA0 = [32bit] Cop AI State (this cop only)"));
            memoryValues.Add(new MemoryValue("HP/YTC Stats Pointer", 0x00331BEC, "Int32", "Pointers", "Hot Pursuit/YTC stats",
@"+0x00 = [8bit][YTC] Road Block Count
+0x60 = [8bit] Busted Strikes
+0x64 = [32bit] Viewing Busted cutscene flag
+0x6C = [32bit] Viewing Arrested cutscene flag
+0x7C = [8bit] YTC P2 Busted Strikes?
+0x28F0 = [Float][YTC] Time Left
+0x28FC = [8bit][YTC] Heli Count
+0x2900 = [8bit][YTC] Total Busted Racers"));
            memoryValues.Add(new MemoryValue("P1 Controller Config Pointer", 0x00331D90, "Int32", "Pointers", "+0x04=P1 Controller Config"));
            memoryValues.Add(new MemoryValue("Points Pointer", 0x0032FC78, "Int32", "Pointers", "+0x9134=Points Earned, +0x9198=Speed, +0x1E760=Strikes"));

            // Debug Menu Flags
            memoryValues.Add(new MemoryValue("DEBUG - ENV Mapping", 0x003306A0, "Int8", "Debug", "Environment mapping flag"));
            memoryValues.Add(new MemoryValue("DEBUG - Car Collision", 0x003306A4, "Int8", "Debug", "Car to car collision flag"));
            memoryValues.Add(new MemoryValue("DEBUG - Show Info", 0x00330814, "Int8", "Debug", "Show debug info flag"));
            memoryValues.Add(new MemoryValue("DEBUG - Super Easy AI", 0x00330A58, "Int8", "Debug", "0x00=Off, 0x01=On"));

            // In-Race Addresses
            memoryValues.Add(new MemoryValue("Inrace Menu Flag", 0x0082B5A4, "Int32", "In Race", "0x01=Paused, 0x02=Racing, 0x06=Race Over, 0x07=Replay"));
            memoryValues.Add(new MemoryValue("Current Strikes", 0x008E9D20, "Int32", "In Race", "Busted strikes"));
            memoryValues.Add(new MemoryValue("Player Active Car Control", 0x00DC6BF8, "Int32", "In Race", "0x00 = Paused or in zone cam while race active"));
            memoryValues.Add(new MemoryValue("Busted Strikes Alt", 0x003348E0, "Int8", "In Race", "Busted strikes alt"));

            return memoryValues;
        }
    }
}
