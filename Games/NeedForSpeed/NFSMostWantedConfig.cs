using Common;
using System.Collections.Generic;

namespace Games.NeedForSpeed
{
    public class NFSMostWantedConfig : IGameMemoryConfig
    {
        public string GameName => "Need for Speed: Most Wanted - Black Edition (PS2)";

        public List<MemoryValue> GetMemoryValues()
        {
            var memoryValues = new List<MemoryValue>();

            // Game State & Mode
            memoryValues.Add(new MemoryValue("Single Player Check", 0x0053C6F0, "Int8", "Game State", "0x00=Not Ingame, 0x01=1P Ingame, 0x02=2P Ingame",
@"0x00 = Not Ingame
0x01 = 1P Ingame
0x02 = 2P Ingame"));
            memoryValues.Add(new MemoryValue("In-game Check", 0x00575D10, "Int8", "Game State", "0x01=In-game"));
            memoryValues.Add(new MemoryValue("Main Menu Check", 0x0056E9B0, "Int8", "Game State", "0x01=In Main Menu, Car Shop, etc."));
            memoryValues.Add(new MemoryValue("Main Menu Selection", 0x0056F574, "Int8", "Game State", "0x01=Career, 0x02=Challenge Series, 0x03=Quick Race, 0x04=My Cars, 0x05=Alias Manager, 0x06=Options",
@"0x01 = Career
0x02 = Challenge Series
0x03 = Quick Race
0x04 = My Cars
0x05 = Alias Manager
0x06 = Options"));
            memoryValues.Add(new MemoryValue("Event Mode", 0x005415F0, "Int8", "Game State", "0x00=TollBooth, 0x01=In-game, 0x02=Transition, 0x03=Circuit/Sprint/Speedtrap/Lap Knockout",
@"0x00 = TollBooth
0x01 = In-game
0x02 = Transition from modes other than TollBooth to the Race Event menu
0x03 = Circuit/Sprint/Speedtrap/Lap Knockout"));
            memoryValues.Add(new MemoryValue("Cutscene Flag", 0x00541290, "Int8", "Game State", "Active during cutscenes"));
            memoryValues.Add(new MemoryValue("Pause Flag", 0x0056DC24, "Int32", "Game State", "Game paused status"));
            memoryValues.Add(new MemoryValue("Restart Flag", 0x0056E3CC, "Int8", "Game State", "0x01=Restart after finishing a race"));
            memoryValues.Add(new MemoryValue("Memory Card Check", 0x005D9A98, "Int8", "Game State", "0x00=Initial, 0x01=Memory Card in use"));

            // Race & Event Info
            memoryValues.Add(new MemoryValue("Boss Race Check", 0x00536924, "Int8", "Race Info", "0x00=Initial, 0x01=In a Race Event (not Tollbooth/Speedtrap)",
@"0x00 = Initial value
0x01 = In a Race Event

Note: Not a Tollbooth or Speedtrap. Works on boss races that are speedtraps."));
            memoryValues.Add(new MemoryValue("Selected Blacklist Member", 0x0056D888, "Int8", "Race Info", "Currently selected blacklist member"));
            memoryValues.Add(new MemoryValue("Boss Event/Track ID", 0x0056D88C, "Int16", "Race Info", "Boss race track ID",
@"Razor (Blacklist #1):
0x36A4 = Razor Race 6
0x277C = Razor Race 7
0x32E4 = Razor Race 11

Bull (Blacklist #2):
0x2BC8 = Bull Race 3
0x32D0 = Bull Race 4
0x2B50 = Bull Race 5

Ronnie (Blacklist #3):
0x31A4 = Ronnie Race 4
0x2920 = Ronnie Race 9
0x30DC = Ronnie Race 10

JV (Blacklist #4):
0x34B0 = JV Race 1
0x30C8 = JV Race 10
0x3370 = JV Race 11

Webster (Blacklist #5):
0x2B00 = Webster Race 6
0x3780 = Webster Race 9
0x3348 = Webster Race 10

Ming (Blacklist #6):
0x3640 = Ming Race 2
0x28F8 = Ming Race 5
0x37F8 = Ming Race 11

Kaze (Blacklist #7):
0x29FC = Kaze Race 2
0x2C2C = Kaze Race 4
0x35DC = Kaze Race 9

Jewels (Blacklist #8):
0x3974 = Jewels Race 6
0x3550 = Jewels Race 7

Earl (Blacklist #9):
0x37A8 = Earl Race 3
0x308C = Earl Race 6

Baron (Blacklist #10):
0x34EC = Baron Race 3
0x37D0 = Baron Race 4

Big Lou (Blacklist #11):
0x38FC = Big L Race 4
0x3118 = Big L Race 5

Izzy (Blacklist #12):
0x28A8 = Izzy Race 2
0x2FD8 = Izzy Race 3

Vic (Blacklist #13):
0x38C0 = Vic Race 4
0x2984 = Vic Race 5

Taz (Blacklist #14):
0x2984 = Taz Race 5"));
            memoryValues.Add(new MemoryValue("Overlay Type", 0x00532610, "Int8", "Race Info", "0x00=First Place, 0x02=Photo Ticket",
@"0x00 = First Place
0x02 = Photo Ticket"));

            // Player Performance
            memoryValues.Add(new MemoryValue("Speed (MPH)", 0x005418F0, "Float", "Performance", "Current speed in MPH"));
            memoryValues.Add(new MemoryValue("Player X Coordinate", 0x00579350, "Float", "Performance", "Player X position"));
            memoryValues.Add(new MemoryValue("Player Y Coordinate", 0x00579358, "Float", "Performance", "Player Y position"));
            memoryValues.Add(new MemoryValue("Player Z Coordinate", 0x00579354, "Float", "Performance", "Player Z position"));
            memoryValues.Add(new MemoryValue("Player Rotation", 0x0057934C, "Float", "Performance", "Player rotation angle"));

            // Race Start Position
            memoryValues.Add(new MemoryValue("Race Start X Coordinate", 0x00538010, "Float", "Race Start", "Starting position X"));
            memoryValues.Add(new MemoryValue("Race Start Y Coordinate", 0x00538014, "Float", "Race Start", "Starting position Y"));
            memoryValues.Add(new MemoryValue("Race Start Z Coordinate", 0x00538018, "Float", "Race Start", "Starting position Z"));
            memoryValues.Add(new MemoryValue("Race Start Rotation", 0x00538020, "Int32", "Race Start", "Starting rotation"));

            // Current Pursuit Stats
            memoryValues.Add(new MemoryValue("Current Pursuit - Timer", 0x0056E44C, "Float", "Current Pursuit", "Pursuit timer"));
            memoryValues.Add(new MemoryValue("Current Pursuit - Damaged Vehicles", 0x0056E450, "Int32", "Current Pursuit", "Police vehicles damaged"));
            memoryValues.Add(new MemoryValue("Current Pursuit - Immobilized Vehicles", 0x0056E454, "Int32", "Current Pursuit", "Police vehicles immobilized"));
            memoryValues.Add(new MemoryValue("Current Pursuit - Spike Strips Dodged", 0x0056E458, "Int32", "Current Pursuit", "Spike strips dodged"));
            memoryValues.Add(new MemoryValue("Current Pursuit - Roadblocks Dodged", 0x0056E45C, "Int32", "Current Pursuit", "Roadblocks dodged"));
            memoryValues.Add(new MemoryValue("Current Pursuit - Cost to State", 0x0056E460, "Int32", "Current Pursuit", "Cost to state"));
            memoryValues.Add(new MemoryValue("Current Pursuit - Bounty", 0x0056E464, "Int32", "Current Pursuit", "Bounty (reputation score)"));
            memoryValues.Add(new MemoryValue("Current Pursuit - Bounty (Immobilized)", 0x0056E468, "Int32", "Current Pursuit", "Bounty from immobilized cops"));
            memoryValues.Add(new MemoryValue("Pursuit State", 0x00575CB0, "Int8", "Current Pursuit", "0x00=Initial, 0x01=State 1, 0x02=State 2 (Post-Race)"));

            // Current Car
            memoryValues.Add(new MemoryValue("Current Car ID", 0x005A3B68, "Int8", "Current Car", "Current car ID (see notes for car list)",
@"0x00 = Porsche 911 Turbo S
0x01 = Porsche Carrera GT
0x02 = Dodge Viper SRT10
0x03 = Police Civic Cruiser
0x05 = Mazda RX-8
0x06 = Subaru Impreza WRX STi
0x07 = Mitsubishi Lancer Evolution VIII
0x08 = Mustang GT
0x09 = Chevrolet Camaro SS
0x0B = Pontiac GTO
0x0C = Mercedes-Benz SLR McLaren
0x0F = Chevrolet Corvette C6
0x14 = Audi TT 3.2 quattro
0x15 = Audi A3 3.2 quattro
0x16 = BMW M3 GTR
0x17 = Mercedes-Benz SL 500
0x18 = Porsche 911 Carrera S
0x28 = Porsche 911 GT2
0x29 = BMW M3 GTR GT
0x2F = Lexus IS 300
0x30 = Vauxhall Monaro VXR
0x31 = Mercedes-Benz SL 65 AMG
0x32 = Lotus Elise
0x34 = Ford GT
0x35 = Mitsubishi Eclipse
0x36 = Toyota Supra
0x37 = Chevrolet Corvette C6.R
0x38 = Mazda RX-7
0x3B = Lamborghini Murcielago
0x3C = Audi A4 3.2 FSI quattro
0x3E = Volkswagen Golf GTI
0x3F = Porsche Cayman S
0x40 = Mercedes-Benz SL 500
0x41 = Cadillac CTS
0x42 = Aston Martin DB9
0x43 = Lamborghini Gallardo
0x44 = Chevrolet Cobalt SS
0x46 = Renault Clio V6
0x4A = Fiat Punto

Note: Useful in Car Shop."));

            // Shop Info
            memoryValues.Add(new MemoryValue("In Shop Check", 0x005A40BC, "Int8", "Shop", "0x00=Outside, 0x01=In Shop"));
            memoryValues.Add(new MemoryValue("Shop - Tires", 0x005A402C, "Int8", "Shop", "0x03=Max Stock, 0x01=Max Pink Slip"));
            memoryValues.Add(new MemoryValue("Shop - Brakes", 0x005A4030, "Int8", "Shop", "0x04=Max Stock, 0x02=Max Pink Slip"));
            memoryValues.Add(new MemoryValue("Shop - Suspension", 0x005A4034, "Int8", "Shop", "0x03=Max Stock, 0x01=Max Pink Slip"));
            memoryValues.Add(new MemoryValue("Shop - Transmission", 0x005A4038, "Int8", "Shop", "0x04=Max Stock, 0x02=Max Pink Slip"));
            memoryValues.Add(new MemoryValue("Shop - Engine", 0x005A403C, "Int8", "Shop", "0x04=Max Stock, 0x02=Max Pink Slip"));
            memoryValues.Add(new MemoryValue("Shop - Turbo", 0x005A4040, "Int8", "Shop", "0x03=Max Stock, 0x01=Max Pink Slip"));
            memoryValues.Add(new MemoryValue("Shop - Nitrous", 0x005A4044, "Int8", "Shop", "0x03=Max Stock, 0x01=Max Pink Slip"));
            memoryValues.Add(new MemoryValue("Shop - Junkman Parts", 0x005A4048, "Int8", "Shop", "Junkman parts bitflags, 0x1d=All installed"));

            // Quick Race Menu
            memoryValues.Add(new MemoryValue("Quick Race Sub-Menu", 0x005A3E78, "Int8", "Quick Race", "0x00=Quick Play, 0x01=Single Player, 0x02=Split Screen"));

            // Cheats
            memoryValues.Add(new MemoryValue("Burger King Challenge Cheat", 0x00574228, "Int32", "Cheats", "Burger King Challenge entered"));
            memoryValues.Add(new MemoryValue("Syntec Ford GT Cheat", 0x00574264, "Int8", "Cheats", "0x00=Initial, 0x01=Unlocked"));
            memoryValues.Add(new MemoryValue("Junkman Part Cheat", 0x005742A0, "Int8", "Cheats", "0x00=Initial, 0x01=Unlocked"));

            // Pointers (Base Addresses - use with offsets)
            memoryValues.Add(new MemoryValue("Post-Pursuit Results Pointer", 0x00531D80, "Int32", "Pointers", "Pointer to post-pursuit results screen"));
            memoryValues.Add(new MemoryValue("Overlay Pointer", 0x005325F0, "Int32", "Pointers", "Pointer to overlay data"));
            memoryValues.Add(new MemoryValue("Tollbooth ID Pointer", 0x00537C70, "Int32", "Pointers", "Pointer to tollbooth data (+0x1c=Event ID)",
@"+0x1C | [8-bit] Toolbooth Event ID
  0x0F = Toolbooth

Note: Pointer value nulls out when not in-game."));
            memoryValues.Add(new MemoryValue("Steering/Gas Pointer", 0x0053FBF8, "Int32", "Pointers", "Pointer (+0x1dc=Steering, +0x1f0=Gas/Reverse)"));
            memoryValues.Add(new MemoryValue("GameSession Pointer", 0x0056F0EC, "Int32", "Pointers", "Pointer to PlayerProfile (+0x1c) with extensive car/career data",
@"This pointer holds GameSession object.
+0x1c | Pointer to PlayerProfile

PlayerProfile offsets:
+0x00 | [6-bytes] [ASCII] Player Name
+0xE4 | [8-Bit] Current Car Slot in Career Mode
  0x51 = Cobalt SS, 0x53 = IS 300, 0x52 = Golf GTI
  0x65 = M3 GTR, 0x57 = Eclipse, 0x54 = Supra
  0x5A = Mustang GT, 0x55 = RX-8, 0x59 = Lancer Evo VIII
  0x58 = Cayman S, 0x5B = CLK 500, 0x60 = DB9
  0x5F = Viper SRT 10, 0x5C = Gallardo, 0x5D = Corvette C6
  0x62 = Mercedes-Benz SLR McLaren

----- Main Unlocks -----
+0xE8 | Main Unlocks #1
  Bit0 = Started Career
  Bit1 = Chose Starter Car
  Bit4 = Unlocked Rap Sheet
  Bit5 = Unlocked Blacklist

+0xE9 | Main Unlocks #2
  Bit0 = Viewed Tollbooth Tutorial
  Bit1 = Viewed Bounty Tutorial
  Bit6 = Beat the Game
  Bit7 = Completed Challenge Series 68

+0xEA | Main Unlocks #3
  Bit0 = 100% Challenge Series Completion
  Bit2 = Castrol Syntec Ford GT

+0xEC | Current Blacklist Member
  0x01=Razor, 0x02=Bull, 0x03=Ronnie, 0x04=JV
  0x05=Webster, 0x06=Ming, 0x07=Kaze, 0x08=Jewels
  0x09=Earl, 0x0A=Baron, 0x0B=Big Lou, 0x0C=Izzy
  0x0D=Vic, 0x0E=Taz, 0x0F=Sonny

+0xF0 | [32-bit] Money
+0x18A | [8-bit] Unlocked Camden Beach Voice Message
+0x18B | 02=Received Message, 04=Read Message

----- Car Parts Unlocks (Car 1 example, pattern repeats every 0x198 bytes for Cars 2-25) -----
+0x45DC | [8-bit] Car 1 - Current Rims
+0x45F2 | [8-bit] Car 1 - Current Vinyl
+0x4670 | [8-bit] Car 1 - Current Tires
+0x4674 | [8-bit] Car 1 - Current Brakes
+0x4678 | [8-bit] Car 1 - Current Suspension
+0x467C | [8-bit] Car 1 - Current Transmission
+0x4680 | [8-bit] Car 1 - Current Engine
+0x4684 | [8-bit] Car 1 - Current Turbo/Supercharger
+0x4688 | [8-bit] Car 1 - Current Nitrous
+0x468C | [8-bit] Car 1 - Junkman Parts Equipped
  Bit0=Tires, Bit1=Brakes, Bit2=Suspension, Bit3=Transmission
  Bit4=Engine, Bit5=Turbo, Bit6=Nitrous

----- Car 4 Extended Data (has extra fields) -----
+0x4A20 | [32-bit] Car 4 ID
  0x0D590D58=Lexus IS300, 0x0F850F84=Fiat Punto
  0x24522451=Cobalt SS, 0x03BC03BB=VW Golf GTI
  0x017F017E=Audi TT 3.2 quattro, 0x00010000=Audi A3 3.2 quattro
  0x25112510=Mitsubishi Eclipse, 0x00C000BF=Audi A4 3.2 FSI quattro
+0x4A4E | [8-bit] Car 4 - Current Body Kit
+0x4A78 | [8-bit] Car 4 - Current Spoiler
+0x4A9C | [8-bit] Car 4 - Current Roof Scoop
+0x4A9E | [8-bit] Car 4 - Current Hood
+0x4AB8 | [8-bit] Car 4 - Current Paint Color
+0x4ABC | [8-bit] Car 4 - Current Rim Paint Color
+0x4ABE | [8-bit] Car 4 - Current Vinyl Color 1
+0x4AC0 | [8-bit] Car 4 - Current Vinyl Color 2
+0x4AC6 | [8-bit] Car 4 - Current Windshield Decal
+0x4B26 | [8-bit] Car 4 - Current Window Tint
+0x4BB4 | [8-bit] Car 4 State (0x22=Owned, 0xFF=Not Owned)

----- Car 2 Performance Tuning -----
+0x4828 | [Float] Performance Tuning - Steering
+0x482C | [Float] Performance Tuning - Handling
+0x4830 | [Float] Performance Tuning - Brakes
+0x4834 | [Float] Performance Tuning - Ride Height
+0x4838 | [Float] Performance Tuning - Aerodynamics
+0x483C | [Float] Performance Tuning - Nitrous
+0x4840 | [Float] Performance Tuning - Turbo

----- Car Bounty / Impound Strikes (Car 1 example, every 0x38 bytes for Cars 2-25) -----
+0x8B78 | [8-bit] Car 1 - Car Number
+0x8B7A | [8-bit] Car 1 - Extra Impound Strikes (up to 5)
+0x8B7B | [8-bit] Car 1 - Impound Strikes
+0x8B7C | [8-bit] Car 1 - Bit1=Impounded
+0x8B84 | [8-bit] Car 1 - Float Heat Level
+0x8B88 | [32-bit] Car 1 - Bounty
+0x8B90 | [16 Bytes] Car 1 - 16bit Unserved Infractions
+0x8BA0 | [16 Bytes] Car 1 - 16bit Served Infractions
+0x90F0 | [32-bit] Sold Cars - Bounty
+0x90F8 | [32 Bytes] Sold Cars - 16bit Infractions

----- Rap Sheet (Lifetime) -----
+0x9C60 | [32-bit] Pursuit Length in Milliseconds
+0x9C64 | [32-bit] Police Vehicles Involved
+0x9C68 | [32-bit] Police Vehicles Damaged
+0x9C6C | [32-bit] Police Vehicles Immobilized
+0x9C70 | [32-bit] Spike Strips Dodged
+0x9C74 | [32-bit] Roadblocks Dodged
+0x9C78 | [32-bit] Helicopters Deployed
+0x9C7C | [32-bit] Cost to State

----- Quick Race Settings -----
+0x24 | Quick Race - Game type
  0x00=Sprint, 0x01=Circuit, 0x02=Drag
  0x03=Lap Knockout, 0x04=Tollbooth, 0x05=Speedtrap
Sprint: +0x24=Track ID, +0x34=Opponents, +0x35=Difficulty, +0x37=Traffic, +0x38=Catch Up
Circuit: +0x4C=Track ID, +0x58=Opponents, +0x59=Difficulty, +0x5B=Traffic, +0x5C=Catch Up
Drag: +0x70=Track ID
Lap Knockout: +0x94=Track ID
Tollbooth: +0xB8=Track ID
Speedtrap: +0xB8=Track ID"));
            memoryValues.Add(new MemoryValue("Reward Marker Pointer", 0x0056F81C, "Int32", "Pointers", "Pointer to reward markers (6 sets of ID+Selected)",
@"+0x78 | [8-bit] Reward Marker 1 ID
  0x11 = Get out of jail for free
  0x12 = Pink Slip
  0x13 = Extra Cash Reward
  0x14 = Extra impound strike
  0x15 = Release car from impound
+0x80 | [8-bit] Reward Marker 1 Selected

+0x84/0x8C = Marker 2 ID/Selected
+0x90/0x98 = Marker 3 ID/Selected
+0x9C/0xA4 = Marker 4 ID/Selected
+0xA8/0xB0 = Marker 5 ID/Selected
+0xB4/0xBC = Marker 6 ID/Selected"));
            memoryValues.Add(new MemoryValue("Race Wins/Milestones Pointer", 0x00570E6C, "Int32", "Pointers", "Pointer (+0x24) to blacklist progress data",
@"+0x24 | Pointer to Number of Race Wins and Milestones

Blacklist Progress Offsets:
#15 Sonny: +0xC0 Milestones, +0xC2 Race Wins
#14 Taz: +0x1D8 Milestones, +0x1DA Race Wins
#13 Vic: +0x1A0 Milestones, +0x1A2 Race Wins
#12 Izzy: +0x1F4 Milestones, +0x1F6 Race Wins
#11 Big Lou: +0x1BC Milestones, +0x1BE Race Wins
#10 Baron: +0x210 Milestones, +0x212 Race Wins
#9 Earl: +0x114 Milestones, +0x116 Race Wins
#8 Jewels: +0x34 Milestones, +0x36 Race Wins
#7 Kaze: +0x22C Milestones, +0x22E Race Wins
#6 Ming: +0xDC Milestones, +0xDE Race Wins
#5 Webster: +0xA4 Milestones, +0xA6 Race Wins
#4 JV: +0x88 Milestones, +0x8A Race Wins
#3 Ronnie: +0x14C Milestones, +0x14E Race Wins
#2 Bull: +0x130 Milestones, +0x132 Race Wins
#1 Razor: +0xF8 Milestones, +0xFA Race Wins

+0x3C | Pointer to Race Flags & Best Time/Best Total Speed (in KM/H)
Race entries: [Bit0]=Completed Flag, +0x04=[Float] Best Time/Speed

----- Tutorial/Prologue (Bit1 Events) -----
+0xF34 [Bit1] Tutorial - Race 1
+0xF44 [Bit1] Prologue (vs. Razor 2)
+0xF54 [Bit1] Prologue (vs. Razor 1)
+0xF64 [Bit1] Prologue (vs. Ronnie)
+0xF74 [Bit1] Prologue (vs. Bull)
+0xF84 [Bit1] Prologue (vs. Rog)

----- Challenge Series (68 total) -----
+0x2E4 CS1, +0x544 CS2, +0xB24 CS3, +0xB74 CS4
+0xC94 CS5, +0xBA4 CS6, +0xDC4 CS7, +0xE24 CS8
+0xC34 CS9, +0xD04 CS10, +0xB84 CS11, +0xC44 CS12
+0xCF4 CS13, +0xE94 CS14, +0xF14 CS15, +0xDE4 CS16
+0xC84 CS17, +0xE64 CS18, +0xD74 CS19, +0xD94 CS20
+0xD24 CS21, +0xCA4 CS22, +0xEB4 CS23, +0xD44 CS24
+0xD34 CS25, +0xDB4 CS26, +0xE34 CS27, +0xDA4 CS28
+0xB44 CS29, +0xE04 CS30, +0xBB4 CS31, +0xBF4 CS32
+0xC54 CS33, +0xC24 CS34, +0xE74 CS35, +0xF04 CS36
+0xD64 CS37, +0xEF4 CS38, +0xB54 CS39, +0xB64 CS40
+0xEC4 CS41, +0xED4 CS42, +0xE14 CS43, +0xC04 CS44
+0xCB4 CS45, +0xBC4 CS46, +0xEE4 CS47, +0xE84 CS48
+0xBD4 CS49, +0xB14 CS50, +0xC64 CS51, +0xDD4 CS52
+0xCC4 CS53, +0xEA4 CS54, +0xE44 CS55, +0xD84 CS56
+0xB04 CS57, +0xB34 CS58, +0xD14 CS59, +0xD54 CS60
+0xB94 CS61, +0xCE4 CS62, +0xC74 CS63, +0xE54 CS64
+0xBE4 CS65, +0xCD4 CS66, +0xDF4 CS67, +0xC14 CS68

Note: +0xA34 also used by Baron Race 7 - North Bay & Seaside (Speedtrap)
AND Burger King challenge for some reason."));
            memoryValues.Add(new MemoryValue("Infraction Bitflags Pointer", 0x00570F54, "Int32", "Pointers", "Pointer (+0x00) to infraction bitflags",
@"+0x00 | [8-bit] Infraction Bitflags
  Bit0 = Speeding
  Bit1 = Excessive Speeding
  Bit2 = Reckless Driving
  Bit3 = Ramming a Police Vehicle
  Bit4 = Hit & Run
  Bit5 = Damage to Property
  Bit6 = Resisting Arrest
  Bit7 = Driving off Roadway"));
            memoryValues.Add(new MemoryValue("Pursuit System Pointer", 0x00575CB8, "Int32", "Pointers", "Pointer to pursuit data (timer, busted, cooldown, etc.)",
@"+0x0B0 = [Float] Timer
+0x0DC = [Float] Busted Timer (Busted at > 5.0)
+0x100 = [Float] Cooldown Timer (Escaped = 1.0)
+0x114 = [Float] Busted Meter (Getting Busted = 0.5, Cooldown = -1.0)
+0x144 = [32-Bit] Immobilized Police Vehicles
+0x15C = [32-Bit] Roadblocks Dodged
+0x164 = [32-Bit] Damaged Police Vehicles
+0x174 = [32-Bit] Spike Strips Dodged
+0x17C = [32-Bit] Cost to State (starts at 4750)"));
            memoryValues.Add(new MemoryValue("Race Start Pointer", 0x00575D18, "Int32", "Pointers", "Pointer to race start (+0x2D8 perfect start, +0x32c countdown, +0x314 police)",
@"+0x2D8 | Pointer to Race Start
  +0x070 [8-bit] Perfect Start Flag (0=Initial, 1=Perfect)

+0x32C | Pointer to Race Countdown
  +0x04C | [8-bit] Countdown

+0x314 | Pointer to Current Number of Police Cars
  +0x70 | [16-bit] Police Cars Involved
  +0x74 | [8-bit] Helicopters Deployed"));
            memoryValues.Add(new MemoryValue("Track ID Pointer", 0x00575D30, "Int32", "Pointers", "Pointer (+0x50, +0x1c) to ASCII track ID",
@"+0x50 | Pointer to Track ID Related Data
  +0x1C | [32 Bytes] ASCII Track ID"));
            memoryValues.Add(new MemoryValue("Tire State Pointer", 0x00575D40, "Int32", "Pointers", "Pointer to tire states (+0x1bfc through +0x1c08)",
@"+0x1BFC = Tire 1 State
+0x1C00 = Tire 2 State
+0x1C04 = Tire 3 State
+0x1C08 = Tire 4 State"));
            memoryValues.Add(new MemoryValue("Race Timer Pointer", 0x00575D44, "Int32", "Pointers", "Pointer to position (+0x30), timer (+0x144), speedtrap (+0x154)",
@"+0x030 | [8-bit] Current Position
+0x144 | [Float] Timer
+0x154 | [Float] Speedtrap Total Speed in MP/H
+0x1C3C | [Float] Total Time
+0x1C28 | [8-bit] Race Flag (0=Initial, 1=In a Race)"));
            memoryValues.Add(new MemoryValue("Performance Upgrade Pointer", 0x00575DFC, "Int32", "Pointers", "Pointer (+0x154, +0x118) to performance upgrade data",
@"+0x154 | Pointer to Performance Upgrade Data
  +0x118 | [32 bytes] Start of Current Car Performance Upgrade Data

Note: Bryan magic pointer chain."));
            memoryValues.Add(new MemoryValue("Heat Level Pointer", 0x005771FC, "Int32", "Pointers", "Pointer (+0x30) to current heat level"));
            memoryValues.Add(new MemoryValue("Current Car Pointer", 0x005A0488, "Int32", "Pointers", "Pointer (+0x40, +0x00) to current car ID",
@"+0x40 | Pointer Chain to Current Car
  +0x00 | [8-bit] Current Car
    0x00 = Porsche 911 Turbo S
    0x01 = Porsche Carrera GT
    0x02 = Dodge Viper SRT10
    0x03 = Police Civic Cruiser
    0x05 = Mazda RX-8
    0x06 = Subaru Impreza WRX STi
    0x07 = Mitsubishi Lancer Evolution VIII
    0x08 = Mustang GT
    0x09 = Chevrolet Camaro SS
    0x0B = Pontiac GTO
    0x0C = Mercedes-Benz SLR McLaren
    0x0F = Chevrolet Corvette C6
    0x14 = Audi TT 3.2 quattro
    0x15 = Audi A3 3.2 quattro
    0x16 = BMW M3 GTR
    0x17 = Mercedes-Benz SL 500
    0x18 = Porsche 911 Carrera S
    0x28 = Porsche 911 GT2
    0x29 = BMW M3 GTR GT
    0x2F = Lexus IS 300
    0x30 = Vauxhall Monaro VXR
    0x31 = Mercedes-Benz SL 65 AMG
    0x32 = Lotus Elise
    0x34 = Ford GT
    0x35 = Mitsubishi Eclipse
    0x36 = Toyota Supra
    0x37 = Chevrolet Corvette C6.R
    0x38 = Mazda RX-7
    0x3B = Lamborghini Murcielago
    0x3C = Audi A4 3.2 FSI quattro
    0x3E = Volkswagen Golf GTI
    0x3F = Porsche Cayman S
    0x40 = Mercedes-Benz SL 500
    0x41 = Cadillac CTS
    0x42 = Aston Martin DB9
    0x43 = Lamborghini Gallardo
    0x44 = Chevrolet Cobalt SS
    0x46 = Renault Clio V6
    0x4A = Fiat Punto"));

            return memoryValues;
        }
    }
}
