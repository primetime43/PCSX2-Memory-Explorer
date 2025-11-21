using Common;
using System.Collections.Generic;

namespace Games.NeedForSpeed
{
    public class NFSCarbonConfig : IGameMemoryConfig
    {
        public string GameName => "Need for Speed: Carbon - Collectors Edition (PS2)";

        public List<MemoryValue> GetMemoryValues()
        {
            var memoryValues = new List<MemoryValue>();

            // Game State & Menu
            memoryValues.Add(new MemoryValue("Ingame Check", 0x0060A6F0, "Int32", "Game State", "Current game state",
@"0x00 = Not Ingame
0x01 = Single Player Ingame
0x02 = Split Screen Ingame"));
            memoryValues.Add(new MemoryValue("Pause Flag", 0x00612010, "Int8", "Game State", "0x01=Paused"));
            memoryValues.Add(new MemoryValue("Menu State", 0x00645CD8, "Int32", "Game State", "Current menu",
@"0x136e3c13 = File Select
0xbadf298d = Main Menu"));
            memoryValues.Add(new MemoryValue("Main Menu Selection", 0x00645CDC, "Int32", "Game State", "Menu selection (+0xc if File Select)",
@"0x00 = Career
0x01 = My Cars
0x02 = Challenge Series
0x03 = Quick Race
0x04 = Reward Cards
0x05 = Statistics
0x06 = Options
0x07 = Car (Debug)"));
            memoryValues.Add(new MemoryValue("Menu 2", 0x00645CE4, "Int32", "Game State", "Secondary menu state"));
            memoryValues.Add(new MemoryValue("Main Menu Selection 2", 0x00645CE8, "Int32", "Game State", "Secondary menu selection"));
            memoryValues.Add(new MemoryValue("Reach Destination Flag", 0x0060A734, "Int32", "Game State", "0x01=Destination reached"));
            memoryValues.Add(new MemoryValue("Reach Destination Pause", 0x0060A764, "Int32", "Game State", "0x01=Pause gameplay flag"));
            memoryValues.Add(new MemoryValue("Using Memory Card", 0x00AF0FD4, "Int8", "Game State", "0x01=Using memory card"));
            memoryValues.Add(new MemoryValue("Accessing Memory Card", 0x00AF20EC, "Int32", "Game State", "0x01=Accessing memory card"));
            memoryValues.Add(new MemoryValue("Hearing Voice Message", 0x00ADDB18, "Int8", "Game State", "0x01=Hearing voice message"));

            // Pursuit System
            memoryValues.Add(new MemoryValue("Current Heat Level", 0x005E058C, "Float", "Pursuit", "Current heat level"));
            memoryValues.Add(new MemoryValue("In Pursuit", 0x005E0594, "Int8", "Pursuit", "0x01=In pursuit"));
            memoryValues.Add(new MemoryValue("Pursuit State", 0x00604520, "Int32", "Pursuit", "Current pursuit state",
@"0x00 = None
0x01 = Normal (Uses Pointer 1)
0x02 = Race (Doesn't matter, probably uses pointer 3)
0x03 = Post-Race (Uses Pointer 2)"));
            memoryValues.Add(new MemoryValue("Pursuit Pointer 1", 0x00604528, "Int32", "Pursuit", "Pursuit data pointer",
@"+0x140 = [Float] Timer
+0x1d0 = Total Engaged Units
+0x1d4 = Cop Cars Disabled
+0x1f0 = Total Roadblocks Passed"));
            memoryValues.Add(new MemoryValue("Pursuit Pointer 2", 0x0060452C, "Int32", "Pursuit", "Post-race pursuit data",
@"+0x140 = [Float] Timer
+0x1d0 = [32-Bit] Total Engaged Units
+0x1d4 = [32-Bit] Cop Cars Disabled
+0x1f0 = [32-Bit] Total Roadblocks Passed
+0x1f8 = [32-Bit] Cop Cars Rammed
+0x20c = [32-Bit] Spike Strips Dodged
+0x214 = [32-Bit] Cost to State
+0x284 = Pursuit State
  0x00 = Pursuit
  0x02 = Cooldown
  0x04 = Escape"));
            memoryValues.Add(new MemoryValue("Pursuit Timer", 0x01FA3A60, "Int32", "Pursuit", "Pursuit duration timer"));

            // Player Position & Rotation
            memoryValues.Add(new MemoryValue("Coordinate X", 0x0064D550, "Float", "Position", "Player X coordinate"));
            memoryValues.Add(new MemoryValue("Coordinate Y", 0x0064D554, "Float", "Position", "Player Y coordinate"));
            memoryValues.Add(new MemoryValue("Coordinate Z", 0x0064D558, "Float", "Position", "Player Z coordinate"));
            memoryValues.Add(new MemoryValue("X Rotation", 0x0064D544, "Int32", "Position", "Player X rotation"));
            memoryValues.Add(new MemoryValue("Y Rotation", 0x0064D548, "Int32", "Position", "Player Y rotation"));
            memoryValues.Add(new MemoryValue("Z Rotation", 0x0064D54C, "Int32", "Position", "Player Z rotation"));

            // Current Car
            memoryValues.Add(new MemoryValue("Current Car ID Pointer", 0x006870D8, "Int32", "Current Car", "Pointer to current car ID",
@"+0x00 = Current Car ID
0x01 = Porsche Carrera GT
0x02 = Dodge Viper SRT10
0x03 = Mazda RX-8
0x04 = Ford Mustang GT
0x05 = Chevrolet Camaro SS
0x07 = Mercedes-Benz SLR McLaren
0x09 = BMW M3 GTR
0x0b = Vauxhall Monaro VXR
0x0c = Mercedes-Benz SL65 AMG
0x0d = Lotus Elise
0x0e = Ford GT
0x0f = Mitsubishi Eclipse GT
0x10 = Toyota Supra
0x11 = Mazda RX-7
0x12 = Lamborghini Murciélago
0x13 = Porsche Cayman S
0x14 = Mercedes-Benz CLK 500
0x15 = Aston Martin DB9
0x16 = Lamborghini Gallardo
0x17 = Renault Clio V6
0x18 = Mitsubishi Eclipse
0x19 = Mitsubishi Lancer Evolution IX
0x1b = Plymouth HEMI 'Cuda
0x1c = Chrysler 300C HEMI SRT8
0x1d = Toyota MR2
0x20 = Nissan 350Z
0x21 = Nissan 240SX
0x22 = Infiniti G35
0x23 = Nissan Skyline GT-R
0x24 = Subaru Impreza WRX STI
0x25 = Volkswagen Golf R32
0x26 = Dodge Charger R/T
0x27 = Porsche 911 Turbo (997)
0x28 = Alfa Romeo Brera
0x2a = Chevrolet Corvette Z06
0x2b = Dodge Challenger Concept
0x2c = Audi Le Mans quattro
0x2d = Dodge Challenger R/T 440
0x2e = Chevrolet Chevelle SS
0x30 = Mazda Mazdaspeed3
0x31 = Chevrolet Camaro Concept
0x32 = Jaguar XK
0x33 = Dodge Charger SRT8
0x34 = Koenigsegg CCX
0x36 = Lamborghini Murciélago LP 640
0x38 = Shelby G.T. 500
0x44 = Palmont DT1
0x45 = Palmont FD1
0x54 = Palmont PD1
0x57 = Palmont PD3"));

            memoryValues.Add(new MemoryValue("Current Area", 0x00647B58, "Int32", "Current Car", "Possible current area",
@"0x01f4d8e0 = Mason District
0x01f4dd40 = Old Quarter
0x01f4df70 = Historic Chinatown
0x01f6c850 = Kempton Holdings
0x01f85fa0 = Morgan Beach"));
            memoryValues.Add(new MemoryValue("Current Area Popup", 0x01B0EF08, "Int32", "Current Car", "Pop up appears when changed"));

            // Race Data
            memoryValues.Add(new MemoryValue("Race Data Pointer", 0x00647760, "Int32", "Race Data", "Main race data pointer",
@"General:
+0x064 = Current Position
+0x06c = [Float] Progress
+0x088 = 0x01=Race End
+0x094 = Current Lap
+0x098 = Current Checkpoint
+0x0e0 = Current Speedtrap
+0x18C = [Float] Total Speed
+0x1CC = [Float] Total Race Time
+0x3e8 = [ASCII] P2 Name
  0x494d5559 = Yumi
  0x004c4153 = Sal
  0x494c4f43 = Colin
  0x534d4153 = Samson
  0x4956454e = Neville
  0x4b4b494e = Nikki
+0x408 = [32-Bit] P2 Slot=0x01
+0x40C = [32-Bit] Is P2 Crew Member?
  0x00 = Yes
  Not 0x00 = No
+0x414 = [32-Bit] P2 (Crew Member) Position
+0x7b8 = [32-Bit] P3 Slot=0x02
+0xb68 = [32-Bit] P4 Slot=0x03
+0xF0C = In a Race Flag
  0x00 = Not in a Race
  0x01 = In a Race
+0xF10 = Race Mode
  0x00 = Quick Race/Challenge Series
  0x03 = Career
+0xF80 = [Float] Lap 1 Time
+0xF90 = [Float] Lap 2 Time
+0xFA0 = [Float] Lap 3 Time
+0xFB0 = [Float] Lap 4 Time
+0xFC0 = [Float] Lap 5 Time
+0xFD0 = [Float] Lap 6 Time
+0xFE0 = [Float] Lap 7 Time
+0xFF0 = [Float] Lap 8 Time

Canyon:
+0x1cf4 = [32-Bit] Distance Threshold
+0x1cfc = [32-Bit] Used Distance in Lap 2
+0x1d00 = [32-Bit] Affects Distance Ahead of Opponent
+0x1d28 = Float Overtaken Timer
+0x1d44 = Float Pulling Away Timer
+0x1d58 = Float Canyon Points
+0x1d84 = Float Opponent Passed Timer
+0x1da0 = Float Falling Behind Timer"));

            memoryValues.Add(new MemoryValue("Current Track ASCII", 0x009F11BC, "Int64", "Race Data", "8-byte ASCII track ID (combine Lower4s)",
@"Other:
0x1F32f333 = Being chased by Cross
0x1f1f1e6c = Doing a test drive
0x1d454f29 = In the tutorial race
0x1f3f0533 = In Free Roam (First Pursuit)

Challenge Series:
0x6F1F1E6C = Canyon Duel Bronze
0x6F1F2E6C = Canyon Duel Silver
0x6F1F3E6C = Canyon Duel Gold
0x6F2F1E6C = Canyon Race Bronze
0x6F2F2E6C = Canyon Race Silver
0x6F2F3E6C = Canyon Race Gold
0x6f3f1e6c = Checkpoint Bronze
0x6f3f2e6c = Checkpoint Silver
0x6f3f3e6c = Checkpoint Gold
0x6f13f1e6 = Canyon Checkpoint Bronze
0x6f13f2e6 = Canyon Checkpoint Silver
0x6f1ef3e6 = Canyon Checkpoint Gold
0x6f14f4e6 = Canyon Drift Bronze
0x6f14f2e6 = Canyon Drift Silver
0x6f14f3e6 = Canyon Drift Gold
0x6f6f1e6c = Pursuit Evasion Bronze
0x6f6f2e6c = Pursuit Evasion Silver
0x6f6f3e6c = Pursuit Evasion Gold
0x6f7f1e6c = Trade Paint Bronze
0x6f7f2e6c = Trade Paint Silver
0x6f7f3e6c = Trade Paint Gold
0x6f8f1e6c = Circuit Bronze
0x6f8f2e6c = Circuit Silver
0x6f8f3e6c = Circuit Gold
0x6f9f1e6c = Sprint Bronze
0x6f9f2e6c = Sprint Silver
0x6f9f3e6c = Sprint Gold
0x6f10f1e6 = Drift Bronze
0x6f10f5e6 = Drift Silver
0x6f10f6e6 = Drift Gold
0x6f11f1e6 = Speedtrap Bronze
0x6f11f2e6 = Speedtrap Silver
0x6f11f3e6 = Speedtrap Gold
0x6f12f1e6 = Race Wars Bronze
0x6f12f2e6 = Race Wars Silver
0x6f12f3e6 = Race Wars Gold
0x7f4f1e6c = CE Checkpoint Bronze
0x7f4f3e6c = CE Checkpoint Silver
0x7f4f2e6c = CE Checkpoint Gold
0x7f5f3e6c = CE Challenge Bronze
0x7f5f2e6c = CE Challenge Silver
0x7f5f1e6c = CE Challenge Gold
0x6f15f1e6 = CE Race Wars Bronze
0x6f15f2e6 = CE Race Wars Silver
0x6f15f3e6 = CE Race Wars Gold

Sprint:
0x2f1f2e6c = Dover and Lepus
0x2f3f2e6c = Petersburg Dam
0x2f5f2e6c = Mission Street
0x2f2f1e6c = Waterfront Road
0x8f4f5e6c = Desperation Ridge
0x5f2f30e6 = Silverton Way
0x5f1f3e6c = Deadfall Junction
0x5f4f2e6c = Starlight Street
0x5f6f1e6c = Eagle Drive
0x5f5f2e6c = Spade Street
0x4f2f2e6c = Verona Tunnel
0x4f4f2e6c = York Road
0x4f5f2e6c = Agostini Avenue
0x4f3f1e6c = North Bellezza
0x4f3f3e6c = Lofty Heights Downhill
0x3f3f2e6c = Lincoln Boulevard
0x3f2f3e6c = Chinatown Tram
0x4f1f2e6c = Gold Valley Run
0x2f4f1e6c = Devil's Creek Pass
0x3f4f1e6c = Mason Street
0x8f4f1e6c = Copper Ridge
0x7f2f1e6c = Mason St. Bridge
0x7f2f2e6c = Francis Tunnel
0x8f4f6e6c = Eternity Pass
0x8f4f4e6c = Journeyman's Bane
0x8f4f3e6c = Knife's Edge
0x1f2f2e6c = Mesa Bridge
0x7f2f3e6c = Blackwell Bridge
0x8f4f2e6c = Lookout Point

Circuit:
0x2f1f1e6c = Beachfront
0x2f3f1e6c = Kempton Docks
0x2f2f3e6c = Dover Street
0x5F7F3E6C = Brooks Street
0x5f2f1e6c = North Broadway
0x5f1f1e6c = Savannah Street
0x5f5f3e6c = Paradise Hotel
0x4f1f1e6c = University Way
0x4f2f1e6c = Skyline Avenue
0x4f4f1e6c = Ocean View
0x4f5f1e6c = Condo Row
0x3f3f1e6c = Main Street
0x3f2f1e6c = Silk Road
0x3f1f1e6c = North Road
0x3f5f1e6c = Garden Boulevard
0x1f2f1e6c = Salazar Street
0x1f3f1e6c = Royal Avenue
0x7f3f3e6c = South Fortuna
0x5f3f1e6c = Lucky Towers
0x7f3f2e6c = Campbell Tunnel
0x7f3f1e6c = Robinson Bay

Checkpoint:
0x2f1f3e6c = Morgan Beach Offramp
0x2f4f3e6c = Eskuri Plaza
0x5f4f1e6c = Blackwell Road
0x5f3f3e6c = The Neon Mile
0x5f2f2e6c = Troy
0x5f6f2e6c = Gray Street
0x4f1f3e6c = University Avenue
0x4f4f3e6c = Rabinowitz Drive
0x4f5f3e6c = Hills Borough Parkway
0x3f1f2e6c = Knight Street

Speedtrap:
0x2f4f2e6c = Eskuri Way
0x2f3f3e6c = Stonewall Tunnel
0x2f5f1e6c = Newport Trainyard
0x2f2f2e6c = Foundry Road
0x5f4f3e6c = Canmor Road
0x5f3f2e6c = Olympic Boulevard
0x5f5f1e6c = Bowen Avenue
0x4f2f3e6c = Million Dollar Drive
0x3f3f3e6c = Park Drive
0x3f4f2e6c = Mason Fountain

Drift:
0x3f5f2e6c = Knife's Edge
0x2f5f3e6c = Devil's Creek Pass
0x5f7f1e6c = Journeyman's Bane
0x3f4f3e6c = City Courthouse
0x4f3f2e6c = Lofty Heights Downhill
0x3f2f2e6c = Kimei Temple
0x3f5f3e6c = King's Park
0x3f1f3e6c = Lookout Point
0x7f1f4e6c = Starlight Strip
0x7f1f1e6c = Old Quarter
0x8f2f2e6c = Gold Valley Run
0x8f1f3e6c = Newport Ironworks
0x7f1f2e6c = Fortuna Heights
0x7f1f3e6c = Palmont University
0x7f1f6e6c = Billings District
0x8f2f4e6c = Desperation Ridge
0x8f1f1e6c = Park Drive Drift
0x8f2f3e6c = Deadfall Junction
0x7f1f5e6c = Shady Pine
0x8f2f1e6c = Copper Ridge
0x8f1f2e6c = Main Street Drift
0x8f2f5e6c = Eternity Pass

Canyon:
0x5f1f2e6c = Deadfall Junction
0x5f7f2e6c = Desperation Ridge
0x5f6f3e6e = Journeyman's Bane
0x2f455ce6 = Copper Ridge
0x3f455ce6 = Gold Valley Run
0x8f3f3e6c = Knife's Edge
0x8f3f1e6c = Devil's Creek Pass
0x5f455ce6 = Eternity Pass
0x4f455c56 = Lookout Point
0x8f3f2e6c = Lofty Heights Downhill"));

            memoryValues.Add(new MemoryValue("Current Event ID", 0x01C7D9E0, "Int32", "Race Data", "Selected event ID"));
            memoryValues.Add(new MemoryValue("Races Quit", 0x00648F34, "Int32", "Race Data", "Number of races quit"));
            memoryValues.Add(new MemoryValue("Black Hearts Defence Race", 0x004B2D14, "Int32", "Race Data", "Black Hearts defence race"));

            // Drift System
            memoryValues.Add(new MemoryValue("Drift Pointer", 0x0064583C, "Int32", "Drift", "Drift data pointer",
@"+0x184 = Drift Multiplier
+0x418 = ASCII Displayed Current Drift Score"));
            memoryValues.Add(new MemoryValue("Drift Score", 0x01F36340, "Int32", "Drift", "Current drift score (refuses to move, acts like pointer)"));
            memoryValues.Add(new MemoryValue("Last Drift Score", 0x01F36350, "Int32", "Drift", "Score of last completed drift"));
            memoryValues.Add(new MemoryValue("Drifts Ended by Wall", 0x01F36360, "Int32", "Drift", "Drifts ended by hitting wall"));
            memoryValues.Add(new MemoryValue("Total Drifts", 0x01F36364, "Int32", "Drift", "Total number of drifts"));
            memoryValues.Add(new MemoryValue("Start of Suxin Flags", 0x01EFDDD4, "Int16", "Drift", "Start of suxin flags"));

            // Career Progress
            memoryValues.Add(new MemoryValue("Player Name", 0x00A4A5B0, "Int64", "Career", "6-byte ASCII player name"));
            memoryValues.Add(new MemoryValue("Crew Name", 0x00A6E8D8, "Int64", "Career", "15-byte ASCII crew name"));
            memoryValues.Add(new MemoryValue("Crew Logo", 0x00A6E8B4, "Int32", "Career", "Crew logo ID"));
            memoryValues.Add(new MemoryValue("Crew Logo Color", 0x00A6E8B8, "Int32", "Career", "Crew logo color (if custom)"));
            memoryValues.Add(new MemoryValue("Starting Class", 0x00A6E8E7, "Int8", "Career", "Starting class",
@"0x01 = Exotic
0x02 = Muscle
0x03 = Tuner"));
            memoryValues.Add(new MemoryValue("Starting Class Actual", 0x01B11998, "Int32", "Career", "Actual starting class address",
@"0x01 = Exotic
0x02 = Muscle
0x03 = Tuner"));
            memoryValues.Add(new MemoryValue("Cash Money", 0x00A6E8F4, "Int32", "Career", "Current cash"));
            memoryValues.Add(new MemoryValue("Reputation", 0x00A6E8F8, "Int32", "Career", "Current reputation"));
            memoryValues.Add(new MemoryValue("Story Flags", 0x00A6E8EC, "Int32", "Career", "Story flags (bit0=Tutorial, bit1=Intro)"));
            memoryValues.Add(new MemoryValue("Story Progress", 0x00A6EB56, "Int32", "Career", "Current story progress"));
            memoryValues.Add(new MemoryValue("Safe House First Time", 0x00A6EB5B, "Int8", "Career", "Check bit5 for entering safe house first time"));
            memoryValues.Add(new MemoryValue("Crew Logo Popup", 0x00A6EB5C, "Int8", "Career", "bit0=Crew Logo Popup"));

            // Voice Messages
            memoryValues.Add(new MemoryValue("Darius 'You did it!' Message", 0x00A6E923, "Int32", "Voice Messages", "Darius message (using as 24-bit)"));
            memoryValues.Add(new MemoryValue("Samson 'Need some new crew?' Message", 0x00A6E927, "Int32", "Voice Messages", "Samson message (using as 24-bit)"));
            memoryValues.Add(new MemoryValue("Samson 'We meeting or what?' Message", 0x00A6E92B, "Int32", "Voice Messages", "Samson message (using as 24-bit)"));
            memoryValues.Add(new MemoryValue("Yumi 'Meet me at the Plaza' Message", 0x00A6E933, "Int32", "Voice Messages", "Yumi message (using as 24-bit)"));
            memoryValues.Add(new MemoryValue("Yumi 'Drive Faster!' Message", 0x00A6E937, "Int32", "Voice Messages", "Yumi message (using as 24-bit)"));
            memoryValues.Add(new MemoryValue("Yumi ':(' Message", 0x00A6E93B, "Int32", "Voice Messages", "Yumi sad message (using as 24-bit)"));
            memoryValues.Add(new MemoryValue("Colin 'Let's Talk' Message", 0x00A6E93F, "Int32", "Voice Messages", "Colin message (using as 24-bit)"));
            memoryValues.Add(new MemoryValue("Colin 'Where are you?' Message", 0x00A6E943, "Int32", "Voice Messages", "Colin message (using as 24-bit)"));
            memoryValues.Add(new MemoryValue("'Meet me at Safe House' Message", 0x00A6E94F, "Int8", "Voice Messages", "Meet me at safe house message"));
            memoryValues.Add(new MemoryValue("Safe House Message Count", 0x00A6E950, "Int16", "Voice Messages", "Amount of times you get the safe house message"));
            memoryValues.Add(new MemoryValue("Message ID", 0x00A6E95E, "Int8", "Voice Messages", "Current message ID (0x18=Let's make this interesting)"));
            memoryValues.Add(new MemoryValue("Message Progress", 0x00A6E95F, "Int8", "Voice Messages", "bit1=New Message, bit2=Read"));

            // Career Statistics
            memoryValues.Add(new MemoryValue("Career Races Won", 0x00A6EBC4, "Int32", "Career Stats", "Total career races won (start of gameplay stats)"));
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
            memoryValues.Add(new MemoryValue("Reward Marker 1 ID", 0x00979A04, "Int32", "Reward Markers", "Marker 1 type",
@"0x01 = Unique Body Kit
0x02 = Unique Hood
0x03 = Unique Spoiler
0x04 = Unique Rims
0x05 = Unique Roof Scoops
0x07 = Unique Vinyl
0x08 = Unique Decal (Unused)
0x0a = Get out of jail for free
0x0b = Pink Slip
0x0c = Extra Cash Reward
0x0d = Extra Impound Strike
0x0e = Reduce Heat"));
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

            // Reward Cards
            memoryValues.Add(new MemoryValue("Reward Card - First Blood", 0x00A4814C, "Int32", "Reward Cards", "First Blood"));
            memoryValues.Add(new MemoryValue("Reward Card - Makin' Money", 0x00A48154, "Int32", "Reward Cards", "Makin' Money"));
            memoryValues.Add(new MemoryValue("Reward Card - Street Racer", 0x00A4815C, "Int32", "Reward Cards", "Street Racer"));
            memoryValues.Add(new MemoryValue("Reward Card - Time Shift", 0x00A48164, "Int32", "Reward Cards", "Time Shift"));
            memoryValues.Add(new MemoryValue("Reward Card - Defender", 0x00A4816C, "Int32", "Reward Cards", "Defender"));
            memoryValues.Add(new MemoryValue("Reward Card - Stash", 0x00A48174, "Int32", "Reward Cards", "Stash"));
            memoryValues.Add(new MemoryValue("Reward Card - Downhill Dynamo", 0x00A4817C, "Int32", "Reward Cards", "Downhill Dynamo"));
            memoryValues.Add(new MemoryValue("Reward Card - Consolation Award", 0x00A48184, "Int32", "Reward Cards", "Consolation Award"));
            memoryValues.Add(new MemoryValue("Reward Card - Canyon Conquerer", 0x00A4818C, "Int32", "Reward Cards", "Canyon Conquerer"));
            memoryValues.Add(new MemoryValue("Reward Card - Street King", 0x00A48194, "Int32", "Reward Cards", "Street King"));
            memoryValues.Add(new MemoryValue("Reward Card - Getaway", 0x00A4819C, "Int32", "Reward Cards", "Getaway"));
            memoryValues.Add(new MemoryValue("Reward Card - A New Challenger", 0x00A481A4, "Int32", "Reward Cards", "A New Challenger"));
            memoryValues.Add(new MemoryValue("Reward Card - 100K", 0x00A481AC, "Int32", "Reward Cards", "100K"));
            memoryValues.Add(new MemoryValue("Reward Card - Quick Exit", 0x00A481B4, "Int32", "Reward Cards", "Quick Exit"));
            memoryValues.Add(new MemoryValue("Reward Card - Making Your Name", 0x00A481BC, "Int32", "Reward Cards", "Making Your Name"));
            memoryValues.Add(new MemoryValue("Reward Card - Fender Bender", 0x00A481C4, "Int32", "Reward Cards", "Fender Bender"));
            memoryValues.Add(new MemoryValue("Reward Card - Reckless", 0x00A481CC, "Int32", "Reward Cards", "Reckless"));
            memoryValues.Add(new MemoryValue("Reward Card - Brake For No One", 0x00A481D4, "Int32", "Reward Cards", "Brake For No One"));
            memoryValues.Add(new MemoryValue("Reward Card - Public Enemy No. 1", 0x00A481DC, "Int32", "Reward Cards", "Public Enemy No. 1"));
            memoryValues.Add(new MemoryValue("Reward Card - Career Mogul", 0x00A481E4, "Int32", "Reward Cards", "Career Mogul"));
            memoryValues.Add(new MemoryValue("Reward Card - Speed Freak", 0x00A481EC, "Int32", "Reward Cards", "Speed Freak"));
            memoryValues.Add(new MemoryValue("Reward Card - Urban Combat", 0x00A481F4, "Int32", "Reward Cards", "Urban Combat"));
            memoryValues.Add(new MemoryValue("Reward Card - Cuttin' Deals", 0x00A481FC, "Int32", "Reward Cards", "Cuttin' Deals"));
            memoryValues.Add(new MemoryValue("Reward Card - Cannonball", 0x00A48204, "Int32", "Reward Cards", "Cannonball"));
            memoryValues.Add(new MemoryValue("Reward Card - 50 Tracks", 0x00A4820C, "Int32", "Reward Cards", "50 Tracks"));
            memoryValues.Add(new MemoryValue("Reward Card - 8 Rides", 0x00A48214, "Int32", "Reward Cards", "8 Rides"));
            memoryValues.Add(new MemoryValue("Reward Card - Big Bucks", 0x00A4821C, "Int32", "Reward Cards", "Big Bucks"));
            memoryValues.Add(new MemoryValue("Reward Card - Crime Spree", 0x00A48224, "Int32", "Reward Cards", "Crime Spree"));
            memoryValues.Add(new MemoryValue("Reward Card - Street Legend", 0x00A4822C, "Int32", "Reward Cards", "Street Legend"));
            memoryValues.Add(new MemoryValue("Reward Card - Urban Warfare", 0x00A48234, "Int32", "Reward Cards", "Urban Warfare"));
            memoryValues.Add(new MemoryValue("Reward Card - Vandal", 0x00A4823C, "Int32", "Reward Cards", "Vandal"));
            memoryValues.Add(new MemoryValue("Reward Card - Road to Victory", 0x00A48244, "Int32", "Reward Cards", "Road to Victory"));
            memoryValues.Add(new MemoryValue("Reward Card - Hard Time", 0x00A4824C, "Int32", "Reward Cards", "Hard Time"));
            memoryValues.Add(new MemoryValue("Reward Card - Escape Artist", 0x00A48254, "Int32", "Reward Cards", "Escape Artist"));
            memoryValues.Add(new MemoryValue("Reward Card - Challenge Champion", 0x00A4825C, "Int32", "Reward Cards", "Challenge Champion"));
            memoryValues.Add(new MemoryValue("Reward Card - Houdini", 0x00A48264, "Int32", "Reward Cards", "Houdini"));
            memoryValues.Add(new MemoryValue("Reward Card - Block Breaker", 0x00A4826C, "Int32", "Reward Cards", "Block Breaker"));
            memoryValues.Add(new MemoryValue("Reward Card - Iron Tires", 0x00A48274, "Int32", "Reward Cards", "Iron Tires"));
            memoryValues.Add(new MemoryValue("Reward Card - Battering Ram", 0x00A4827C, "Int32", "Reward Cards", "Battering Ram"));
            memoryValues.Add(new MemoryValue("Reward Card - All Your Base", 0x00A48284, "Int32", "Reward Cards", "All Your Base"));
            memoryValues.Add(new MemoryValue("Reward Card - Burnt Rubber", 0x00A4828C, "Int32", "Reward Cards", "Burnt Rubber"));
            memoryValues.Add(new MemoryValue("Reward Card - Canyon Run", 0x00A48294, "Int32", "Reward Cards", "Canyon Run"));
            memoryValues.Add(new MemoryValue("Reward Card - 8 Minute Exit", 0x00A4829C, "Int32", "Reward Cards", "8 Minute Exit"));
            memoryValues.Add(new MemoryValue("Reward Card - Troublemaker", 0x00A482A4, "Int32", "Reward Cards", "Troublemaker"));
            memoryValues.Add(new MemoryValue("Reward Card - Drifter", 0x00A482AC, "Int32", "Reward Cards", "Drifter"));
            memoryValues.Add(new MemoryValue("Reward Card - 3 Rides", 0x00A482B4, "Int32", "Reward Cards", "3 Rides"));
            memoryValues.Add(new MemoryValue("Reward Card - 20K Bounty", 0x00A482BC, "Int32", "Reward Cards", "20K Bounty"));
            memoryValues.Add(new MemoryValue("Reward Card - Rivals", 0x00A482C4, "Int32", "Reward Cards", "Rivals (Multiplayer Only)"));
            memoryValues.Add(new MemoryValue("Reward Card - Big Game Hunter", 0x00A482CC, "Int32", "Reward Cards", "Big Game Hunter"));
            memoryValues.Add(new MemoryValue("Reward Card - Crusher", 0x00A482D4, "Int32", "Reward Cards", "Crusher"));
            memoryValues.Add(new MemoryValue("Reward Card - 5 Rides", 0x00A482DC, "Int32", "Reward Cards", "5 Rides"));
            memoryValues.Add(new MemoryValue("Reward Card - Challenge Novice", 0x00A482E4, "Int32", "Reward Cards", "Challenge Novice"));
            memoryValues.Add(new MemoryValue("Reward Card - Challenge Journeyman", 0x00A482EC, "Int32", "Reward Cards", "Challenge Journeyman"));
            memoryValues.Add(new MemoryValue("Reward Card - Leader of the Pack", 0x00A482F4, "Int32", "Reward Cards", "Leader of the Pack"));
            memoryValues.Add(new MemoryValue("Reward Card - Bronze Medal", 0x00A482FC, "Int32", "Reward Cards", "Bronze Medal"));
            memoryValues.Add(new MemoryValue("Reward Card - Arcade Level 1", 0x00A48304, "Int32", "Reward Cards", "Arcade Level 1"));
            memoryValues.Add(new MemoryValue("Reward Card - Baiter", 0x00A4830C, "Int32", "Reward Cards", "Baiter"));
            memoryValues.Add(new MemoryValue("Reward Card - Free Ride", 0x00A48314, "Int32", "Reward Cards", "Free Ride"));
            memoryValues.Add(new MemoryValue("Reward Card - Diamond Tires", 0x00A4831C, "Int32", "Reward Cards", "Diamond Tires"));
            memoryValues.Add(new MemoryValue("Reward Card - Untouchable", 0x00A48324, "Int32", "Reward Cards", "Untouchable"));
            memoryValues.Add(new MemoryValue("Reward Card - 1/4 Mile", 0x00A4832C, "Int32", "Reward Cards", "1/4 Mile"));
            memoryValues.Add(new MemoryValue("Reward Card - 85 Tracks", 0x00A48334, "Int32", "Reward Cards", "85 Tracks"));
            memoryValues.Add(new MemoryValue("Reward Card - Wheels of Steel", 0x00A4833C, "Int32", "Reward Cards", "Wheels of Steel"));
            memoryValues.Add(new MemoryValue("Reward Card - Small Car Lot", 0x00A48344, "Int32", "Reward Cards", "Small Car Lot"));
            memoryValues.Add(new MemoryValue("Reward Card - Gold Medal", 0x00A4834C, "Int32", "Reward Cards", "Gold Medal"));
            memoryValues.Add(new MemoryValue("Reward Card - 12 Minute Exit", 0x00A48354, "Int32", "Reward Cards", "12 Minute Exit"));
            memoryValues.Add(new MemoryValue("Reward Card - Full House", 0x00A4835C, "Int32", "Reward Cards", "Full House"));
            memoryValues.Add(new MemoryValue("Reward Card - Arcade Level 4", 0x00A48364, "Int32", "Reward Cards", "Arcade Level 4"));
            memoryValues.Add(new MemoryValue("Reward Card - Tuner Addict", 0x00A4836C, "Int32", "Reward Cards", "Tuner Addict"));
            memoryValues.Add(new MemoryValue("Reward Card - Exotic Aficionado", 0x00A48374, "Int32", "Reward Cards", "Exotic Aficionado"));
            memoryValues.Add(new MemoryValue("Reward Card - 50K Bounty", 0x00A4837C, "Int32", "Reward Cards", "50K Bounty"));
            memoryValues.Add(new MemoryValue("Reward Card - Arcade Level 2", 0x00A48384, "Int32", "Reward Cards", "Arcade Level 2"));
            memoryValues.Add(new MemoryValue("Reward Card - Arcade Level 3", 0x00A4838C, "Int32", "Reward Cards", "Arcade Level 3"));
            memoryValues.Add(new MemoryValue("Reward Card - Silver Medal", 0x00A48394, "Int32", "Reward Cards", "Silver Medal"));
            memoryValues.Add(new MemoryValue("Reward Card - Head-to-head", 0x00A4839C, "Int32", "Reward Cards", "Head-to-head"));
            memoryValues.Add(new MemoryValue("Reward Card - Big Biz", 0x00A483A4, "Int32", "Reward Cards", "Big Biz"));
            memoryValues.Add(new MemoryValue("Reward Card - Iron Wall", 0x00A483AC, "Int32", "Reward Cards", "Iron Wall"));
            memoryValues.Add(new MemoryValue("Reward Card - Drift Pro", 0x00A483B4, "Int32", "Reward Cards", "Drift Pro"));
            memoryValues.Add(new MemoryValue("Reward Card - Drift King", 0x00A483BC, "Int32", "Reward Cards", "Drift King"));
            memoryValues.Add(new MemoryValue("Reward Card - Wolfshead", 0x00A483C4, "Int32", "Reward Cards", "Wolfshead"));
            memoryValues.Add(new MemoryValue("Reward Card - Unstoppable", 0x00A483CC, "Int32", "Reward Cards", "Unstoppable"));
            memoryValues.Add(new MemoryValue("Reward Card - Large Car Lot", 0x00A483D4, "Int32", "Reward Cards", "Large Car Lot"));
            memoryValues.Add(new MemoryValue("Reward Card - Fabricator", 0x00A483DC, "Int32", "Reward Cards", "Fabricator"));
            memoryValues.Add(new MemoryValue("Reward Card - Stone Wheels", 0x00A483E4, "Int32", "Reward Cards", "Stone Wheels"));
            memoryValues.Add(new MemoryValue("Reward Card - Need for Speed", 0x00A483EC, "Int32", "Reward Cards", "Need for Speed"));
            memoryValues.Add(new MemoryValue("Reward Card - Muscle Head", 0x00A483F4, "Int32", "Reward Cards", "Muscle Head"));
            memoryValues.Add(new MemoryValue("Reward Card - Challenge Master", 0x00A483FC, "Int32", "Reward Cards", "Challenge Master"));
            memoryValues.Add(new MemoryValue("Reward Card - Moving Disaster", 0x00A48404, "Int32", "Reward Cards", "Moving Disaster"));
            memoryValues.Add(new MemoryValue("Reward Card - Most Wanted", 0x00A4840C, "Int32", "Reward Cards", "Most Wanted"));
            memoryValues.Add(new MemoryValue("Reward Card - Fast Wheels", 0x00A48414, "Int32", "Reward Cards", "Fast Wheels"));
            memoryValues.Add(new MemoryValue("Reward Card - Speed Demon", 0x00A4841C, "Int32", "Reward Cards", "Speed Demon"));
            memoryValues.Add(new MemoryValue("Reward Card - 20K Bill", 0x00A48424, "Int32", "Reward Cards", "20K Bill"));
            memoryValues.Add(new MemoryValue("Reward Card - Drift Novice", 0x00A4842C, "Int32", "Reward Cards", "Drift Novice"));
            memoryValues.Add(new MemoryValue("Reward Card - Wrecking Ball", 0x00A48434, "Int32", "Reward Cards", "Wrecking Ball"));
            memoryValues.Add(new MemoryValue("Reward Card - Urban Battle", 0x00A4843C, "Int32", "Reward Cards", "Urban Battle"));
            memoryValues.Add(new MemoryValue("Reward Card - Unblockable", 0x00A48444, "Int32", "Reward Cards", "Unblockable"));
            memoryValues.Add(new MemoryValue("Reward Card - Downtown Turf", 0x00A4844C, "Int32", "Reward Cards", "Downtown Turf"));
            memoryValues.Add(new MemoryValue("Reward Card - Number 1", 0x00A48454, "Int32", "Reward Cards", "Number 1"));
            memoryValues.Add(new MemoryValue("Reward Card - Conqueror", 0x00A4845C, "Int32", "Reward Cards", "Conqueror"));
            memoryValues.Add(new MemoryValue("Reward Card - Collector", 0x00A48464, "Int32", "Reward Cards", "Collector"));

            // Unlocks Table
            memoryValues.Add(new MemoryValue("Unlocked Item 1 ID", 0x00A48600, "Int32", "Unlocks", "First unlocked item ID",
@"0x026f0d63 = Angie's Car
0x031f30f0 = Kenji's Car
0x001ef697 = Wolf's Car
0x854f11da = Angie's Unique Wheel Upgrade
0x70f46603 = Angie's Unique Vinyl
0x7fd2b39d = Kenji's Unique Roof Scoop
0xc8d6ad51 = Kenji's Unique Vinyl
0x093242de = Wolf's Unique Spoiler
0xc5c40e88 = Wolf's Unique Vinyl"));
            memoryValues.Add(new MemoryValue("Unlocked Item 1 New Flag", 0x00A48604, "Int32", "Unlocks", "0x01=New, 0x00=Seen"));
            memoryValues.Add(new MemoryValue("Hood - Dual Stage New Flag", 0x00A4866C, "Int8", "Unlocks", "0x01=New, 0x00=Seen"));
            memoryValues.Add(new MemoryValue("Start of New Unlocks", 0x00A48B28, "Int32", "Unlocks", "Start of new unlocks on new save file"));
            memoryValues.Add(new MemoryValue("End of Unlocks Table (100%)", 0x00A49E98, "Int32", "Unlocks", "End of unlocks table on 100% save"));
            memoryValues.Add(new MemoryValue("End of Unlocks Table", 0x00A4A538, "Int32", "Unlocks", "End of unlocks table"));

            // Car Impound Strikes
            memoryValues.Add(new MemoryValue("Career Car 1 Impound Strikes", 0x00A60446, "Int8", "Impound", "Car 1 impound strikes"));
            memoryValues.Add(new MemoryValue("Career Car 2 Impound Strikes", 0x00A6047A, "Int8", "Impound", "Car 2 impound strikes"));
            memoryValues.Add(new MemoryValue("Career Car 3 Impound Strikes", 0x00A604AE, "Int8", "Impound", "Car 3 impound strikes"));
            memoryValues.Add(new MemoryValue("Career Car 4 Impound Strikes", 0x00A604E2, "Int8", "Impound", "Car 4 impound strikes"));
            memoryValues.Add(new MemoryValue("Career Car 5 Impound Strikes", 0x00A60516, "Int8", "Impound", "Car 5 impound strikes"));
            memoryValues.Add(new MemoryValue("Career Car 6 Impound Strikes", 0x00A6054A, "Int8", "Impound", "Car 6 impound strikes"));
            memoryValues.Add(new MemoryValue("Career Car 7 Impound Strikes", 0x00A6057E, "Int8", "Impound", "Car 7 impound strikes"));
            memoryValues.Add(new MemoryValue("Career Car 8 Impound Strikes", 0x00A605B2, "Int8", "Impound", "Car 8 impound strikes"));
            memoryValues.Add(new MemoryValue("Career Car 9 Impound Strikes", 0x00A605E6, "Int8", "Impound", "Car 9 impound strikes"));

            // My Cars
            memoryValues.Add(new MemoryValue("My Cars - First Car", 0x00A4B2C4, "Int32", "My Cars", "First car in garage"));
            memoryValues.Add(new MemoryValue("My Cars - First Car Name ID", 0x00A4B2C8, "Int32", "My Cars", "Name ID of first car"));
            memoryValues.Add(new MemoryValue("Career Car 1 - Engine", 0x00A54128, "Int16", "My Cars", "Career car 1 engine"));
            memoryValues.Add(new MemoryValue("Car 6 - ID", 0x00A56540, "Int32", "My Cars", "Car 6 ID"));
            memoryValues.Add(new MemoryValue("Car 7 - ID", 0x00A56E20, "Int32", "My Cars", "Car 7 ID"));
            memoryValues.Add(new MemoryValue("Car 8 - ID", 0x00A57700, "Int32", "My Cars", "Car 8 ID"));

            // Boss Cars
            memoryValues.Add(new MemoryValue("Boss Car 1 - Vinyl 1", 0x00A552C4, "Int32", "Boss Cars", "Boss car 1 vinyl"));
            memoryValues.Add(new MemoryValue("Boss Car 1 - Engine", 0x00A552F8, "Int16", "Boss Cars", "Boss car 1 engine"));
            memoryValues.Add(new MemoryValue("Boss Car 1 - ID", 0x00A55380, "Int32", "Boss Cars", "Boss car 1 ID (0x26=Dodge Charger R/T)"));
            memoryValues.Add(new MemoryValue("Boss Car 2 - ID", 0x00A560D0, "Int32", "Boss Cars", "Boss car 2 ID (0x15=Aston Martin DB9)"));
            memoryValues.Add(new MemoryValue("Career Car 3 - Engine", 0x00A56038, "Int16", "Boss Cars", "Career car 3 engine"));

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
            memoryValues.Add(new MemoryValue("Car Camera", 0x00A6E854, "Int32", "Settings", "Camera view",
@"0x00 = Bumper
0x01 = Hood
0x02 = Close
0x03 = Far"));
            memoryValues.Add(new MemoryValue("Split Time Flag", 0x00A6E858, "Int8", "Settings", "Split time display"));
            memoryValues.Add(new MemoryValue("Transmission Mode", 0x00A6E859, "Int8", "Settings", "0x00=Automatic, 0x01=Manual"));
            memoryValues.Add(new MemoryValue("Save File Pointer", 0x00A6E8A0, "Int32", "Settings", "Pointer to start of save file"));

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
            memoryValues.Add(new MemoryValue("Quick Race - Selected Crew", 0x00A70870, "Int32", "Quick Race", "Selected crew member",
@"0x014f80c4 = Yumi
0x3f3e465c = Sal
0xa05c48e1 = Colin
0xa58a7d2c = Samson
0xb00f935c = Neville
0xc9191f86 = Nikki"));

            // Cheats
            memoryValues.Add(new MemoryValue("Infinite Crew Charge Cheat", 0x0061241C, "Int32", "Cheats", "Infinite crew charge"));
            memoryValues.Add(new MemoryValue("Infinite Nitrous Cheat", 0x00612458, "Int32", "Cheats", "Infinite nitrous"));
            memoryValues.Add(new MemoryValue("Unlimited Speedbreaker Cheat", 0x00612494, "Int32", "Cheats", "Unlimited speedbreaker"));

            // Pointers
            memoryValues.Add(new MemoryValue("Pointer Chain to Everything", 0x00A47FFC, "Int32", "Pointers", "Pointer chain to everything"));
            memoryValues.Add(new MemoryValue("Pointer to Statistics Races", 0x00A48014, "Int32", "Pointers", "Pointer to statistics races"));
            memoryValues.Add(new MemoryValue("Unknown Save File Area", 0x00A48020, "Int32", "Pointers", "Part of save file (unknown)"));
            memoryValues.Add(new MemoryValue("Guide Arrow Pointer", 0x0060503C, "Int32", "Pointers", "Pointer (+0xEC=Guide Arrow Flag)"));
            memoryValues.Add(new MemoryValue("P1 Data Pointer", 0x0060A6F8, "Int32", "Pointers", "Probably P1 data pointer"));
            memoryValues.Add(new MemoryValue("P2 Data Pointer", 0x0060A6FC, "Int32", "Pointers", "Probably P2 data pointer"));
            memoryValues.Add(new MemoryValue("Pause Menu Pointer", 0x01C7D9A0, "Int32", "Pointers", "Pause menu pointer",
@"+0x00 = World Map State
0x03 = Default
0x08 = Defence Race Prompt
0x16 = Started Race"));
            memoryValues.Add(new MemoryValue("GCareer Pointer 2", 0x01B11910, "Int32", "Pointers", "Secondary career pointer (+0x14, ++0x10=Hills Borough Parkway)"));
            memoryValues.Add(new MemoryValue("GCareer Pointer", 0x01B11914, "Int32", "Pointers", "Main career data pointer",
@"+0x04
++0x00
+++0x00
++++0x04
+++++0x14
++++++0x10 | Lincoln Boulevard [Sprint] [Downtown - Mason District]
+++++0x00
++++++0x14
+++++++0x10 | Morgan Beach Offramp [Checkpoint] [Kempton - Morgan Beach]"));
            memoryValues.Add(new MemoryValue("GCareer Related Pointer", 0x01B1192C, "Int32", "Pointers", "Related pointer",
@"+0x34 | Pointer
++0x10 | Dover Street Owner

Kempton:
+8370 = Mission Street (Sprint)
+85F0 = Knife's Edge (Drift)
+8B70 = Dover Street (Circuit)
+9070 = Newport Trainyard (Speedtrap)
+94F0 = Dover and Lepus (Sprint)
+9670 = Waterfront Road (Sprint)
+96F0 = Morgan Beach Offramp (Checkpoint)
+9970 = Angie Boss Race
+9A70 = Eskuri Way (Speedtrap)
+9C70 = Foundry Road (Speedtrap)
+9FF0 = Eskuri Plaza (Checkpoint)
+A0F0 = Beachfront (Circuit)
+A3F0 = Petersburg Dam (Sprint)
+A470 = Devil's Creek Pass (Drift)
+F030 = Stonewall Tunnel (Speedtrap)"));
            memoryValues.Add(new MemoryValue("GCrew Pointer", 0x01B11994, "Int32", "Pointers", "Player crew ID pointer"));
            memoryValues.Add(new MemoryValue("Crew Member Pointer", 0x01B119A4, "Int32", "Pointers", "Pointer to crew member ID",
@"+0x00
++0x10 = Crew Member ID
0x014f80c4 = Yumi
0x3f3e465c = Sal
0xa05c48e1 = Colin
0xa58a7d2c = Samson
0xb00f935c = Neville
0xc9191f86 = Nikki"));
            memoryValues.Add(new MemoryValue("Save File Area", 0x01B119B0, "Int32", "Pointers", "This area seems sus, part of save file"));
            memoryValues.Add(new MemoryValue("ASCII 'Crew_Samson'", 0x01B119E4, "Int32", "Pointers", "ASCII Crew_Samson"));
            memoryValues.Add(new MemoryValue("HERE Marker", 0x01B149D0, "Int32", "Pointers", "HERE marker"));
            memoryValues.Add(new MemoryValue("Bye Bye Maker 1", 0x01B149E0, "Int32", "Pointers", "Makes them bye bye"));
            memoryValues.Add(new MemoryValue("Bye Bye Maker 2", 0x01B149EC, "Int32", "Pointers", "Also makes them go bye bye"));
            memoryValues.Add(new MemoryValue("Slow-Mo Flag (Crew Meet)", 0x01FDB10C, "Int32", "Pointers", "Was slow-mo flag when meeting crew member (dynamic)"));

            // Track Statistics
            memoryValues.Add(new MemoryValue("Lincoln Blvd - Top Speed", 0x00A6F5E0, "Int32", "Track Stats", "Lincoln Boulevard highest top speed"));
            memoryValues.Add(new MemoryValue("Lincoln Blvd - Times Played", 0x00A6F5E8, "Int32", "Track Stats", "Lincoln Boulevard times played"));
            memoryValues.Add(new MemoryValue("Lincoln Blvd - Best Time", 0x00A6F5EC, "Int32", "Track Stats", "Lincoln Boulevard best race time"));

            // Territory Owners
            memoryValues.Add(new MemoryValue("(Muscle) Stonewall Tunnel Owner", 0x01F458D0, "Int32", "Territory", "Kempton - Stonewall Tunnel owner"));
            memoryValues.Add(new MemoryValue("Lookout Point (Older Save)", 0x01F45B90, "Int32", "Territory", "Lookout Point on older save"));
            memoryValues.Add(new MemoryValue("(Muscle) Waterfront Road Owner", 0x01F45F90, "Int32", "Territory", "Kempton - Waterfront Road owner",
@"0x01f54ae0 = Player Crew
0x01f4d220 = Scorpios
0x01f4d5e0 = Inferno"));
            memoryValues.Add(new MemoryValue("Agostini Avenue 1 - Map Unlock", 0x01F3DB34, "Int32", "Territory", "Agostini Avenue 1 unlock on map"));
            memoryValues.Add(new MemoryValue("Agostini Avenue 2", 0x01F3E074, "Int32", "Territory", "Agostini Avenue 2"));
            memoryValues.Add(new MemoryValue("Agostini Avenue Race ID 1", 0x01F3E350, "Int32", "Territory", "0x6baae4b5=Agostini Avenue"));
            memoryValues.Add(new MemoryValue("Agostini Avenue 1 - +10 Pointer", 0x01F3E354, "Int32", "Territory", "Agostini Avenue 1 pointer"));
            memoryValues.Add(new MemoryValue("Agostini Avenue 3", 0x01F3E514, "Int32", "Territory", "Agostini Avenue 3"));

            // Race Event Flags - Downtown
            memoryValues.Add(new MemoryValue("Downtown - Lookout Point (Drift)", 0x01B0B504, "Int8", "Race Events - Downtown", "Race flags",
@"bit0 = Challenge Series/Quick Race
bit1 = Career (if 1st)
bit2 = Unlocked
bit5 = Finish Line"));
            memoryValues.Add(new MemoryValue("Downtown - Old Quarter (Drift)", 0x01B0B654, "Int8", "Race Events - Downtown", "Race event"));
            memoryValues.Add(new MemoryValue("Downtown - Main Street (Circuit)", 0x01B0B664, "Int8", "Race Events - Downtown", "Race event"));
            memoryValues.Add(new MemoryValue("Downtown - Kimei Temple (Drift)", 0x01B0B6E4, "Int8", "Race Events - Downtown", "Race event"));
            memoryValues.Add(new MemoryValue("Downtown - Chinatown Tram (Sprint)", 0x01B0B6F4, "Int8", "Race Events - Downtown", "Race event"));
            memoryValues.Add(new MemoryValue("Downtown - Billings District (Drift)", 0x01B0B9A4, "Int8", "Race Events - Downtown", "Race event"));
            memoryValues.Add(new MemoryValue("Downtown - Silk Road (Circuit)", 0x01B0B9B4, "Int8", "Race Events - Downtown", "Race event"));
            memoryValues.Add(new MemoryValue("Downtown - Campbell Tunnel (Circuit)", 0x01B0BC24, "Int8", "Race Events - Downtown", "Race event"));
            memoryValues.Add(new MemoryValue("Downtown - Knight Street (Circuit)", 0x01B0BC44, "Int8", "Race Events - Downtown", "Race event"));
            memoryValues.Add(new MemoryValue("Downtown - Kings Park (Drift)", 0x01B0BCA4, "Int8", "Race Events - Downtown", "Race event"));
            memoryValues.Add(new MemoryValue("Downtown - Mason Street (Sprint)", 0x01B0BD24, "Int8", "Race Events - Downtown", "Race event"));
            memoryValues.Add(new MemoryValue("Downtown - North Road (Circuit)", 0x01B0BD64, "Int8", "Race Events - Downtown", "Race event"));
            memoryValues.Add(new MemoryValue("Downtown - Mason Fountain (Speedtrap)", 0x01B0BD74, "Int8", "Race Events - Downtown", "Race event"));
            memoryValues.Add(new MemoryValue("Downtown - Gold Valley Run (Sprint)", 0x01B0BD84, "Int8", "Race Events - Downtown", "Race event"));
            memoryValues.Add(new MemoryValue("Downtown - Lincoln Boulevard (Sprint)", 0x01B0BEE4, "Int8", "Race Events - Downtown", "Race event"));
            memoryValues.Add(new MemoryValue("Downtown - Lincoln Blvd Best Time", 0x01B0BEE8, "Float", "Race Events - Downtown", "Lincoln Boulevard best time"));
            memoryValues.Add(new MemoryValue("Downtown - Garden Boulevard (Circuit)", 0x01B0BEF4, "Int8", "Race Events - Downtown", "Race event"));
            memoryValues.Add(new MemoryValue("Downtown - Devil's Creek Pass (Sprint)", 0x01B0BBF4, "Int8", "Race Events - Downtown", "Race event"));
            memoryValues.Add(new MemoryValue("Downtown - Park Drive (Speedtrap)", 0x01B0BF64, "Int8", "Race Events - Downtown", "Race event"));

            // Race Event Flags - Kempton
            memoryValues.Add(new MemoryValue("Kempton - Stonewall Tunnel (Speedtrap)", 0x01B0B5C4, "Int8", "Race Events - Kempton", "Race event"));
            memoryValues.Add(new MemoryValue("Kempton - Mission Street (Sprint)", 0x01B0B6A4, "Int8", "Race Events - Kempton", "Race event"));
            memoryValues.Add(new MemoryValue("Kempton - Dover Street (Circuit)", 0x01B0B784, "Int8", "Race Events - Kempton", "Race event"));
            memoryValues.Add(new MemoryValue("Kempton - Knife's Edge (Drift)", 0x01B0B7C4, "Int8", "Race Events - Kempton", "Race event"));
            memoryValues.Add(new MemoryValue("Kempton - Newport Ironworks (Drift)", 0x01B0B804, "Int8", "Race Events - Kempton", "Race event"));
            memoryValues.Add(new MemoryValue("Kempton - Devil's Creek Pass (Drift)", 0x01B0B8B4, "Int8", "Race Events - Kempton", "Race event"));
            memoryValues.Add(new MemoryValue("Kempton - Francis Tunnel (Sprint)", 0x01B0B8C4, "Int8", "Race Events - Kempton", "Race event"));
            memoryValues.Add(new MemoryValue("Kempton - Waterfront Road (Sprint)", 0x01B0B724, "Int8", "Race Events - Kempton", "Race event"));
            memoryValues.Add(new MemoryValue("Kempton - Eskuri Plaza (Checkpoint)", 0x01B0BB44, "Int8", "Race Events - Kempton", "Race event"));
            memoryValues.Add(new MemoryValue("Kempton - Newport Trainyard (Speedtrap)", 0x01B0BB54, "Int8", "Race Events - Kempton", "Race event"));
            memoryValues.Add(new MemoryValue("Kempton - Dover and Lepus (Sprint)", 0x01B0BED4, "Int8", "Race Events - Kempton", "Race event"));
            memoryValues.Add(new MemoryValue("Kempton - Beachfront (Circuit)", 0x01B0BFD4, "Int8", "Race Events - Kempton", "Race event"));
            memoryValues.Add(new MemoryValue("Kempton - Eskuri Way (Speedtrap)", 0x01B0BFE4, "Int8", "Race Events - Kempton", "Race event"));
            memoryValues.Add(new MemoryValue("Kempton - Morgan Beach Offramp (Checkpoint)", 0x01B0BF44, "Int8", "Race Events - Kempton", "Race event"));
            memoryValues.Add(new MemoryValue("Kempton - Petersburg Dam (Sprint)", 0x01B0BF54, "Int8", "Race Events - Kempton", "Race event"));
            memoryValues.Add(new MemoryValue("Kempton - Robinson Bay (Circuit)", 0x01B0BF04, "Int8", "Race Events - Kempton", "Race event"));
            memoryValues.Add(new MemoryValue("Kempton - Foundry Road (Speedtrap)", 0x01B0BEC4, "Int8", "Race Events - Kempton", "Race event"));
            memoryValues.Add(new MemoryValue("Kempton - Kempton Docks (Circuit)", 0x01B0BE24, "Int8", "Race Events - Kempton", "Race event"));
            memoryValues.Add(new MemoryValue("Kempton - Main Street Drift (Drift)", 0x01B0BDD4, "Int8", "Race Events - Kempton", "Race event"));

            // Race Event Flags - Silverton
            memoryValues.Add(new MemoryValue("Silverton - Troy (Checkpoint)", 0x01B0B594, "Int8", "Race Events - Silverton", "Race event"));
            memoryValues.Add(new MemoryValue("Silverton - Starlight Strip (Drift)", 0x01B0B5B4, "Int8", "Race Events - Silverton", "Race event"));
            memoryValues.Add(new MemoryValue("Silverton - Journeyman's Bane (Drift)", 0x01B0B6B4, "Int8", "Race Events - Silverton", "Race event"));
            memoryValues.Add(new MemoryValue("Silverton - Journeyman's Bane (Canyon)", 0x01B0B854, "Int8", "Race Events - Silverton", "Race event"));
            memoryValues.Add(new MemoryValue("Silverton - Savannah Street (Circuit)", 0x01B0B864, "Int8", "Race Events - Silverton", "Race event"));
            memoryValues.Add(new MemoryValue("Silverton - Desperation Ridge (Canyon)", 0x01B0B9E4, "Int8", "Race Events - Silverton", "Race event"));
            memoryValues.Add(new MemoryValue("Silverton - Deadfall Junction (Sprint)", 0x01B0BA84, "Int8", "Race Events - Silverton", "Race event"));
            memoryValues.Add(new MemoryValue("Silverton - Park Drive Drift (Drift)", 0x01B0BA94, "Int8", "Race Events - Silverton", "Race event"));
            memoryValues.Add(new MemoryValue("Silverton - Desperation Ridge (Sprint)", 0x01B0BAA4, "Int8", "Race Events - Silverton", "Race event"));
            memoryValues.Add(new MemoryValue("Silverton - Eagle Drive (Sprint)", 0x01B0BB04, "Int8", "Race Events - Silverton", "Race event"));
            memoryValues.Add(new MemoryValue("Silverton - Lucky Towers (Circuit)", 0x01B0BB24, "Int8", "Race Events - Silverton", "Race event"));
            memoryValues.Add(new MemoryValue("Silverton - Silverton Way (Sprint)", 0x01B0BBB4, "Int8", "Race Events - Silverton", "Race event"));
            memoryValues.Add(new MemoryValue("Silverton - Starlight Street (Sprint)", 0x01B0BC34, "Int8", "Race Events - Silverton", "Race event"));
            memoryValues.Add(new MemoryValue("Silverton - Blackwell Road (Checkpoint)", 0x01B0BCB4, "Int8", "Race Events - Silverton", "Race event"));
            memoryValues.Add(new MemoryValue("Silverton - North Broadway (Circuit)", 0x01B0BD14, "Int8", "Race Events - Silverton", "Race event"));
            memoryValues.Add(new MemoryValue("Silverton - Bowen Avenue (Speedtrap)", 0x01B0BD54, "Int8", "Race Events - Silverton", "Race event"));
            memoryValues.Add(new MemoryValue("Silverton - Canmor Road (Speedtrap)", 0x01B0B7B4, "Int8", "Race Events - Silverton", "Race event"));
            memoryValues.Add(new MemoryValue("Silverton - The Neon Mile (Checkpoint)", 0x01B0B7E4, "Int8", "Race Events - Silverton", "Race event"));
            memoryValues.Add(new MemoryValue("Silverton - Blackwell Bridge (Sprint)", 0x01B0BE44, "Int8", "Race Events - Silverton", "Race event"));
            memoryValues.Add(new MemoryValue("Silverton - Brooks Street (Circuit)", 0x01B0BE54, "Int8", "Race Events - Silverton", "Race event"));
            memoryValues.Add(new MemoryValue("Silverton - Olympic Boulevard (Speedtrap)", 0x01B0BE74, "Int8", "Race Events - Silverton", "Race event"));
            memoryValues.Add(new MemoryValue("Silverton - Paradise Hotel (Circuit)", 0x01B0BE84, "Int8", "Race Events - Silverton", "Race event"));
            memoryValues.Add(new MemoryValue("Silverton - Deadfall Junction (Canyon)", 0x01B0BEB4, "Int8", "Race Events - Silverton", "Race event"));
            memoryValues.Add(new MemoryValue("Silverton - Gray Street (Checkpoint)", 0x01B0BF84, "Int8", "Race Events - Silverton", "Race event"));
            memoryValues.Add(new MemoryValue("Silverton - Spade Street (Sprint)", 0x01B0B554, "Int8", "Race Events - Silverton", "Race event"));

            // Race Event Flags - Fortuna
            memoryValues.Add(new MemoryValue("Fortuna - Condo Row (Circuit)", 0x01B0B534, "Int8", "Race Events - Fortuna", "Race event"));
            memoryValues.Add(new MemoryValue("Fortuna - York Road (Sprint)", 0x01B0B544, "Int8", "Race Events - Fortuna", "Race event"));
            memoryValues.Add(new MemoryValue("Fortuna - Lofty Heights Downhill (Sprint)", 0x01B0B6C4, "Int8", "Race Events - Fortuna", "Race event"));
            memoryValues.Add(new MemoryValue("Fortuna - Mason St. Bridge (Sprint)", 0x01B0B7A4, "Int8", "Race Events - Fortuna", "Race event"));
            memoryValues.Add(new MemoryValue("Fortuna - Fortuna Heights (Drift)", 0x01B0B8F4, "Int8", "Race Events - Fortuna", "Race event"));
            memoryValues.Add(new MemoryValue("Fortuna - Palmont University (Drift)", 0x01B0B934, "Int8", "Race Events - Fortuna", "Race event"));
            memoryValues.Add(new MemoryValue("Fortuna - South Fortuna (Circuit)", 0x01B0B984, "Int8", "Race Events - Fortuna", "Race event"));
            memoryValues.Add(new MemoryValue("Fortuna - Hills Borough Parkway (Checkpoint)", 0x01B0BAD4, "Int8", "Race Events - Fortuna", "Race event"));
            memoryValues.Add(new MemoryValue("Fortuna - Million Dollar Drive (Speedtrap)", 0x01B0BB14, "Int8", "Race Events - Fortuna", "Race event"));
            memoryValues.Add(new MemoryValue("Fortuna - Agostini Avenue (Sprint)", 0x01B0BB74, "Int8", "Race Events - Fortuna", "Race event"));
            memoryValues.Add(new MemoryValue("Fortuna - Shady Pine (Drift)", 0x01B0BB84, "Int8", "Race Events - Fortuna", "Race event"));
            memoryValues.Add(new MemoryValue("Fortuna - Skyline Avenue (Circuit)", 0x01B0BBE4, "Int8", "Race Events - Fortuna", "Race event"));
            memoryValues.Add(new MemoryValue("Fortuna - Verona Tunnel (Sprint)", 0x01B0BC74, "Int8", "Race Events - Fortuna", "Race event"));
            memoryValues.Add(new MemoryValue("Fortuna - University Avenue (Checkpoint)", 0x01B0BC84, "Int8", "Race Events - Fortuna", "Race event"));
            memoryValues.Add(new MemoryValue("Fortuna - Rabinowitz Drive (Checkpoint)", 0x01B0BCD4, "Int8", "Race Events - Fortuna", "Race event"));
            memoryValues.Add(new MemoryValue("Fortuna - City Courthouse (Drift)", 0x01B0BD04, "Int8", "Race Events - Fortuna", "Race event"));
            memoryValues.Add(new MemoryValue("Fortuna - University Way (Circuit)", 0x01B0BD44, "Int8", "Race Events - Fortuna", "Race event"));
            memoryValues.Add(new MemoryValue("Fortuna - Ocean View (Circuit)", 0x01B0BDB4, "Int8", "Race Events - Fortuna", "Race event"));
            memoryValues.Add(new MemoryValue("Fortuna - Lofty Heights Downhill (Drift)", 0x01B0BE14, "Int8", "Race Events - Fortuna", "Race event"));
            memoryValues.Add(new MemoryValue("Fortuna - North Bellezza (Sprint)", 0x01B0BE34, "Int8", "Race Events - Fortuna", "Race event"));

            // Race Event Flags - San Juan
            memoryValues.Add(new MemoryValue("San Juan - Salazar Street (Circuit)", 0x01B0B564, "Int8", "Race Events - San Juan", "Race event"));
            memoryValues.Add(new MemoryValue("San Juan - Royal Avenue (Circuit)", 0x01B0B754, "Int8", "Race Events - San Juan", "Race event"));
            memoryValues.Add(new MemoryValue("San Juan - Mesa Bridge (Sprint)", 0x01B0BC64, "Int8", "Race Events - San Juan", "Race event"));

            // Race Event Flags - Canyon
            memoryValues.Add(new MemoryValue("Canyon - Copper Ridge (Angie Boss)", 0x01B0B674, "Int8", "Race Events - Canyon", "Angie boss canyon race"));
            memoryValues.Add(new MemoryValue("Canyon - Copper Ridge (Sprint)", 0x01B0B704, "Int8", "Race Events - Canyon", "Race event"));
            memoryValues.Add(new MemoryValue("Canyon - Gold Valley Run (Drift)", 0x01B0B714, "Int8", "Race Events - Canyon", "Race event"));
            memoryValues.Add(new MemoryValue("Canyon - Gold Valley Run (Wolf Boss)", 0x01B0B8A4, "Int8", "Race Events - Canyon", "Wolf boss canyon race"));
            memoryValues.Add(new MemoryValue("Canyon - Eternity Pass (Sprint)", 0x01B0B964, "Int8", "Race Events - Canyon", "Race event"));
            memoryValues.Add(new MemoryValue("Canyon - Journeyman's Bane (Sprint)", 0x01B0B974, "Int8", "Race Events - Canyon", "Race event"));
            memoryValues.Add(new MemoryValue("Canyon - Desperation Ridge (Drift)", 0x01B0B9C4, "Int8", "Race Events - Canyon", "Race event"));
            memoryValues.Add(new MemoryValue("Canyon - Knife's Edge (Sprint)", 0x01B0BA44, "Int8", "Race Events - Canyon", "Race event"));
            memoryValues.Add(new MemoryValue("Canyon - Deadfall Junction (Drift)", 0x01B0BAE4, "Int8", "Race Events - Canyon", "Race event"));
            memoryValues.Add(new MemoryValue("Canyon - Knife's Edge (Canyon)", 0x01B0BBD4, "Int8", "Race Events - Canyon", "Race event"));
            memoryValues.Add(new MemoryValue("Canyon - Devil's Creek Pass (Canyon)", 0x01B0BC04, "Int8", "Race Events - Canyon", "Race event"));
            memoryValues.Add(new MemoryValue("Canyon - Copper Ridge (Drift)", 0x01B0BDA4, "Int8", "Race Events - Canyon", "Race event"));
            memoryValues.Add(new MemoryValue("Canyon - Lookout Point (Sprint)", 0x01B0BE64, "Int8", "Race Events - Canyon", "Race event"));
            memoryValues.Add(new MemoryValue("Canyon - Lookout Point (Kenji Boss)", 0x01B0BEA4, "Int8", "Race Events - Canyon", "Kenji boss canyon race"));
            memoryValues.Add(new MemoryValue("Canyon - Lofty Heights Downhill (Canyon)", 0x01B0BF14, "Int8", "Race Events - Canyon", "Race event"));
            memoryValues.Add(new MemoryValue("Canyon - Eternity Pass (Drift)", 0x01B0BFA4, "Int8", "Race Events - Canyon", "Race event"));
            memoryValues.Add(new MemoryValue("Eternity Pass (Canyon)", 0x01B0BD34, "Int8", "Race Events - Canyon", "Race event"));

            // Challenge Series Events
            memoryValues.Add(new MemoryValue("CS - CE Race Wars Circuit (Gold)", 0x01B0B514, "Int8", "Challenge Series", "Collector's Edition Race Wars Circuit Gold"));
            memoryValues.Add(new MemoryValue("CS - Canyon Duel (Bronze)", 0x01B0B5A4, "Int8", "Challenge Series", "Canyon Duel Bronze"));
            memoryValues.Add(new MemoryValue("CS - Checkpoint (Silver)", 0x01B0B604, "Int8", "Challenge Series", "Checkpoint Silver"));
            memoryValues.Add(new MemoryValue("CS - Drift (Gold)", 0x01B0B614, "Int8", "Challenge Series", "Drift Gold"));
            memoryValues.Add(new MemoryValue("CS - CE Challenge (Bronze)", 0x01B0B624, "Int8", "Challenge Series", "CE Challenge Bronze"));
            memoryValues.Add(new MemoryValue("CS - Canyon Drift (Silver)", 0x01B0B634, "Int8", "Challenge Series", "Canyon Drift Silver"));
            memoryValues.Add(new MemoryValue("CS - Sprint (Bronze)", 0x01B0B684, "Int8", "Challenge Series", "Sprint Bronze"));
            memoryValues.Add(new MemoryValue("CS - Race Wars (Bronze)", 0x01B0B694, "Int8", "Challenge Series", "Race Wars Bronze"));
            memoryValues.Add(new MemoryValue("CS - Checkpoint (Bronze)", 0x01B0B734, "Int8", "Challenge Series", "Checkpoint Bronze"));
            memoryValues.Add(new MemoryValue("CS - CE Checkpoint (Bronze)", 0x01B0B764, "Int8", "Challenge Series", "CE Checkpoint Bronze"));
            memoryValues.Add(new MemoryValue("CS - Canyon Checkpoint (Bronze)", 0x01B0B774, "Int8", "Challenge Series", "Canyon Checkpoint Bronze"));
            memoryValues.Add(new MemoryValue("CS - Pursuit Evasion (Silver)", 0x01B0B7D4, "Int8", "Challenge Series", "Pursuit Evasion Silver"));
            memoryValues.Add(new MemoryValue("CS - CE Checkpoint (Silver)", 0x01B0B7F4, "Int8", "Challenge Series", "CE Checkpoint Silver"));
            memoryValues.Add(new MemoryValue("CS - Canyon Race (Silver)", 0x01B0B814, "Int8", "Challenge Series", "Canyon Race Silver"));
            memoryValues.Add(new MemoryValue("CS - Canyon Checkpoint (Silver)", 0x01B0B824, "Int8", "Challenge Series", "Canyon Checkpoint Silver"));
            memoryValues.Add(new MemoryValue("CS - Speedtrap (Silver)", 0x01B0B834, "Int8", "Challenge Series", "Speedtrap Silver"));
            memoryValues.Add(new MemoryValue("CS - CE Challenge (Gold)", 0x01B0B844, "Int8", "Challenge Series", "CE Challenge Gold"));
            memoryValues.Add(new MemoryValue("CS - Trade Paint (Bronze)", 0x01B0B894, "Int8", "Challenge Series", "Trade Paint Bronze"));
            memoryValues.Add(new MemoryValue("CS - CE Checkpoint (Gold)", 0x01B0B904, "Int8", "Challenge Series", "CE Checkpoint Gold"));
            memoryValues.Add(new MemoryValue("CS - CE Race Wars Circuit (Silver)", 0x01B0B924, "Int8", "Challenge Series", "CE Race Wars Circuit Silver"));
            memoryValues.Add(new MemoryValue("CS - CE Race Wars Circuit (Bronze)", 0x01B0B944, "Int8", "Challenge Series", "CE Race Wars Circuit Bronze"));
            memoryValues.Add(new MemoryValue("CS - Canyon Duel (Silver)", 0x01B0B9D4, "Int8", "Challenge Series", "Canyon Duel Silver"));
            memoryValues.Add(new MemoryValue("CS - Circuit (Bronze)", 0x01B0B9F4, "Int8", "Challenge Series", "Circuit Bronze"));
            memoryValues.Add(new MemoryValue("CS - Canyon Race (Bronze)", 0x01B0BA04, "Int8", "Challenge Series", "Canyon Race Bronze"));
            memoryValues.Add(new MemoryValue("CS - Pursuit Evasion (Bronze)", 0x01B0BA14, "Int8", "Challenge Series", "Pursuit Evasion Bronze"));
            memoryValues.Add(new MemoryValue("CS - Checkpoint (Gold)", 0x01B0BA24, "Int8", "Challenge Series", "Checkpoint Gold"));
            memoryValues.Add(new MemoryValue("CS - Canyon Duel (Gold)", 0x01B0BA54, "Int8", "Challenge Series", "Canyon Duel Gold"));
            memoryValues.Add(new MemoryValue("CS - Canyon Drift (Bronze)", 0x01B0BA64, "Int8", "Challenge Series", "Canyon Drift Bronze"));
            memoryValues.Add(new MemoryValue("CS - Canyon Race (Gold)", 0x01B0BAC4, "Int8", "Challenge Series", "Canyon Race Gold"));
            memoryValues.Add(new MemoryValue("CS - Race Wars (Silver)", 0x01B0BAF4, "Int8", "Challenge Series", "Race Wars Silver"));
            memoryValues.Add(new MemoryValue("CS - Sprint (Gold)", 0x01B0BB34, "Int8", "Challenge Series", "Sprint Gold"));
            memoryValues.Add(new MemoryValue("CS - Canyon Drift (Gold)", 0x01B0BB64, "Int8", "Challenge Series", "Canyon Drift Gold"));
            memoryValues.Add(new MemoryValue("CS - CE Challenge (Silver)", 0x01B0BB94, "Int8", "Challenge Series", "CE Challenge Silver"));
            memoryValues.Add(new MemoryValue("CS - Circuit (Gold)", 0x01B0BC54, "Int8", "Challenge Series", "Circuit Gold"));
            memoryValues.Add(new MemoryValue("CS - Canyon Checkpoint (Gold)", 0x01B0BC94, "Int8", "Challenge Series", "Canyon Checkpoint Gold"));
            memoryValues.Add(new MemoryValue("CS - Circuit (Silver)", 0x01B0BCC4, "Int8", "Challenge Series", "Circuit Silver"));
            memoryValues.Add(new MemoryValue("CS - Trade Paint (Silver)", 0x01B0BCE4, "Int8", "Challenge Series", "Trade Paint Silver"));
            memoryValues.Add(new MemoryValue("CS - Race Wars (Gold)", 0x01B0BDC4, "Int8", "Challenge Series", "Race Wars Gold"));
            memoryValues.Add(new MemoryValue("CS - Drift (Silver)", 0x01B0BDE4, "Int8", "Challenge Series", "Drift Silver"));
            memoryValues.Add(new MemoryValue("CS - Sprint (Silver)", 0x01B0BF24, "Int8", "Challenge Series", "Sprint Silver"));
            memoryValues.Add(new MemoryValue("CS - Drift (Bronze)", 0x01B0BF34, "Int8", "Challenge Series", "Drift Bronze"));
            memoryValues.Add(new MemoryValue("CS - Trade Paint (Gold)", 0x01B0BF74, "Int8", "Challenge Series", "Trade Paint Gold"));
            memoryValues.Add(new MemoryValue("CS - Speedtrap (Gold)", 0x01B0BF94, "Int8", "Challenge Series", "Speedtrap Gold"));
            memoryValues.Add(new MemoryValue("CS - Speedtrap (Bronze)", 0x01B0BFB4, "Int8", "Challenge Series", "Speedtrap Bronze"));
            memoryValues.Add(new MemoryValue("CS - Pursuit Evasion (Gold)", 0x01B0BFC4, "Int8", "Challenge Series", "Pursuit Evasion Gold"));

            return memoryValues;
        }
    }
}
