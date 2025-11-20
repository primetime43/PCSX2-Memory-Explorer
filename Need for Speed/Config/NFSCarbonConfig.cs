using Common;
using System.Collections.Generic;

namespace Need_for_Speed.Config
{
    public class NFSCarbonConfig : IGameMemoryConfig
    {
        public string GameName => "Need for Speed: Carbon - Collectors Edition (PS2)";

        public List<MemoryValue> GetMemoryValues()
        {
            var memoryValues = new List<MemoryValue>();

            // Game State & Menu
            memoryValues.Add(new MemoryValue("Ingame Check", 0x0060A6F0, "Int32", "Game State", "0x00=Not Ingame, 0x01=Single Player, 0x02=Split Screen"));
            memoryValues.Add(new MemoryValue("Pause Flag", 0x00612010, "Int8", "Game State", "0x01=Paused"));
            memoryValues.Add(new MemoryValue("Menu State", 0x00645CD8, "Int32", "Game State", "0x136e3c13=File Select, 0xbadf298d=Main Menu"));
            memoryValues.Add(new MemoryValue("Main Menu Selection", 0x00645CDC, "Int32", "Game State", "0x00=Career, 0x01=My Cars, 0x02=Challenge, 0x03=Quick Race, 0x04=Rewards, 0x05=Stats, 0x06=Options"));
            memoryValues.Add(new MemoryValue("Menu 2", 0x00645CE4, "Int32", "Game State", "Secondary menu state"));
            memoryValues.Add(new MemoryValue("Main Menu Selection 2", 0x00645CE8, "Int32", "Game State", "Secondary menu selection"));
            memoryValues.Add(new MemoryValue("Reach Destination Flag", 0x0060A734, "Int32", "Game State", "0x01=Destination reached"));
            memoryValues.Add(new MemoryValue("Reach Destination Pause", 0x0060A764, "Int32", "Game State", "Pause gameplay flag when reaching destination"));
            memoryValues.Add(new MemoryValue("Using Memory Card", 0x00AF0FD4, "Int8", "Game State", "0x01=Using memory card"));
            memoryValues.Add(new MemoryValue("Accessing Memory Card", 0x00AF20EC, "Int32", "Game State", "0x01=Accessing memory card"));

            // Pursuit System
            memoryValues.Add(new MemoryValue("Current Heat Level", 0x005E058C, "Float", "Pursuit", "Current heat level"));
            memoryValues.Add(new MemoryValue("In Pursuit", 0x005E0594, "Int8", "Pursuit", "0x01=In pursuit"));
            memoryValues.Add(new MemoryValue("Pursuit State", 0x00604520, "Int32", "Pursuit", "0x00=None, 0x01=Normal, 0x02=Race, 0x03=Post-Race"));
            memoryValues.Add(new MemoryValue("Pursuit Pointer 1", 0x00604528, "Int32", "Pursuit", "Pointer (+0x140=Timer, +0x1d0=Units, +0x1d4=Disabled, +0x1f0=Roadblocks)"));
            memoryValues.Add(new MemoryValue("Pursuit Pointer 2", 0x0060452C, "Int32", "Pursuit", "Pointer (+0x140=Timer, +0x1d0=Units, +0x1d4=Disabled, +0x1f0=Roadblocks, +0x1f8=Rammed, +0x20c=Spikes, +0x214=Cost, +0x284=State)"));
            memoryValues.Add(new MemoryValue("Pursuit Timer", 0x01FA3A60, "Int32", "Pursuit", "Pursuit duration timer"));

            // Player Position & Rotation
            memoryValues.Add(new MemoryValue("Coordinate X", 0x0064D550, "Float", "Position", "Player X coordinate"));
            memoryValues.Add(new MemoryValue("Coordinate Y", 0x0064D554, "Float", "Position", "Player Y coordinate"));
            memoryValues.Add(new MemoryValue("Coordinate Z", 0x0064D558, "Float", "Position", "Player Z coordinate"));
            memoryValues.Add(new MemoryValue("X Rotation", 0x0064D544, "Int32", "Position", "Player X rotation"));
            memoryValues.Add(new MemoryValue("Y Rotation", 0x0064D548, "Int32", "Position", "Player Y rotation"));
            memoryValues.Add(new MemoryValue("Z Rotation", 0x0064D54C, "Int32", "Position", "Player Z rotation"));

            // Current Car & Area
            memoryValues.Add(new MemoryValue("Current Car ID Pointer", 0x006870D8, "Int32", "Current Car", "Pointer (+0x00) to current car ID (see notes for full list)"));
            memoryValues.Add(new MemoryValue("Current Area", 0x00647B58, "Int32", "Current Car", "Current area ID"));
            memoryValues.Add(new MemoryValue("Current Area Popup", 0x01B0EF08, "Int32", "Current Car", "Area popup trigger"));

            // Race Data
            memoryValues.Add(new MemoryValue("Race Data Pointer", 0x00647760, "Int32", "Race Data", "Main race data pointer (see notes for extensive offsets)"));
            memoryValues.Add(new MemoryValue("Current Track ASCII", 0x009F11BC, "Int64", "Race Data", "8-byte ASCII current track ID"));
            memoryValues.Add(new MemoryValue("Current Event ID", 0x01C7D9E0, "Int32", "Race Data", "Selected event ID"));
            memoryValues.Add(new MemoryValue("Races Quit", 0x00648F34, "Int32", "Race Data", "Number of races quit"));

            // Drift System
            memoryValues.Add(new MemoryValue("Drift Pointer", 0x0064583C, "Int32", "Drift", "Pointer (+0x184=Multiplier, +0x418=ASCII score)"));
            memoryValues.Add(new MemoryValue("Drift Score", 0x01F36340, "Int32", "Drift", "Current drift score"));
            memoryValues.Add(new MemoryValue("Last Drift Score", 0x01F36350, "Int32", "Drift", "Score of last completed drift"));
            memoryValues.Add(new MemoryValue("Drifts Ended by Wall", 0x01F36360, "Int32", "Drift", "Drifts ended by hitting wall"));
            memoryValues.Add(new MemoryValue("Total Drifts", 0x01F36364, "Int32", "Drift", "Total number of drifts"));

            // Career Progress
            memoryValues.Add(new MemoryValue("Player Name", 0x00A4A5B0, "Int64", "Career", "6-byte ASCII player name"));
            memoryValues.Add(new MemoryValue("Crew Name", 0x00A6E8D8, "Int64", "Career", "15-byte ASCII crew name"));
            memoryValues.Add(new MemoryValue("Crew Logo", 0x00A6E8B4, "Int32", "Career", "Crew logo ID"));
            memoryValues.Add(new MemoryValue("Crew Logo Color", 0x00A6E8B8, "Int32", "Career", "Crew logo color (if custom)"));
            memoryValues.Add(new MemoryValue("Starting Class", 0x00A6E8E7, "Int8", "Career", "0x01=Exotic, 0x02=Muscle, 0x03=Tuner"));
            memoryValues.Add(new MemoryValue("Starting Class Actual", 0x01B11998, "Int32", "Career", "0x01=Exotic, 0x02=Muscle, 0x03=Tuner"));
            memoryValues.Add(new MemoryValue("Cash Money", 0x00A6E8F4, "Int32", "Career", "Current cash"));
            memoryValues.Add(new MemoryValue("Reputation", 0x00A6E8F8, "Int32", "Career", "Current reputation"));
            memoryValues.Add(new MemoryValue("Story Flags", 0x00A6E8EC, "Int32", "Career", "bit0=Tutorial, bit1=Intro"));
            memoryValues.Add(new MemoryValue("Story Progress", 0x00A6EB56, "Int32", "Career", "Current story progress"));

            // Career Statistics
            memoryValues.Add(new MemoryValue("Career Races Won", 0x00A6EBC4, "Int32", "Career Stats", "Total career races won"));
            memoryValues.Add(new MemoryValue("Career Races Lost", 0x00A6EBC8, "Int32", "Career Stats", "Total career races lost"));
            memoryValues.Add(new MemoryValue("Random Encounters Won", 0x00A6EBD4, "Int32", "Career Stats", "Random encounters won"));
            memoryValues.Add(new MemoryValue("Quick Race Wins", 0x00A6EBDC, "Int32", "Career Stats", "Number of quick race wins"));
            memoryValues.Add(new MemoryValue("Races Lost (Total)", 0x00A6EBE0, "Int32", "Career Stats", "Total races lost"));
            memoryValues.Add(new MemoryValue("Total Cash Earned", 0x00A6EBF4, "Int32", "Career Stats", "Total cash earned"));
            memoryValues.Add(new MemoryValue("Cars Sold", 0x00A6EBF8, "Int32", "Career Stats", "Number of cars sold"));
            memoryValues.Add(new MemoryValue("Cars Purchased", 0x00A6EBFC, "Int32", "Career Stats", "Number of cars purchased"));
            memoryValues.Add(new MemoryValue("Best Jump Air Time", 0x00A6EC04, "Int32", "Career Stats", "Best jump air time"));
            memoryValues.Add(new MemoryValue("Crew Members Hired", 0x00A6EC0C, "Int32", "Career Stats", "Total crew members hired"));
            memoryValues.Add(new MemoryValue("Defensive Races Won", 0x00A48034, "Int32", "Career Stats", "Defensive races won"));

            // Pursuit Statistics
            memoryValues.Add(new MemoryValue("Pursuits Evaded", 0x00A6EC10, "Int32", "Pursuit Stats", "Total pursuits evaded"));
            memoryValues.Add(new MemoryValue("Times Busted", 0x00A6EC14, "Int32", "Pursuit Stats", "Total times busted"));
            memoryValues.Add(new MemoryValue("Longest Pursuit", 0x00A6EC18, "Int32", "Pursuit Stats", "Longest pursuit time"));
            memoryValues.Add(new MemoryValue("Spike Strips Dodged (Single)", 0x00A6EC20, "Int32", "Pursuit Stats", "Single pursuit spike strips"));
            memoryValues.Add(new MemoryValue("Spike Strips Dodged (Total)", 0x00A6EC24, "Int32", "Pursuit Stats", "Total spike strips dodged"));
            memoryValues.Add(new MemoryValue("Roadblocks Dodged (Single)", 0x00A6EC28, "Int32", "Pursuit Stats", "Single pursuit roadblocks"));
            memoryValues.Add(new MemoryValue("Roadblocks Dodged (Total)", 0x00A6EC2C, "Int32", "Pursuit Stats", "Total roadblocks dodged"));
            memoryValues.Add(new MemoryValue("Cops Rammed (Single)", 0x00A6EC30, "Int32", "Pursuit Stats", "Single pursuit cops rammed"));
            memoryValues.Add(new MemoryValue("Cops Rammed (Total)", 0x00A6EC34, "Int32", "Pursuit Stats", "Total cops rammed"));
            memoryValues.Add(new MemoryValue("Cops Disabled (Single)", 0x00A6EC38, "Int32", "Pursuit Stats", "Single pursuit cops disabled"));
            memoryValues.Add(new MemoryValue("Cops Disabled (Total)", 0x00A6EC3C, "Int32", "Pursuit Stats", "Total cops disabled"));
            memoryValues.Add(new MemoryValue("Bounty (Single)", 0x00A6EC40, "Int32", "Pursuit Stats", "Single pursuit bounty"));
            memoryValues.Add(new MemoryValue("Bounty (Total)", 0x00A6EC44, "Int32", "Pursuit Stats", "Total bounty"));
            memoryValues.Add(new MemoryValue("Cost to State (Single)", 0x00A6EC48, "Int32", "Pursuit Stats", "Single pursuit cost"));
            memoryValues.Add(new MemoryValue("Cost to State (Total)", 0x00A6EC4C, "Int32", "Pursuit Stats", "Total cost to state"));
            memoryValues.Add(new MemoryValue("Infractions (Single)", 0x00A6EC50, "Int32", "Pursuit Stats", "Single pursuit infractions"));
            memoryValues.Add(new MemoryValue("Infractions (Total)", 0x00A6EC54, "Int32", "Pursuit Stats", "Total infractions"));
            memoryValues.Add(new MemoryValue("Infractions This Pursuit", 0x00A70B6C, "Int32", "Pursuit Stats", "Current pursuit infractions"));
            memoryValues.Add(new MemoryValue("Cost This Pursuit", 0x00A70B70, "Int32", "Pursuit Stats", "Current pursuit cost"));
            memoryValues.Add(new MemoryValue("Highest Clocked Speedtrap", 0x00A6EC58, "Int32", "Pursuit Stats", "Highest speedtrap speed"));
            memoryValues.Add(new MemoryValue("Total Clocked Speedtrap", 0x00A6EC5C, "Int32", "Pursuit Stats", "Total speedtrap readings"));
            memoryValues.Add(new MemoryValue("Highest Heat Level", 0x00A6EC60, "Int32", "Pursuit Stats", "Highest heat level achieved"));
            memoryValues.Add(new MemoryValue("Highest Fine Paid", 0x00A6EC64, "Int32", "Pursuit Stats", "Highest fine paid"));

            // Reward Markers
            memoryValues.Add(new MemoryValue("Reward Marker 1 ID", 0x00979A04, "Int32", "Reward Markers", "Marker 1 ID (see notes for types)"));
            memoryValues.Add(new MemoryValue("Reward Marker 1 Reward ID", 0x00979A08, "Int32", "Reward Markers", "Marker 1 reward ID"));
            memoryValues.Add(new MemoryValue("Reward Marker 1 Selected", 0x00979A0C, "Int32", "Reward Markers", "Marker 1 selected"));
            memoryValues.Add(new MemoryValue("Reward Marker 2 ID", 0x00979A10, "Int32", "Reward Markers", "Marker 2 ID"));
            memoryValues.Add(new MemoryValue("Reward Marker 2 Reward ID", 0x00979A14, "Int32", "Reward Markers", "Marker 2 reward ID"));
            memoryValues.Add(new MemoryValue("Reward Marker 2 Selected", 0x00979A18, "Int32", "Reward Markers", "Marker 2 selected"));
            memoryValues.Add(new MemoryValue("Reward Marker 3 ID", 0x00979A1C, "Int32", "Reward Markers", "Marker 3 ID"));
            memoryValues.Add(new MemoryValue("Reward Marker 3 Reward ID", 0x00979A20, "Int32", "Reward Markers", "Marker 3 reward ID"));
            memoryValues.Add(new MemoryValue("Reward Marker 3 Selected", 0x00979A24, "Int32", "Reward Markers", "Marker 3 selected"));
            memoryValues.Add(new MemoryValue("Reward Marker 4 ID", 0x00979A28, "Int32", "Reward Markers", "Marker 4 ID"));
            memoryValues.Add(new MemoryValue("Reward Marker 4 Reward ID", 0x00979A2C, "Int32", "Reward Markers", "Marker 4 reward ID"));
            memoryValues.Add(new MemoryValue("Reward Marker 4 Selected", 0x00979A30, "Int32", "Reward Markers", "Marker 4 selected"));
            memoryValues.Add(new MemoryValue("Reward Marker 5 ID", 0x00979A34, "Int32", "Reward Markers", "Marker 5 ID"));
            memoryValues.Add(new MemoryValue("Reward Marker 5 Reward ID", 0x00979A38, "Int32", "Reward Markers", "Marker 5 reward ID"));
            memoryValues.Add(new MemoryValue("Reward Marker 5 Selected", 0x00979A3C, "Int32", "Reward Markers", "Marker 5 selected"));
            memoryValues.Add(new MemoryValue("Reward Marker 6 ID", 0x00979A40, "Int32", "Reward Markers", "Marker 6 ID"));
            memoryValues.Add(new MemoryValue("Reward Marker 6 Reward ID", 0x00979A44, "Int32", "Reward Markers", "Marker 6 reward ID"));
            memoryValues.Add(new MemoryValue("Reward Marker 6 Selected", 0x00979A48, "Int32", "Reward Markers", "Marker 6 selected"));

            // Reward Cards (Sample - there are 100+ reward cards)
            memoryValues.Add(new MemoryValue("Reward Card - First Blood", 0x00A4814C, "Int32", "Reward Cards", "First Blood reward card"));
            memoryValues.Add(new MemoryValue("Reward Card - Street Racer", 0x00A4815C, "Int32", "Reward Cards", "Street Racer reward card"));
            memoryValues.Add(new MemoryValue("Reward Card - Street King", 0x00A48194, "Int32", "Reward Cards", "Street King reward card"));
            memoryValues.Add(new MemoryValue("Reward Card - Getaway", 0x00A4819C, "Int32", "Reward Cards", "Getaway reward card"));
            memoryValues.Add(new MemoryValue("Reward Card - Career Mogul", 0x00A481E4, "Int32", "Reward Cards", "Career Mogul reward card"));
            memoryValues.Add(new MemoryValue("Reward Card - Street Legend", 0x00A4822C, "Int32", "Reward Cards", "Street Legend reward card"));
            memoryValues.Add(new MemoryValue("Reward Card - Challenge Champion", 0x00A4825C, "Int32", "Reward Cards", "Challenge Champion reward card"));
            memoryValues.Add(new MemoryValue("Reward Card - Most Wanted", 0x00A4840C, "Int32", "Reward Cards", "Most Wanted reward card"));

            // Car Impound Strikes
            memoryValues.Add(new MemoryValue("Career Car 1 Impound Strikes", 0x00A60446, "Int8", "Impound", "Car 1 impound strikes"));
            memoryValues.Add(new MemoryValue("Career Car 2 Impound Strikes", 0x00A6047A, "Int8", "Impound", "Car 2 impound strikes"));
            memoryValues.Add(new MemoryValue("Career Car 3 Impound Strikes", 0x00A604AE, "Int8", "Impound", "Car 3 impound strikes"));
            memoryValues.Add(new MemoryValue("Career Car 4 Impound Strikes", 0x00A604E2, "Int8", "Impound", "Car 4 impound strikes"));
            memoryValues.Add(new MemoryValue("Career Car 5 Impound Strikes", 0x00A60516, "Int8", "Impound", "Car 5 impound strikes"));

            // Settings
            memoryValues.Add(new MemoryValue("Widescreen Flag", 0x00A6E794, "Int32", "Settings", "Widescreen mode"));
            memoryValues.Add(new MemoryValue("Auto Save Flag", 0x00A6E7A8, "Int32", "Settings", "Auto save enabled"));
            memoryValues.Add(new MemoryValue("Rearview Mirror Flag", 0x00A6E7AC, "Int32", "Settings", "Rearview mirror enabled"));
            memoryValues.Add(new MemoryValue("Car Damage Flag", 0x00A6E7B4, "Int32", "Settings", "Car damage enabled"));
            memoryValues.Add(new MemoryValue("Units", 0x00A6E7B8, "Int8", "Settings", "0x00=Imperial, 0x01=Metric"));
            memoryValues.Add(new MemoryValue("Race Map Mode", 0x00A6E7B9, "Int8", "Settings", "0x00=Static, 0x01=Rotate, 0x02=Off"));
            memoryValues.Add(new MemoryValue("Free Roam Map Mode", 0x00A6E7BA, "Int8", "Settings", "0x00=Static, 0x01=Rotate, 0x02=Off"));
            memoryValues.Add(new MemoryValue("Game Moments Camera", 0x00A6E7CC, "Int32", "Settings", "Game moments camera setting"));
            memoryValues.Add(new MemoryValue("Gauges Flag", 0x00A6E82C, "Int32", "Settings", "Gauges display"));
            memoryValues.Add(new MemoryValue("Score Flag", 0x00A6E838, "Int32", "Settings", "Score display"));
            memoryValues.Add(new MemoryValue("Leaderboard Flag", 0x00A6E840, "Int32", "Settings", "Leaderboard display"));
            memoryValues.Add(new MemoryValue("Crew Info Flag", 0x00A6E844, "Int32", "Settings", "Crew info display"));
            memoryValues.Add(new MemoryValue("Car Camera", 0x00A6E854, "Int32", "Settings", "0x00=Bumper, 0x01=Hood, 0x02=Close, 0x03=Far"));
            memoryValues.Add(new MemoryValue("Split Time Flag", 0x00A6E858, "Int8", "Settings", "Split time display"));
            memoryValues.Add(new MemoryValue("Transmission Mode", 0x00A6E859, "Int8", "Settings", "0x00=Automatic, 0x01=Manual"));

            // Audio Settings
            memoryValues.Add(new MemoryValue("Speech Volume", 0x00A6E7E8, "Float", "Audio", "Speech volume level"));
            memoryValues.Add(new MemoryValue("FE Music Volume", 0x00A6E7EC, "Float", "Audio", "Front-end music volume"));
            memoryValues.Add(new MemoryValue("In-Game Music Volume", 0x00A6E7F0, "Float", "Audio", "In-game music volume"));
            memoryValues.Add(new MemoryValue("Sound Effects Volume", 0x00A6E7F4, "Float", "Audio", "Sound effects volume"));
            memoryValues.Add(new MemoryValue("Car Volume", 0x00A6E7FC, "Float", "Audio", "Car sounds volume"));
            memoryValues.Add(new MemoryValue("Audio Mode", 0x00A6E808, "Int32", "Audio", "0x00=Mono, 0x01=Stereo"));
            memoryValues.Add(new MemoryValue("EA TRAX Flag", 0x00A6E810, "Int32", "Audio", "EA TRAX setting"));

            // Quick Race Options
            memoryValues.Add(new MemoryValue("Quick Race - Crew Member", 0x00A70824, "Int32", "Quick Race", "0x00=Off, 0x01=On"));
            memoryValues.Add(new MemoryValue("Quick Race - Selected Crew", 0x00A70870, "Int32", "Quick Race", "Selected crew member ID"));

            // Cheats
            memoryValues.Add(new MemoryValue("Infinite Crew Charge Cheat", 0x0061241C, "Int32", "Cheats", "Infinite crew charge"));
            memoryValues.Add(new MemoryValue("Infinite Nitrous Cheat", 0x00612458, "Int32", "Cheats", "Infinite nitrous"));
            memoryValues.Add(new MemoryValue("Unlimited Speedbreaker Cheat", 0x00612494, "Int32", "Cheats", "Unlimited speedbreaker"));

            // Unlocks Table
            memoryValues.Add(new MemoryValue("Unlocked Item 1 ID", 0x00A48600, "Int32", "Unlocks", "First unlocked item ID"));
            memoryValues.Add(new MemoryValue("Unlocked Item 1 New Flag", 0x00A48604, "Int32", "Unlocks", "0x01=New, 0x00=Seen"));

            // My Cars
            memoryValues.Add(new MemoryValue("My Cars - First Car", 0x00A4B2C4, "Int32", "My Cars", "First car in garage"));
            memoryValues.Add(new MemoryValue("My Cars - First Car Name ID", 0x00A4B2C8, "Int32", "My Cars", "Name ID of first car"));

            // Boss Cars
            memoryValues.Add(new MemoryValue("Boss Car 1 ID", 0x00A55380, "Int32", "Boss Cars", "Boss car 1 ID (0x26=Dodge Charger R/T)"));
            memoryValues.Add(new MemoryValue("Boss Car 1 Engine", 0x00A552F8, "Int16", "Boss Cars", "Boss car 1 engine"));
            memoryValues.Add(new MemoryValue("Boss Car 1 Vinyl 1", 0x00A552C4, "Int32", "Boss Cars", "Boss car 1 vinyl"));
            memoryValues.Add(new MemoryValue("Boss Car 2 ID", 0x00A560D0, "Int32", "Boss Cars", "Boss car 2 ID (0x15=Aston Martin DB9)"));

            // Pointers
            memoryValues.Add(new MemoryValue("Guide Arrow Pointer", 0x0060503C, "Int32", "Pointers", "Pointer (+0xEC) to guide arrow flag"));
            memoryValues.Add(new MemoryValue("P1 Data Pointer", 0x0060A6F8, "Int32", "Pointers", "Player 1 data pointer"));
            memoryValues.Add(new MemoryValue("P2 Data Pointer", 0x0060A6FC, "Int32", "Pointers", "Player 2 data pointer"));
            memoryValues.Add(new MemoryValue("Pause Menu Pointer", 0x01C7D9A0, "Int32", "Pointers", "Pointer (+0x00) to world map state"));
            memoryValues.Add(new MemoryValue("GCareer Pointer", 0x01B11914, "Int32", "Pointers", "Main career data pointer"));
            memoryValues.Add(new MemoryValue("GCareer Pointer 2", 0x01B11910, "Int32", "Pointers", "Secondary career pointer"));
            memoryValues.Add(new MemoryValue("GCrew Pointer", 0x01B11994, "Int32", "Pointers", "Player crew ID pointer"));
            memoryValues.Add(new MemoryValue("Crew Member Pointer", 0x01B119A4, "Int32", "Pointers", "Pointer (+0x00, +0x10) to crew member ID"));

            // Track Statistics (Sample)
            memoryValues.Add(new MemoryValue("Lincoln Blvd - Top Speed", 0x00A6F5E0, "Int32", "Track Stats", "Lincoln Boulevard highest top speed"));
            memoryValues.Add(new MemoryValue("Lincoln Blvd - Times Played", 0x00A6F5E8, "Int32", "Track Stats", "Lincoln Boulevard times played"));
            memoryValues.Add(new MemoryValue("Lincoln Blvd - Best Time", 0x00A6F5EC, "Int32", "Track Stats", "Lincoln Boulevard best race time"));

            return memoryValues;
        }
    }
}
