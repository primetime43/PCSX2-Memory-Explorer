using Common;
using System.Collections.Generic;

namespace Games.RatchetClank
{
    public class RatchetClank3Config : IGameMemoryConfig
    {
        public string GameName => "Ratchet & Clank 3: Up Your Arsenal (NTSC)";

        public List<MemoryValue> GetMemoryValues()
        {
            var memoryValues = new List<MemoryValue>();

            // ==================== PLAYER STATS ====================
            memoryValues.Add(new MemoryValue("Bolts", 0x00142660, "Int32", "Player Stats", "Total bolts (currency)"));
            memoryValues.Add(new MemoryValue("Ratchet Experience", 0x00142694, "Int32", "Player Stats", "Ratchet's total experience points"));
            memoryValues.Add(new MemoryValue("Armor", 0x001426A0, "Int32", "Player Stats", "Currently equipped armor"));
            memoryValues.Add(new MemoryValue("Sewer Crystals", 0x001426A2, "Int16", "Player Stats", "Number of sewer crystals in possession"));
            memoryValues.Add(new MemoryValue("Bolt Multiplier", 0x001426BA, "Int8", "Player Stats", "Current bolt multiplier"));
            memoryValues.Add(new MemoryValue("Ratchet HP", 0x001A7430, "Int32", "Player Stats", "Current health (also vid comic/Clank health)"));
            memoryValues.Add(new MemoryValue("Death Count", 0x001D4CA0, "Int32", "Player Stats", "Total death count"));

            // ==================== CHALLENGE MODE ====================
            memoryValues.Add(new MemoryValue("Challenge Mode Save Flag", 0x001424A0, "Int8", "Challenge Mode", "Has entered challenge mode save"));
            memoryValues.Add(new MemoryValue("Challenge Mode Count", 0x00142692, "Int8", "Challenge Mode", "Number of challenge mode completions in game"));

            // ==================== WEAPON LEVELS ====================
            memoryValues.Add(new MemoryValue("Plasma Coil Level", 0x001425D0, "Int8", "Weapon Levels", "Plasma Coil upgrade level"));
            memoryValues.Add(new MemoryValue("Lava Gun Level", 0x001425D1, "Int8", "Weapon Levels", "Lava Gun upgrade level"));
            memoryValues.Add(new MemoryValue("Bouncer Level", 0x001425D3, "Int8", "Weapon Levels", "Bouncer upgrade level"));
            memoryValues.Add(new MemoryValue("Miniturret Level", 0x001425D5, "Int8", "Weapon Levels", "Miniturret Glove upgrade level"));
            memoryValues.Add(new MemoryValue("Shield Charger Level", 0x001425D6, "Int8", "Weapon Levels", "Shield Charger upgrade level"));
            memoryValues.Add(new MemoryValue("Shock Cannon Level", 0x001425E7, "Int8", "Weapon Levels", "Shock Cannon upgrade level"));
            memoryValues.Add(new MemoryValue("N60 Storm Level", 0x001425EF, "Int8", "Weapon Levels", "N60 Storm upgrade level (8 = 0x36)"));
            memoryValues.Add(new MemoryValue("Infector Level", 0x001425F7, "Int8", "Weapon Levels", "Infector upgrade level"));
            memoryValues.Add(new MemoryValue("Decimator Level", 0x001425FF, "Int8", "Weapon Levels", "Decimator upgrade level"));
            memoryValues.Add(new MemoryValue("Spitting Hydra Level", 0x00142607, "Int8", "Weapon Levels", "Spitting Hydra/Tempest upgrade level"));
            memoryValues.Add(new MemoryValue("Disc Blade Level", 0x0014260F, "Int8", "Weapon Levels", "Disc Blade Gun upgrade level"));
            memoryValues.Add(new MemoryValue("Agents of Doom Level", 0x00142617, "Int8", "Weapon Levels", "Agents of Doom upgrade level"));
            memoryValues.Add(new MemoryValue("Rift Inducer Level", 0x0014261F, "Int8", "Weapon Levels", "Rift Inducer/Rift Ripper upgrade level"));
            memoryValues.Add(new MemoryValue("Holoshield Level", 0x00142627, "Int8", "Weapon Levels", "Holoshield Launcher upgrade level"));
            memoryValues.Add(new MemoryValue("Flux Rifle Level", 0x0014262F, "Int8", "Weapon Levels", "Flux Rifle/Splitter Rifle upgrade level"));
            memoryValues.Add(new MemoryValue("Nitro Launcher Level", 0x00142637, "Int8", "Weapon Levels", "Nitro Launcher upgrade level"));
            memoryValues.Add(new MemoryValue("Plasma Whip Level", 0x0014263F, "Int8", "Weapon Levels", "Plasma Whip upgrade level"));
            memoryValues.Add(new MemoryValue("Suck Cannon Level", 0x00142647, "Int8", "Weapon Levels", "Suck Cannon upgrade level"));
            memoryValues.Add(new MemoryValue("Qwack-O-Ray Level", 0x0014264F, "Int8", "Weapon Levels", "Qwack-O-Ray upgrade level"));
            memoryValues.Add(new MemoryValue("RYNO Level", 0x00142657, "Int8", "Weapon Levels", "RYNO upgrade level"));

            // ==================== WEAPON AMMO ====================
            memoryValues.Add(new MemoryValue("Plasma Coil Ammo", 0x00142830, "Int32", "Weapon Ammo", "Plasma Coil current ammo"));
            memoryValues.Add(new MemoryValue("Lava Gun Ammo", 0x00142834, "Int32", "Weapon Ammo", "Lava Gun current ammo"));
            memoryValues.Add(new MemoryValue("Bouncer Ammo", 0x0014283C, "Int32", "Weapon Ammo", "Bouncer current ammo"));
            memoryValues.Add(new MemoryValue("Miniturret Ammo", 0x00142844, "Int32", "Weapon Ammo", "Miniturret Glove current ammo"));
            memoryValues.Add(new MemoryValue("Shield Charger Ammo", 0x00142848, "Int32", "Weapon Ammo", "Shield Charger current ammo"));
            memoryValues.Add(new MemoryValue("Shock Blaster Ammo", 0x0014288C, "Int32", "Weapon Ammo", "Shock Blaster/Shock Cannon current ammo"));
            memoryValues.Add(new MemoryValue("N60 Storm Ammo", 0x001428AC, "Int32", "Weapon Ammo", "N60 Storm/N90 Hurricane current ammo"));
            memoryValues.Add(new MemoryValue("Infector Ammo", 0x001428CC, "Int32", "Weapon Ammo", "Infector current ammo"));
            memoryValues.Add(new MemoryValue("Annihilator Ammo", 0x001428EC, "Int32", "Weapon Ammo", "Annihilator/Decimator current ammo"));
            memoryValues.Add(new MemoryValue("Spitting Hydra Ammo", 0x0014290C, "Int32", "Weapon Ammo", "Spitting Hydra/Tempest current ammo"));
            memoryValues.Add(new MemoryValue("Agents of Doom Ammo", 0x0014294C, "Int32", "Weapon Ammo", "Agents of Doom current ammo"));
            memoryValues.Add(new MemoryValue("Rift Inducer Ammo", 0x0014296C, "Int32", "Weapon Ammo", "Omega Rift Ripper current ammo"));
            memoryValues.Add(new MemoryValue("Holoshield Ammo", 0x0014298C, "Int32", "Weapon Ammo", "Holoshield current ammo"));
            memoryValues.Add(new MemoryValue("Flux Rifle Ammo", 0x001429AC, "Int32", "Weapon Ammo", "Flux Rifle/Pulse Rifle current ammo"));
            memoryValues.Add(new MemoryValue("Nitro Launcher Ammo", 0x001429CC, "Int32", "Weapon Ammo", "Nitro Launcher current ammo"));
            memoryValues.Add(new MemoryValue("Plasma Whip Ammo", 0x001429EC, "Int32", "Weapon Ammo", "Plasma Whip/Quantum Whip current ammo"));
            memoryValues.Add(new MemoryValue("RYNO Ammo", 0x00142A4C, "Int32", "Weapon Ammo", "RYNO current ammo"));
            memoryValues.Add(new MemoryValue("Suck Cannon Ammo", 0x001D6A10, "Int32", "Weapon Ammo", "Suck Cannon current ammo"));

            // ==================== WEAPON EXPERIENCE ====================
            memoryValues.Add(new MemoryValue("Plasma Coil XP", 0x00142E20, "Int32", "Weapon XP", "Plasma Coil/Plasma Storm experience"));
            memoryValues.Add(new MemoryValue("Lava Gun XP", 0x00142E24, "Int32", "Weapon XP", "Lava Gun/Liquid Nitrogen Gun experience"));
            memoryValues.Add(new MemoryValue("Bouncer XP", 0x00142E2C, "Int32", "Weapon XP", "Bouncer/Heavy Bouncer experience"));
            memoryValues.Add(new MemoryValue("Miniturret XP", 0x00142E34, "Int32", "Weapon XP", "Miniturret Glove/Megaturret Glove experience"));
            memoryValues.Add(new MemoryValue("Shield Charger XP", 0x00142E38, "Int32", "Weapon XP", "Shield Charger/Tesla Barrier experience"));
            memoryValues.Add(new MemoryValue("Shock Blaster XP", 0x00142E7C, "Int32", "Weapon XP", "Shock Blaster/Shock Cannon experience"));
            memoryValues.Add(new MemoryValue("N60 Storm XP", 0x00142E9C, "Int32", "Weapon XP", "N60 Storm/N90 Hurricane experience"));
            memoryValues.Add(new MemoryValue("Infector XP", 0x00142EBC, "Int32", "Weapon XP", "Infector experience"));
            memoryValues.Add(new MemoryValue("Annihilator XP", 0x00142EDC, "Int32", "Weapon XP", "Annihilator/Decimator experience"));
            memoryValues.Add(new MemoryValue("Spitting Hydra XP", 0x00142EFC, "Int32", "Weapon XP", "Spitting Hydra experience"));
            memoryValues.Add(new MemoryValue("Disc Blade XP", 0x00142F1C, "Int32", "Weapon XP", "Disc Blade Gun/Multi-Disc Gun experience"));
            memoryValues.Add(new MemoryValue("Agents of Doom XP", 0x00142F3C, "Int32", "Weapon XP", "Agents of Doom experience"));
            memoryValues.Add(new MemoryValue("Rift Inducer XP", 0x00142F5C, "Int32", "Weapon XP", "Rift Inducer/Rift Ripper experience"));
            memoryValues.Add(new MemoryValue("Holoshield XP", 0x00142F7C, "Int32", "Weapon XP", "Holoshield Launcher/Ultrashield Launcher experience"));
            memoryValues.Add(new MemoryValue("Flux Rifle XP", 0x00142F9C, "Int32", "Weapon XP", "Flux Rifle experience"));
            memoryValues.Add(new MemoryValue("Nitro Launcher XP", 0x00142FBC, "Int32", "Weapon XP", "Nitro Launcher/Nitro Eruptor experience"));
            memoryValues.Add(new MemoryValue("Plasma Whip XP", 0x00142FDC, "Int32", "Weapon XP", "Plasma Whip/Quantum Whip experience"));
            memoryValues.Add(new MemoryValue("Suck Cannon XP", 0x00142FFC, "Int32", "Weapon XP", "Suck Cannon/Vortex Cannon experience"));
            memoryValues.Add(new MemoryValue("Qwack-O-Ray XP", 0x0014301C, "Int32", "Weapon XP", "Qwack-O-Ray/Qwack-O-Blitzer experience"));
            memoryValues.Add(new MemoryValue("RYNO XP", 0x0014303C, "Int32", "Weapon XP", "RYNO experience"));

            // ==================== WEAPON UNLOCKS ====================
            memoryValues.Add(new MemoryValue("Map-O-Matic Unlock", 0x00142CA5, "Int8", "Weapon Unlocks", "Map-O-Matic obtained"));
            memoryValues.Add(new MemoryValue("Bolt Grabber V2 Unlock", 0x00142CA7, "Int8", "Weapon Unlocks", "Bolt Grabber V2 obtained"));
            memoryValues.Add(new MemoryValue("Hypershot Unlock", 0x00142CAB, "Int8", "Weapon Unlocks", "Hypershot obtained"));
            memoryValues.Add(new MemoryValue("Magnet Boots Unlock", 0x00142CAD, "Int8", "Weapon Unlocks", "Magnet Boots obtained"));
            memoryValues.Add(new MemoryValue("Plasma Coil Unlock", 0x00142CB0, "Int8", "Weapon Unlocks", "Plasma Coil unlocked"));
            memoryValues.Add(new MemoryValue("Lava Gun Unlock", 0x00142CB1, "Int8", "Weapon Unlocks", "Lava Gun unlocked"));
            memoryValues.Add(new MemoryValue("Refractor Unlock", 0x00142CB2, "Int8", "Weapon Unlocks", "Refractor unlocked"));
            memoryValues.Add(new MemoryValue("Bouncer Unlock", 0x00142CB3, "Int8", "Weapon Unlocks", "Bouncer unlocked"));
            memoryValues.Add(new MemoryValue("Miniturret Glove Unlock", 0x00142CB5, "Int8", "Weapon Unlocks", "Miniturret Glove unlocked"));
            memoryValues.Add(new MemoryValue("Shield Charger Unlock", 0x00142CB6, "Int8", "Weapon Unlocks", "Shield Charger unlocked"));
            memoryValues.Add(new MemoryValue("Charge Boots Unlock", 0x00142CBD, "Int8", "Weapon Unlocks", "Charge Boots obtained"));
            memoryValues.Add(new MemoryValue("Warp Pad Unlock", 0x00142CBF, "Int8", "Weapon Unlocks", "Warp Pad unlocked"));
            memoryValues.Add(new MemoryValue("Nano Pack Unlock", 0x00142CC0, "Int8", "Weapon Unlocks", "Nano Pack obtained"));
            memoryValues.Add(new MemoryValue("Master Plan Unlock", 0x00142CC2, "Int8", "Weapon Unlocks", "Master Plan obtained"));
            memoryValues.Add(new MemoryValue("PDA Unlock", 0x00142CC3, "Int8", "Weapon Unlocks", "PDA obtained"));
            memoryValues.Add(new MemoryValue("Shock Blaster Unlock", 0x00142CC7, "Int8", "Weapon Unlocks", "Shock Blaster unlocked"));
            memoryValues.Add(new MemoryValue("N60 Storm Unlock", 0x00142CCF, "Int8", "Weapon Unlocks", "N60 Storm unlocked"));
            memoryValues.Add(new MemoryValue("Infector Unlock", 0x00142CD7, "Int8", "Weapon Unlocks", "Infector unlocked"));
            memoryValues.Add(new MemoryValue("Annihilator Unlock", 0x00142CDF, "Int8", "Weapon Unlocks", "Annihilator unlocked"));
            memoryValues.Add(new MemoryValue("Spitting Hydra Unlock", 0x00142CE7, "Int8", "Weapon Unlocks", "Spitting Hydra unlocked"));
            memoryValues.Add(new MemoryValue("Disc Blade Gun Unlock", 0x00142CEF, "Int8", "Weapon Unlocks", "Disc Blade Gun unlocked"));
            memoryValues.Add(new MemoryValue("Agents of Doom Unlock", 0x00142CF7, "Int8", "Weapon Unlocks", "Agents of Doom unlocked"));
            memoryValues.Add(new MemoryValue("Rift Inducer Unlock", 0x00142CFF, "Int8", "Weapon Unlocks", "Rift Inducer unlocked"));
            memoryValues.Add(new MemoryValue("Holoshield Unlock", 0x00142D07, "Int8", "Weapon Unlocks", "Holoshield Launcher unlocked"));
            memoryValues.Add(new MemoryValue("Flux Rifle Unlock", 0x00142D0F, "Int8", "Weapon Unlocks", "Flux Rifle unlocked"));
            memoryValues.Add(new MemoryValue("Nitro Launcher Unlock", 0x00142D17, "Int8", "Weapon Unlocks", "Nitro Launcher unlocked"));
            memoryValues.Add(new MemoryValue("Plasma Whip Unlock", 0x00142D1F, "Int8", "Weapon Unlocks", "Plasma Whip unlocked"));
            memoryValues.Add(new MemoryValue("Suck Cannon Unlock", 0x00142D27, "Int8", "Weapon Unlocks", "Suck Cannon unlocked"));
            memoryValues.Add(new MemoryValue("Qwack-O-Ray Unlock", 0x00142D2F, "Int8", "Weapon Unlocks", "Qwack-O-Ray unlocked"));
            memoryValues.Add(new MemoryValue("RYNO Unlock", 0x00142D37, "Int8", "Weapon Unlocks", "RYNO unlocked"));

            // ==================== QWARK ====================
            memoryValues.Add(new MemoryValue("Qwark Timer", 0x001426D0, "Int16", "Qwark", "Qwark gameplay timer"));
            memoryValues.Add(new MemoryValue("Qwark Tutu", 0x001426D7, "Int8", "Qwark", "Qwark Tutu flag (Bit7)"));
            memoryValues.Add(new MemoryValue("Qwark Health", 0x001D8068, "Int32", "Qwark", "Qwark boss health"));

            // ==================== MISSION COMPLETION ====================
            memoryValues.Add(new MemoryValue("Zeldrin - Find Nefarious", 0x001426E2, "Int8", "Missions", "Zeldrin Starport - Find Nefarious completed"));
            memoryValues.Add(new MemoryValue("Save Veldin", 0x001426E3, "Int8", "Missions", "Save Veldin mission completed"));
            memoryValues.Add(new MemoryValue("Veldin - Eliminate Enemies", 0x001426E4, "Int8", "Missions", "Veldin - Eliminate the Enemy Forces completed"));
            memoryValues.Add(new MemoryValue("Florana - Find Man", 0x001426E5, "Int8", "Missions", "Florana - Find the mysterious man completed"));
            memoryValues.Add(new MemoryValue("Florana - Path of Death", 0x001426E6, "Int8", "Missions", "Florana - Walk the path of death! completed"));
            memoryValues.Add(new MemoryValue("Beat Qwark on Florana", 0x001426E7, "Int8", "Missions", "Beat Qwark on Florana completed"));
            memoryValues.Add(new MemoryValue("Phoenix - Qwark to Cage", 0x001426E8, "Int8", "Missions", "Starship Phoenix - Take Qwark to his cage completed"));
            memoryValues.Add(new MemoryValue("Phoenix - Meet Sasha", 0x001426E9, "Int8", "Missions", "Starship Phoenix - Meet Sasha on the bridge completed"));
            memoryValues.Add(new MemoryValue("Meet Al at Marcadia", 0x001426EA, "Int8", "Missions", "Meet Al at Marcadia completed"));
            memoryValues.Add(new MemoryValue("Phoenix - Qwark Vid-comic", 0x001426EB, "Int8", "Missions", "Starship Phoenix - Play the Qwark vid-comic completed"));
            memoryValues.Add(new MemoryValue("Phoenix - Get to Palace", 0x001426EF, "Int8", "Missions", "Starship Phoenix - Get to the Palace completed"));
            memoryValues.Add(new MemoryValue("Marcadia - Repair Shield", 0x001426F1, "Int8", "Missions", "Marcadia - Repair the Laser Defense Shield completed"));
            memoryValues.Add(new MemoryValue("Marcadia - Secure Area", 0x001426F2, "Int8", "Missions", "Marcadia - Secure the Area completed"));
            memoryValues.Add(new MemoryValue("AN - Return", 0x001426F3, "Int8", "Missions", "Annihilation Nation - Return to Annihilation Nation completed"));
            memoryValues.Add(new MemoryValue("Phoenix - Bridge Unrest", 0x001426F4, "Int8", "Missions", "Get to the bridge during the unrest at the Phoenix completed"));
            memoryValues.Add(new MemoryValue("AN - Win Tyhrra-guise", 0x001426F5, "Int8", "Missions", "Annihilation Nation - Win the Tyhrra-guise completed"));
            memoryValues.Add(new MemoryValue("AN - Return and Phoenix", 0x001426F6, "Int8", "Missions", "Annihilation Nation - Return to Annihilation nation and Return to the Phoenix completed"));
            memoryValues.Add(new MemoryValue("Aquatos - Infiltrate", 0x001426F7, "Int8", "Missions", "Aquatos - Infiltrate the underwater hideout completed"));
            memoryValues.Add(new MemoryValue("Tyhrranosis - Destroy Turrets", 0x001426F9, "Int8", "Missions", "Tyhrranosis - Destroy the plasma cannon turrets completed"));
            memoryValues.Add(new MemoryValue("Obani - Destroy Turrets", 0x00142701, "Int8", "Missions", "Obani - Destroy the plasma cannon turrets completed"));
            memoryValues.Add(new MemoryValue("Rilgar - Save City", 0x00142704, "Int8", "Missions", "Rilgar - Save Blackwater City completed"));
            memoryValues.Add(new MemoryValue("Rilgar - Destroy Base", 0x00142705, "Int8", "Missions", "Rilgar - Destroy the Tyhrranoid Base completed"));
            memoryValues.Add(new MemoryValue("Metropolis - Defeat Klunk", 0x00142708, "Int8", "Missions", "Metropolis Kerwan - Defeat Giant Klunk completed"));
            memoryValues.Add(new MemoryValue("Beaten Courtney Gears", 0x0014270D, "Int8", "Missions", "Beaten Courtney Gears completed"));
            memoryValues.Add(new MemoryValue("Defeat Dr Nefarious", 0x0014270F, "Int8", "Missions", "Defeat Dr Nefarious completed"));
            memoryValues.Add(new MemoryValue("Defeated Biobliterator", 0x00142710, "Int8", "Missions", "Defeated Biobliterator (never turns on)"));
            memoryValues.Add(new MemoryValue("Holostar - Film Episode", 0x00142712, "Int8", "Missions", "Holostar - Film a Secret Agent Clank Episode completed"));
            memoryValues.Add(new MemoryValue("Holostar - Escape Ambush", 0x00142713, "Int8", "Missions", "Holostar - Escape the Tyhrranoid Ambush completed"));
            memoryValues.Add(new MemoryValue("Metropolis - Assist Rangers", 0x00142714, "Int8", "Missions", "Metropolis Assist Rangers (Optional) completed"));
            memoryValues.Add(new MemoryValue("Aquatos - Gather Crystals", 0x00142715, "Int8", "Missions", "Aquatos - Gather sewer Crystals completed"));
            memoryValues.Add(new MemoryValue("Destroy Encampment", 0x00142717, "Int8", "Missions", "Destroy the Encampment completed"));
            memoryValues.Add(new MemoryValue("Tyhrranosis - Defeat Momma", 0x0014271D, "Int8", "Missions", "Tyhrranosis - Destroy the Momma Tyhrranoid completed"));
            memoryValues.Add(new MemoryValue("Beat Mothership", 0x0014275B, "Int8", "Missions", "Beat the Mothership completed"));

            // ==================== SKINS ====================
            memoryValues.Add(new MemoryValue("Skins Unlocked", 0x0014271E, "Int8", "Skins", "Skins unlocked bitflags",
@"Bit 7 = Tuxedo
Bit 6 = Snowman
Bit 5 = Old school Ratchet"));
            memoryValues.Add(new MemoryValue("Skins Purchased", 0x001427A8, "Int8", "Skins", "Skins purchased bitflags",
@"Bit 5 = Robo
Bit 4 = Trooper
Bit 3 = Robo Rooster
Bit 2 = ConstructoBot
Bit 1 = Brainius
Bit 0 = Buginoid"));

            // ==================== VID COMICS ====================
            memoryValues.Add(new MemoryValue("Unused Vid Comic Score", 0x0014272A, "Int8", "Vid Comics", "Score for the unused Qwark vid comic"));
            memoryValues.Add(new MemoryValue("Unused Comic Completed Trigger", 0x00142732, "Int8", "Vid Comics", "Triggers instant mission - unused comic completed"));
            memoryValues.Add(new MemoryValue("Vid Comic Completed Flags", 0x00142734, "Int8", "Vid Comics", "Vid comic completion bitflags",
@"Bit 0 = Unused comic
Bit 1 = Pirate Booty!
Bit 2 = Metropolis
Bit 3 = Arriba Amoeba
Bit 4 = Shadow of the Robot
Bit 5 = The Shaming of the Q
Bit 6 = Special vid comic"));
            memoryValues.Add(new MemoryValue("Vid Comic Tokens (Unused)", 0x01727534, "Int32", "Vid Comics", "Tokens for unused vid comic"));
            memoryValues.Add(new MemoryValue("Vid Comic Tokens (Spanish)", 0x0172B7B4, "Int32", "Vid Comics", "Spanish vid comic tokens"));
            memoryValues.Add(new MemoryValue("Vid Comic Tokens (Unused 2)", 0x0172C9F4, "Int32", "Vid Comics", "Tokens unused"));
            memoryValues.Add(new MemoryValue("Vid Comic Special 1 Collected", 0x01762204, "Int32", "Vid Comics", "Vid comic Special 1 tokens collected"));
            memoryValues.Add(new MemoryValue("Vid Comic Special 1 Overall", 0x01762208, "Int32", "Vid Comics", "Vid comic Special 1 tokens overall"));
            memoryValues.Add(new MemoryValue("Vid Comic Spanish Special", 0x01766344, "Int32", "Vid Comics", "Spanish vid special comic 1"));
            memoryValues.Add(new MemoryValue("Quest for Booty Tokens French", 0x01767444, "Int32", "Vid Comics", "Quest for booty tokens (French)"));
            memoryValues.Add(new MemoryValue("Tokens Metropolis", 0x017C4544, "Int32", "Vid Comics", "Tokens vid comics - Metropolis"));
            memoryValues.Add(new MemoryValue("Qwark Special Vid Comic", 0x001DCA40, "Int32", "Vid Comics", "Qwark special vid comic? 23"));

            // ==================== OPERATION IRON SHIELD ====================
            memoryValues.Add(new MemoryValue("Iron Shield Part 1", 0x00142738, "Int8", "Operation Iron Shield", "Marcadia - Operation: IRON SHIELD, Part 1 - Secure the Area completed"));
            memoryValues.Add(new MemoryValue("Iron Shield Part 2", 0x00142739, "Int8", "Operation Iron Shield", "Marcadia - Operation: IRON SHIELD, Part 2 - Air Assault completed"));
            memoryValues.Add(new MemoryValue("Iron Shield Part 3", 0x0014273A, "Int8", "Operation Iron Shield", "Marcadia - Operation: IRON SHIELD, Part 3 - Turret Command completed"));
            memoryValues.Add(new MemoryValue("Iron Shield Part 4", 0x0014273B, "Int8", "Operation Iron Shield", "Marcadia - Operation: IRON SHIELD, Part 4 - Under the Gun completed"));
            memoryValues.Add(new MemoryValue("Iron Shield Part 5", 0x0014273C, "Int8", "Operation Iron Shield", "Marcadia - Operation: IRON SHIELD, Part 5 - Hit n' Run completed"));
            memoryValues.Add(new MemoryValue("Iron Shield Hit and Run", 0x001427C4, "Int32", "Operation Iron Shield", "Iron Shield Hit and Run value (0xf42)"));

            // ==================== VR CHALLENGES ====================
            memoryValues.Add(new MemoryValue("VR - Gadget Training", 0x00142765, "Int8", "VR Challenges", "Starship Phoenix - VR Gadget Training completion count"));
            memoryValues.Add(new MemoryValue("VR - Warm Up", 0x00142766, "Int8", "VR Challenges", "Starship Phoenix - Warm Up completion count"));
            memoryValues.Add(new MemoryValue("VR - Don't Look Down", 0x00142767, "Int8", "VR Challenges", "Starship Phoenix - Don't Look Down completion count"));
            memoryValues.Add(new MemoryValue("VR - Speed Round", 0x00142768, "Int8", "VR Challenges", "Starship Phoenix - Speed Round completion count"));
            memoryValues.Add(new MemoryValue("VR - Hot Stepper", 0x00142769, "Int8", "VR Challenges", "Starship Phoenix - Hot Stepper completion count"));
            memoryValues.Add(new MemoryValue("VR - 90 Second Slayer", 0x0014276A, "Int8", "VR Challenges", "Starship Phoenix - 90 Second Slayer completion count"));
            memoryValues.Add(new MemoryValue("VR - The Shocker", 0x0014276B, "Int8", "VR Challenges", "Starship Phoenix - The Shocker completion count"));
            memoryValues.Add(new MemoryValue("VR - Wrench Beatdown", 0x0014276C, "Int8", "VR Challenges", "Starship Phoenix - Wrench Beatdown completion count"));
            memoryValues.Add(new MemoryValue("VR - Nerves of Titanium", 0x0014276D, "Int8", "VR Challenges", "Starship Phoenix - Nerves of Titanium completion count"));

            // ==================== ANNIHILATION NATION ====================
            memoryValues.Add(new MemoryValue("AN - Heat Street", 0x0014276E, "Int8", "Annihilation Nation", "Heat Street completion count"));
            memoryValues.Add(new MemoryValue("AN - Practice Challenge", 0x0014276F, "Int8", "Annihilation Nation", "Practice Challenge completion count"));
            memoryValues.Add(new MemoryValue("AN - The Terrible Two", 0x00142772, "Int8", "Annihilation Nation", "The Terrible Two completion count"));
            memoryValues.Add(new MemoryValue("AN - Robot Rampage", 0x00142773, "Int8", "Annihilation Nation", "Robot Rampage completion count"));
            memoryValues.Add(new MemoryValue("AN - Two Minute Warning", 0x00142774, "Int8", "Annihilation Nation", "Two Minute Warning completion count"));
            memoryValues.Add(new MemoryValue("AN - 90 Seconds of Carnage", 0x00142775, "Int8", "Annihilation Nation", "90 Seconds of Carnage completion count"));
            memoryValues.Add(new MemoryValue("AN - Onslaught", 0x00142776, "Int8", "Annihilation Nation", "Onslaught completion count"));
            memoryValues.Add(new MemoryValue("AN - Whip It Good", 0x00142777, "Int8", "Annihilation Nation", "Whip It Good completion count"));
            memoryValues.Add(new MemoryValue("AN - Hydra 'N Seek", 0x00142778, "Int8", "Annihilation Nation", "Hydra 'N Seek completion count"));
            memoryValues.Add(new MemoryValue("AN - Championship Bout", 0x00142779, "Int8", "Annihilation Nation", "Championship Bout completion count"));
            memoryValues.Add(new MemoryValue("AN - Crispy Critter", 0x0014277A, "Int8", "Annihilation Nation", "Crispy Critter completion count"));
            memoryValues.Add(new MemoryValue("AN - Pyro Playground", 0x0014277B, "Int8", "Annihilation Nation", "Pyro Playground completion count"));
            memoryValues.Add(new MemoryValue("AN - Suicide Run", 0x0014277C, "Int8", "Annihilation Nation", "Suicide Run completion count"));
            memoryValues.Add(new MemoryValue("AN Challenge Indicator", 0x001CCFD8, "Int8", "Annihilation Nation", "Challenge indicator (0x61 = Fight with the Terrible Two)"));
            memoryValues.Add(new MemoryValue("AN You Win", 0x001DEDB8, "Int32", "Annihilation Nation", "You win Annihilation Nation flag"));

            // ==================== TROPHIES ====================
            memoryValues.Add(new MemoryValue("Trophy - Ratchet", 0x00142790, "Int8", "Trophies", "Collected Ratchet trophy"));
            memoryValues.Add(new MemoryValue("Trophy - Clank", 0x00142791, "Int8", "Trophies", "Collected Clank trophy"));
            memoryValues.Add(new MemoryValue("Trophy - Qwark", 0x00142792, "Int8", "Trophies", "Collected Qwark trophy"));
            memoryValues.Add(new MemoryValue("Trophy - Dr. Nefarious", 0x00142793, "Int8", "Trophies", "Collected Dr. Nefarious trophy"));
            memoryValues.Add(new MemoryValue("Trophy - Skrunch", 0x00142794, "Int8", "Trophies", "Collected Qwark Skrunch trophy"));
            memoryValues.Add(new MemoryValue("Trophy - Lawrence", 0x00142795, "Int8", "Trophies", "Collected Lawrence trophy"));
            memoryValues.Add(new MemoryValue("Trophy - The Plumber", 0x00142796, "Int8", "Trophies", "Collected The Plumber trophy"));
            memoryValues.Add(new MemoryValue("Trophy - Courtney Gears", 0x00142797, "Int8", "Trophies", "Collected Courtney Gears trophy"));
            memoryValues.Add(new MemoryValue("Trophy - AL", 0x00142798, "Int8", "Trophies", "Collected AL trophy"));
            memoryValues.Add(new MemoryValue("Trophy - Titanium Collector", 0x00142799, "Int8", "Trophies", "Collected Titanium Collector trophy"));
            memoryValues.Add(new MemoryValue("Trophy - Skill Master", 0x0014279A, "Int8", "Trophies", "Collected Skill Master trophy"));
            memoryValues.Add(new MemoryValue("Trophy - Nano Finder", 0x0014279B, "Int8", "Trophies", "Collected Nano Finder trophy"));
            memoryValues.Add(new MemoryValue("Trophy - AN Champion", 0x0014279C, "Int8", "Trophies", "Collected Annihilation Nation Champion trophy"));
            memoryValues.Add(new MemoryValue("Trophy - Friend of Rangers", 0x0014279D, "Int8", "Trophies", "Collected Friend of the Rangers trophy"));
            memoryValues.Add(new MemoryValue("Trophy - Omega Arsenal", 0x0014279E, "Int8", "Trophies", "Collected Omega Arsenal trophy"));

            // ==================== SHIP CUSTOMIZATION ====================
            memoryValues.Add(new MemoryValue("Wrench Replacement", 0x001427A1, "Int8", "Ship Parts", "Wrench replacement equipped"));
            memoryValues.Add(new MemoryValue("Ship Parts 1", 0x001427A3, "Int8", "Ship Parts", "Ratchet's ship parts 1",
@"Bit 7 = Amoeboid Green
Bit 5 = Scoop Nose
Bit 4 = Split Nose
Bit 2 = Heavy Ordinance wings
Bit 1 = Hi-Lift Wings"));
            memoryValues.Add(new MemoryValue("Ship Parts 2", 0x001427A4, "Int8", "Ship Parts", "Ratchet's ship parts 2",
@"Bit 7 = Lombax Orange
Bit 6 = Orxon Green
Bit 5 = Bogon Blue
Bit 4 = Sun Storm
Bit 3 = Black Hole
Bit 2 = Low Rider
Bit 1 = Obani Orange
Bit 0 = Pulsing Purple"));
            memoryValues.Add(new MemoryValue("Ship Parts 3", 0x001427A5, "Int8", "Ship Parts", "Ratchet's ship parts 3",
@"Bit 7 = Ghost Pirate Purple
Bit 6 = Zeldren Sunset
Bit 5 = Tyhrranoid Void
Bit 4 = Space Storm
Bit 3 = Helgas Hues
Bit 2 = Agent Orange
Bit 1 = Qwark Green
Bit 0 = Hooked on Onyx"));
            memoryValues.Add(new MemoryValue("Ship Parts 4", 0x001427A6, "Int8", "Ship Parts", "Ratchet's ship parts 4",
@"Bit 7 = Lunar Eclipse
Bit 6 = Neutron Star
Bit 5 = Drek's Black Heart
Bit 4 = Supernova
Bit 3 = Silent Strike
Bit 2 = Ozzy Kamikaze
Bit 1 = Florana Breeze
Bit 0 = Sasha Scarlet"));
            memoryValues.Add(new MemoryValue("Ship Parts 5", 0x001427A7, "Int8", "Ship Parts", "Ratchet's ship parts 5",
@"Bit 5 = Insomniac Special
Bit 4 = Plaidtastic
Bit 3 = Clowner
Bit 2 = Star Traveller
Bit 1 = Dark Nebula
Bit 0 = Solar Wind"));

            // ==================== SKILL POINTS ====================
            memoryValues.Add(new MemoryValue("SP - Go for Hang Time", 0x001D54B0, "Int8", "Skill Points", "Skill Point - Go for hang time"));
            memoryValues.Add(new MemoryValue("SP - Stay Squeaky Clean", 0x001D54B1, "Int8", "Skill Points", "Skill Point - Stay squeaky clean (Florana)"));
            memoryValues.Add(new MemoryValue("SP - Arcade Perfection", 0x001D54B2, "Int8", "Skill Points", "Skill Point - Strive for arcade perfection"));
            memoryValues.Add(new MemoryValue("SP - Beat Helga's Time", 0x001D54B3, "Int8", "Skill Points", "Skill Point - Beat Helga's best time"));
            memoryValues.Add(new MemoryValue("SP - Turn Up the Heat", 0x001D54B4, "Int8", "Skill Points", "Skill Point - Turn up the heat"));
            memoryValues.Add(new MemoryValue("SP - Monkeying Around", 0x001D54B5, "Int8", "Skill Points", "Skill Point - Monkeying around"));
            memoryValues.Add(new MemoryValue("SP - Reflect on Score", 0x001D54B6, "Int8", "Skill Points", "Skill Point - Reflect on how to score"));
            memoryValues.Add(new MemoryValue("SP - Bugs to Birdie", 0x001D54B7, "Int8", "Skill Points", "Skill Point - Bugs to Birdie"));
            memoryValues.Add(new MemoryValue("SP - Bash the Bug", 0x001D54B8, "Int8", "Skill Points", "Skill Point - Bash the bug"));
            memoryValues.Add(new MemoryValue("SP - Eight Time Champ", 0x001D54B9, "Int8", "Skill Points", "Skill Point - Be an eight time champ"));
            memoryValues.Add(new MemoryValue("SP - Flee Flawlessly", 0x001D54BA, "Int8", "Skill Points", "Skill Point - Flee Flawlessly"));
            memoryValues.Add(new MemoryValue("SP - Lights Camera Action", 0x001D54BB, "Int8", "Skill Points", "Skill Point - Lights, camera action!"));
            memoryValues.Add(new MemoryValue("SP - Sunken Treasure", 0x001D54BC, "Int8", "Skill Points", "Skill Point - Search for sunken treasure"));
            memoryValues.Add(new MemoryValue("SP - Be a Sharpshooter", 0x001D54BD, "Int8", "Skill Points", "Skill Point - Be a Sharpshooter"));
            memoryValues.Add(new MemoryValue("SP - Get to the Belt", 0x001D54BE, "Int8", "Skill Points", "Skill Point - Get to the belt"));
            memoryValues.Add(new MemoryValue("SP - Wrench Only 20 Kills", 0x001D54BF, "Int8", "Skill Points", "Skill Point - Kill 20 enemies using only the wrench"));
            memoryValues.Add(new MemoryValue("SP - Feeling Lucky", 0x001D54C0, "Int8", "Skill Points", "Skill Point - Feeling Lucky"));
            memoryValues.Add(new MemoryValue("SP - Break It Win It", 0x001D54C1, "Int8", "Skill Points", "Skill Point - You break it, you win it"));
            memoryValues.Add(new MemoryValue("SP - 2002 Good Year", 0x001D54C2, "Int8", "Skill Points", "Skill Point - 2002 was a good year in the city"));
            memoryValues.Add(new MemoryValue("SP - Suck it Up", 0x001D54C3, "Int8", "Skill Points", "Skill Point - Suck it up!"));
            memoryValues.Add(new MemoryValue("SP - Aim High", 0x001D54C4, "Int8", "Skill Points", "Skill Point - Aim High"));
            memoryValues.Add(new MemoryValue("SP - Zap Back at Ya", 0x001D54C5, "Int8", "Skill Points", "Skill Point - zap back at ya'"));
            memoryValues.Add(new MemoryValue("SP - Break the Dan", 0x001D54C6, "Int8", "Skill Points", "Skill Point - Break the Dan"));
            memoryValues.Add(new MemoryValue("SP - Spread Your Germs", 0x001D54C7, "Int8", "Skill Points", "Skill Point - Spread your germs"));
            memoryValues.Add(new MemoryValue("SP - Hit the Motherload", 0x001D54C8, "Int8", "Skill Points", "Skill Point - Hit the motherload"));
            memoryValues.Add(new MemoryValue("SP - Pirate Booty Record", 0x001D54C9, "Int8", "Skill Points", "Skill Point - Pirate Booty - set a new record for Qwark"));
            memoryValues.Add(new MemoryValue("SP - Deja Q All Over", 0x001D54CA, "Int8", "Skill Points", "Skill Point - Deja Q All over Again - set a new record for Qwark"));
            memoryValues.Add(new MemoryValue("SP - Arriba Amoeba Record", 0x001D54CB, "Int8", "Skill Points", "Skill Point - Arriba Amoeba! - set a new record for Qwark"));
            memoryValues.Add(new MemoryValue("SP - Shadow of Robot", 0x001D54CC, "Int8", "Skill Points", "Skill Point - Shadow of the robot - set a new record for Qwark"));
            memoryValues.Add(new MemoryValue("SP - Shaming of the Q", 0x001D54CD, "Int8", "Skill Points", "Skill Point - The Shaming of the Q - set a new record for Qwark"));

            // ==================== PLATINUM BOLTS ====================
            // Florana
            memoryValues.Add(new MemoryValue("PB - Florana 1", 0x001BBB29, "Int8", "Platinum Bolts", "Florana Platinum Bolt 1"));
            memoryValues.Add(new MemoryValue("PB - Florana 2", 0x001BBB2A, "Int8", "Platinum Bolts", "Florana Platinum Bolt 2"));
            // Starship Phoenix
            memoryValues.Add(new MemoryValue("PB - Phoenix VR Arena", 0x001BBB30, "Int8", "Platinum Bolts", "Starship Phoenix Platinum Bolt 1 - VR arena"));
            memoryValues.Add(new MemoryValue("PB - Phoenix Helga Time", 0x001BBB31, "Int8", "Platinum Bolts", "Starship Phoenix Platinum Bolt 2 - Helga's time challenge"));
            memoryValues.Add(new MemoryValue("PB - Phoenix Vid Comic 1", 0x001BBB32, "Int8", "Platinum Bolts", "Starship Phoenix Platinum Bolt 3 - Vid Comic 1"));
            memoryValues.Add(new MemoryValue("PB - Phoenix Vid Comic 4", 0x001BBB33, "Int8", "Platinum Bolts", "Starship Phoenix Platinum Bolt 4 - Vid Comic 4"));
            memoryValues.Add(new MemoryValue("PB - Phoenix Vid Comic 2", 0x001BBB34, "Int8", "Platinum Bolts", "Starship Phoenix Platinum Bolt 5 - Vid Comic 2"));
            memoryValues.Add(new MemoryValue("PB - Phoenix Vid Comic 3", 0x001BBB35, "Int8", "Platinum Bolts", "Starship Phoenix Platinum Bolt 6 - Vid Comic 3"));
            memoryValues.Add(new MemoryValue("PB - Phoenix Vid Comic 5", 0x001BBB36, "Int8", "Platinum Bolts", "Starship Phoenix Platinum Bolt 7 - Vid Comic 5"));
            memoryValues.Add(new MemoryValue("PB - Phoenix 8", 0x001BBB4B, "Int8", "Platinum Bolts", "Starship Phoenix Platinum Bolt 8"));
            // Marcadia
            memoryValues.Add(new MemoryValue("PB - Marcadia Entrance", 0x001BBB39, "Int8", "Platinum Bolts", "Marcadia Platinum Bolt 1 - At entrance"));
            memoryValues.Add(new MemoryValue("PB - Marcadia Secret Door", 0x001BBB3A, "Int8", "Platinum Bolts", "Marcadia Platinum Bolt 2 - Secret door"));
            memoryValues.Add(new MemoryValue("PB - Marcadia Magnet Boots", 0x001BBB3B, "Int8", "Platinum Bolts", "Marcadia Platinum Bolt 3 - Ending magnet boots"));
            // Daxx
            memoryValues.Add(new MemoryValue("PB - Daxx 1", 0x001BBB40, "Int8", "Platinum Bolts", "Daxx Platinum Bolt 1"));
            memoryValues.Add(new MemoryValue("PB - Daxx 2", 0x001BBB41, "Int8", "Platinum Bolts", "Daxx Platinum Bolt 2"));
            memoryValues.Add(new MemoryValue("PB - Daxx 3", 0x001BBB42, "Int8", "Platinum Bolts", "Daxx Platinum Bolt 3"));
            // Annihilation Nation
            memoryValues.Add(new MemoryValue("PB - AN Cliff", 0x001BBB51, "Int8", "Platinum Bolts", "Annihilation Nation Platinum Bolt 1 - On cliff"));
            memoryValues.Add(new MemoryValue("PB - AN Ledge", 0x001BBB52, "Int8", "Platinum Bolts", "Annihilation Nation Platinum Bolt 2 - On ledge"));
            // Aquatos
            memoryValues.Add(new MemoryValue("PB - Aquatos Secret Room", 0x001BBB59, "Int8", "Platinum Bolts", "Aquatos Platinum Bolt 1 - Secret room trespasser"));
            memoryValues.Add(new MemoryValue("PB - Aquatos 2", 0x001BBB5A, "Int8", "Platinum Bolts", "Aquatos Platinum Bolt 2"));
            memoryValues.Add(new MemoryValue("PB - Aquatos 3", 0x001BBB5B, "Int8", "Platinum Bolts", "Aquatos Platinum Bolt 3"));
            memoryValues.Add(new MemoryValue("PB - Aquatos Swingshots", 0x001BBBF9, "Int8", "Platinum Bolts", "Aquatos Gold Bolt 4 - Swingshots"));
            memoryValues.Add(new MemoryValue("PB - Aquatos Yellow Lights", 0x001BBBFA, "Int8", "Platinum Bolts", "Aquatos Gold Bolt 5 - Yellow lights"));
            // Tyhrranosis
            memoryValues.Add(new MemoryValue("PB - Tyhrranosis Swingshot", 0x001BBB61, "Int8", "Platinum Bolts", "Tyhrranosis Platinum Bolt 1 - Swingshot"));
            memoryValues.Add(new MemoryValue("PB - Tyhrranosis Behind Base", 0x001BBB62, "Int8", "Platinum Bolts", "Tyhrranosis Platinum Bolt 2 - Behind the base"));
            // Zeldrin Starport
            memoryValues.Add(new MemoryValue("PB - Zeldrin Secret Room", 0x001BBB69, "Int8", "Platinum Bolts", "Zeldrin Starport Platinum Bolt 1 - Secret room"));
            memoryValues.Add(new MemoryValue("PB - Zeldrin Wall Shot", 0x001BBB6A, "Int8", "Platinum Bolts", "Zeldrin Starport Platinum Bolt 2 - Behind wall (needs shot)"));
            // Obani Gemini
            memoryValues.Add(new MemoryValue("PB - Obani Launchpad", 0x001BBB71, "Int8", "Platinum Bolts", "Obani Gemini Platinum Bolt 1 - Launchpad"));
            memoryValues.Add(new MemoryValue("PB - Obani Timer Part", 0x001BBB72, "Int8", "Platinum Bolts", "Obani Gemini Platinum Bolt 2 - Timer part"));
            // Holostar Studio
            memoryValues.Add(new MemoryValue("PB - Holostar Magnet 1", 0x001BBB81, "Int8", "Platinum Bolts", "Holostar Studio Platinum Bolt 1 - Magnet boots section"));
            memoryValues.Add(new MemoryValue("PB - Holostar Studio Up", 0x001BBB82, "Int8", "Platinum Bolts", "Holostar Studio Platinum Bolt 2 - Up the studio"));
            memoryValues.Add(new MemoryValue("PB - Holostar Hidden Area", 0x001BBB83, "Int8", "Platinum Bolts", "Holostar Studio Platinum Bolt 3 - Magnet boots hidden area"));
            // Koros
            memoryValues.Add(new MemoryValue("PB - Koros Gate Area", 0x001BBB89, "Int8", "Platinum Bolts", "Koros Platinum Bolt 1 - Gate area"));
            memoryValues.Add(new MemoryValue("PB - Koros Window Area", 0x001BBB8A, "Int8", "Platinum Bolts", "Koros Platinum Bolt 2 - Window area"));
            // Metropolis
            memoryValues.Add(new MemoryValue("PB - Metropolis Window", 0x001BBB99, "Int8", "Platinum Bolts", "Metropolis Platinum Bolt 1 - Entrance window"));
            memoryValues.Add(new MemoryValue("PB - Metropolis MP Map", 0x001BBB9A, "Int8", "Platinum Bolts", "Metropolis Platinum Bolt 2 - Multiplayer map"));
            memoryValues.Add(new MemoryValue("PB - Metropolis MP Map 2", 0x001BBBE9, "Int8", "Platinum Bolts", "Metropolis Platinum Bolt 3 - Multiplayer map"));
            // Crash Site
            memoryValues.Add(new MemoryValue("PB - Crash Site Beginning", 0x001BBBA1, "Int8", "Platinum Bolts", "Crash Site Platinum Bolt 1 - Beginning"));
            // Aridia
            memoryValues.Add(new MemoryValue("PB - Aridia Behind Base 1", 0x001BBBA9, "Int8", "Platinum Bolts", "Aridia Platinum Bolt 1 - Behind enemies base"));
            memoryValues.Add(new MemoryValue("PB - Aridia Behind Base 2", 0x001BBBAA, "Int8", "Platinum Bolts", "Aridia Platinum Bolt 2 - Behind enemies base"));
            // Qwark's Hideout
            memoryValues.Add(new MemoryValue("PB - Qwark Hideout Beginning", 0x001BBBB1, "Int8", "Platinum Bolts", "Qwark's Hideout Platinum Bolt 1 - Beginning"));
            // Command Center
            memoryValues.Add(new MemoryValue("PB - Command Center Holograph", 0x001BBBC9, "Int8", "Platinum Bolts", "Command Center Platinum Bolt 1 - Behind holograph"));

            // ==================== LEVEL ID ====================
            memoryValues.Add(new MemoryValue("Level ID", 0x001D545C, "Int32", "Game State", "Current level ID",
@"0x00 = Main menu
0x01 = Veldin
0x02 = Florana
0x03 = Starship Phoenix
0x04 = Marcadia
0x05 = Daxx
0x06 = Starship Code red
0x07 = Annihilation Nation
0x08 = Aquatos
0x09 = Tyhrranosis
0x0A = Zeldrin
0x0B = Obani Gemini
0x0C = Blackwater City
0x0D = Studio Ratchet
0x0E = Koros
0x0F = Level15_cityname
0x10 = Metropolis
0x11 = Crash site
0x12 = Aridia
0x13 = Qwark's Hideout
0x14 = Fight with Nefarious
0x15 = Obani Draco
0x16 = Command Centre
0x17 = Studio Clank
0x18 = Insomniac Museum
0x1A = Metropolis arena
0x1B = Tyhrranoid disguise/Getting to the lair
0x1C = Sewer Crystal segment
0x1D = Tyhrranosis, Korgon Base
0x1E = Unnamed Vid comic
0x1F = Vid comic 1
0x20 = Vid Comic 4
0x21 = Vid Comic 2
0x22 = Vid comic 3
0x23 = Vid Comic 5
0x24 = Vid comic 1 special"));
            memoryValues.Add(new MemoryValue("Level ID (Alt)", 0x001685E8, "Int32", "Game State", "Level ID alternate location",
@"0x00 = Main menu
0x01 = Veldin
0x02 = Florana
0x03 = Starship
0x04 = Marcadia"));

            // ==================== GAME STATE ====================
            memoryValues.Add(new MemoryValue("In Main Menu", 0x0016C598, "Int32", "Game State", "FFFFFFFF = In main menu"));
            memoryValues.Add(new MemoryValue("Timer", 0x001D5528, "Int32", "Game State", "Game timer"));
            memoryValues.Add(new MemoryValue("Is Allowed in Ship", 0x001D5533, "Int8", "Game State", "Is allowed in ship flag"));
            memoryValues.Add(new MemoryValue("New Save Game", 0x001D55E8, "Int32", "Game State", "New save game flag"));
            memoryValues.Add(new MemoryValue("Sly Protection", 0x0015BD80, "Int32", "Game State", "Sly protection flag"));
            memoryValues.Add(new MemoryValue("Sly Protection (Alt)", 0x000181BC, "Int32", "Game State", "Sly protection - doesn't work after exiting demo (remains FFFFFFFF)"));
            memoryValues.Add(new MemoryValue("Memory Card Reading", 0x01FFF734, "Int32", "Game State", "Reading memory card in game (0x3E846CCD)"));

            // ==================== PLAYER STATE ====================
            memoryValues.Add(new MemoryValue("X Coordinate", 0x001A4C60, "Float", "Player Position", "X position"));
            memoryValues.Add(new MemoryValue("Y Coordinate", 0x001A4C64, "Float", "Player Position", "Y position"));
            memoryValues.Add(new MemoryValue("Z Coordinate", 0x001A4C68, "Float", "Player Position", "Z position"));
            memoryValues.Add(new MemoryValue("Inferno Mode Timer", 0x001A4E14, "Int32", "Player State", "Inferno Mode timer"));
            memoryValues.Add(new MemoryValue("Character Being Played", 0x001A4E18, "Int8", "Player State", "Character being played",
@"0x00 = Ratchet
0x04 = Tyhrranoids"));
            memoryValues.Add(new MemoryValue("Wrench Value Changed", 0x001A5720, "Int32", "Player State", "Value changes when wrench is used (stays 0 after death till swung)"));
            memoryValues.Add(new MemoryValue("Weapon Changes Count", 0x001A5DFB, "Int8", "Player State", "How many times player has changed weapon in one life"));
            memoryValues.Add(new MemoryValue("Time on Planet", 0x001A5E00, "Int32", "Player State", "Current time on one planet"));
            memoryValues.Add(new MemoryValue("Weapon Currently Used", 0x001A5E08, "Int32", "Player State", "Weapon currently in use"));
            memoryValues.Add(new MemoryValue("Last Weapon Used", 0x00142670, "Int8", "Player State", "Last weapon used"));
            memoryValues.Add(new MemoryValue("Weapon in VR", 0x001427B6, "Int8", "Player State", "Weapon used in VR"));
            memoryValues.Add(new MemoryValue("Playing as Clank", 0x001A71C4, "Int8", "Player State", "Playing as Clank (0x01 = Clank)"));
            memoryValues.Add(new MemoryValue("In Vehicle", 0x001A71C5, "Int8", "Player State", "In vehicle flag"));
            memoryValues.Add(new MemoryValue("Animation State", 0x001A71CD, "Int8", "Player State", "Teleported/death animation (turns 1 during animation)"));
            memoryValues.Add(new MemoryValue("Weapon Used (Alt)", 0x001A71F4, "Int32", "Player State", "Weapon currently used (0x2f)"));
            memoryValues.Add(new MemoryValue("Multiplier 2x Active", 0x001A74A8, "Int32", "Player State", "Multiplier of 2x is on"));
            memoryValues.Add(new MemoryValue("Strafe Stats", 0x001A7C4C, "Int32", "Player State", "Strafe statistics"));
            memoryValues.Add(new MemoryValue("Player is Active", 0x001CD020, "Int8", "Player State", "Player is active (0x04)"));

            // ==================== INPUT ====================
            memoryValues.Add(new MemoryValue("Input D-Pad/Start", 0x001CD0C2, "Int8", "Input", "Input bitflags 1",
@"Bit 7 = D-Pad Left
Bit 6 = D-Pad Down
Bit 5 = D-Pad Right
Bit 4 = D-Pad Up
Bit 3 = Start
Bit 2 = R3
Bit 1 = L3
Bit 0 = Select"));
            memoryValues.Add(new MemoryValue("Input Buttons", 0x001CD0C3, "Int8", "Input", "Input bitflags 2",
@"Bit 7 = Square
Bit 6 = X
Bit 5 = Circle
Bit 4 = Triangle
Bit 3 = R1
Bit 2 = L2
Bit 1 = R2
Bit 0 = L2"));

            // ==================== SAVE PROTECTION ====================
            memoryValues.Add(new MemoryValue("Save Game Protection", 0x001CD098, "Int8", "Save Protection", "Save game protection (0x04)"));
            memoryValues.Add(new MemoryValue("Protection State", 0x001D668C, "Int32", "Save Protection", "Protection state",
@"0x03 = Save protection
0x06 = Entered ship"));
            memoryValues.Add(new MemoryValue("Protection Current", 0x001D6694, "Int32", "Save Protection", "Protection current",
@"0x00 = Current
0x03 = Pause
0x05 = Skin
0x06 = Going to another planet"));
            memoryValues.Add(new MemoryValue("Save Protection (Alt)", 0x001D66A6, "Int32", "Save Protection", "Save protection (does not include Qwark's hideout)"));
            memoryValues.Add(new MemoryValue("Save Protection Qwark", 0x001D66E6, "Int32", "Save Protection", "Save protection only at Qwark"));

            // ==================== CHALLENGE COMMAND CENTER ====================
            memoryValues.Add(new MemoryValue("Challenge Command Center", 0x001A626A, "Int16", "Challenges", "Challenge Command Center",
@"0x434D = Dr Nefarious
0x43C5 = When fighting Nefarious
0x434B = Biobliterator
0x4294 = Insomniac Museum"));
            memoryValues.Add(new MemoryValue("Marcadia Challenges", 0x001D7A60, "Int32", "Challenges", "Marcadia challenges"));
            memoryValues.Add(new MemoryValue("Aridia Missions", 0x001D7AA0, "Int8", "Challenges", "Aridia missions",
@"0x2A = Mission 1
0x2B = Mission 2
0x2C = Mission 3
0x2D = Mission 4"));
            memoryValues.Add(new MemoryValue("Marcadia Arena Challenge", 0x001DE6F0, "Int32", "Challenges", "Marcadia Arena challenge (0xA82 = Iron Shield)"));

            // ==================== BOSS HEALTH ====================
            memoryValues.Add(new MemoryValue("Courtney Gears Health", 0x01556560, "Int32", "Boss Health", "Courtney Gears health (Dynamic - State 1 saved locally)"));
            memoryValues.Add(new MemoryValue("Dr Nefarious Health", 0x01DBFD70, "Int32", "Boss Health", "Dr Nefarious health (Dynamic)"));
            memoryValues.Add(new MemoryValue("Health Bar Appeared", 0x001D8048, "Int32", "Boss Health", "Health bar has appeared (0x09)"));
            memoryValues.Add(new MemoryValue("Boss Fight Graph Health", 0x001D81A8, "Int32", "Boss Health", "Boss fight graph health (read only)"));
            memoryValues.Add(new MemoryValue("Shield Health", 0x001DFB40, "Int32", "Boss Health", "Shield health"));
            memoryValues.Add(new MemoryValue("Shield Health AN", 0x001E0540, "Int32", "Boss Health", "Shield health Annihilation Nation"));
            memoryValues.Add(new MemoryValue("Shield Health Marcadia", 0x001E0F40, "Int32", "Boss Health", "Shield health Marcadia"));
            memoryValues.Add(new MemoryValue("Shield Health Nefarious", 0x001E13C0, "Int32", "Boss Health", "Shield health Fight with Nefarious"));
            memoryValues.Add(new MemoryValue("Camera Focus Boss", 0x001E14C4, "Int8", "Boss Health", "Camera focuses on boss (Bit7)"));
            memoryValues.Add(new MemoryValue("Tyhrranosis Graph", 0x001D8168, "Int32", "Boss Health", "Graph Tyhrranosis"));
            memoryValues.Add(new MemoryValue("Tyrranoids at Nefarious", 0x001E043D, "Int8", "Boss Health", "Tyhrranoids at Dr Nefarious office"));

            // ==================== CHECKPOINTS ====================
            memoryValues.Add(new MemoryValue("Florana Checkpoints", 0x002348D2, "Int8", "Checkpoints", "Florana checkpoints (0x2B/0x30 = Path of death entrance, 0x5B = ended)"));
            memoryValues.Add(new MemoryValue("Obani Draco Checkpoint", 0x00234CD4, "Int16", "Checkpoints", "Obani Draco checkpoint"));
            memoryValues.Add(new MemoryValue("Crash Site Checkpoint", 0x00234ED0, "Int8", "Checkpoints", "Checkpoint Crash site"));
            memoryValues.Add(new MemoryValue("Final Level", 0x00235630, "Int8", "Checkpoints", "Final Level - Dr Nefarious (0x00)"));
            memoryValues.Add(new MemoryValue("Final Level Replay", 0x0023563C, "Int8", "Checkpoints", "Final Level replay fight with Dr (when 0x00)"));
            memoryValues.Add(new MemoryValue("Final Level (Alt)", 0x002359B0, "Int8", "Checkpoints", "Final Level - Dr Nefarious (0x00)"));

            // ==================== CUTSCENES ====================
            memoryValues.Add(new MemoryValue("Courtney Gears Video", 0x00142BAD, "Int8", "Cutscenes", "Courtney Gears video played"));
            memoryValues.Add(new MemoryValue("Obani Completed", 0x00142BB2, "Int8", "Cutscenes", "Obani completed (Bit 3)"));
            memoryValues.Add(new MemoryValue("Ending Command Center", 0x00142BB6, "Int8", "Cutscenes", "Ending Command Center (Bit 6)"));
            memoryValues.Add(new MemoryValue("Cinematic Played", 0x00142C29, "Int8", "Cutscenes", "Cinematic has been played (Bit 3)"));
            memoryValues.Add(new MemoryValue("Get to Command Center", 0x00142C49, "Int8", "Cutscenes", "Get to the command center (Bit 3)"));
            memoryValues.Add(new MemoryValue("Nefarious Walk", 0x0020205C, "Int8", "Cutscenes", "Nefarious walk (0x2D)"));

            // ==================== POINTERS ====================
            memoryValues.Add(new MemoryValue("Enemy 1 Pointer", 0x0021C128, "Int32", "Pointers", "Enemy 1 on screen pointer",
@"+0x10 = X coordinates
+0x14 = Y coordinates
+0x18 = Z coordinates"));
            memoryValues.Add(new MemoryValue("Teleport Numbers", 0x0021DDA0, "Int32", "Pointers", "If teleports, numbers change"));
            memoryValues.Add(new MemoryValue("Save Protection Pointer", 0x001DAF5C, "Int32", "Pointers", "Pointer (+0x001D6666 = Save protection)"));
            memoryValues.Add(new MemoryValue("Mothership Health Pointer", 0x001DF890, "Int32", "Pointers", "Pointer (0xFFFE4FB0 = Mothership health)"));
            memoryValues.Add(new MemoryValue("Boss Health Pointer", 0x01FFF110, "Int32", "Pointers", "Boss Health Pointer (+0x1F680)"));
            memoryValues.Add(new MemoryValue("Multi-Purpose Pointer", 0x01FFF2D0, "Int32", "Pointers", "Multi-purpose pointer",
@"+0xFFFFBBC0 = Qwark's health Florana
+0x160 = Snow/rain Holostar studio (studio number 2)
+0x25D0 = Courtney Gears health"));

            // ==================== HOLOSTAR WEATHER ====================
            memoryValues.Add(new MemoryValue("Snowing Studio State 1", 0x01B6F3D0, "Int32", "Weather", "Snowing Studio state 1"));
            memoryValues.Add(new MemoryValue("State 2 Rain", 0x01B70F91, "Int8", "Weather", "State 2 rain"));
            memoryValues.Add(new MemoryValue("Holostar Weather", 0x01B8E760, "Int8", "Weather", "Holostar Studio weather (0x01 = Snowing, 0x00 = Rain)"));

            // ==================== SUCK CANNON OBJECTS (TYHRRANOSIS) ====================
            memoryValues.Add(new MemoryValue("Suck Cannon Object 1", 0x0028EDA0, "Int16", "Suck Cannon Objects", "Tyhrranosis - Suck cannon object ID 1"));
            memoryValues.Add(new MemoryValue("Suck Cannon Object 2", 0x0028EDA4, "Int16", "Suck Cannon Objects", "Tyhrranosis - Suck cannon object ID 2"));
            memoryValues.Add(new MemoryValue("Suck Cannon Object 3", 0x0028EDA8, "Int16", "Suck Cannon Objects", "Tyhrranosis - Suck cannon object ID 3"));
            memoryValues.Add(new MemoryValue("Suck Cannon Object 4", 0x0028EDAC, "Int16", "Suck Cannon Objects", "Tyhrranosis - Suck cannon object ID 4"));
            memoryValues.Add(new MemoryValue("Suck Cannon Object 5", 0x0028EDB0, "Int16", "Suck Cannon Objects", "Tyhrranosis - Suck cannon object ID 5"));
            memoryValues.Add(new MemoryValue("Suck Cannon Object 6", 0x0028EDB4, "Int16", "Suck Cannon Objects", "Tyhrranosis - Suck cannon object ID 6"));
            memoryValues.Add(new MemoryValue("Suck Cannon Object 7", 0x0028EDB8, "Int16", "Suck Cannon Objects", "Tyhrranosis - Suck cannon object ID 7"));
            memoryValues.Add(new MemoryValue("Suck Cannon Object 8", 0x0028EDBC, "Int16", "Suck Cannon Objects", "Tyhrranosis - Suck cannon object ID 8"));
            memoryValues.Add(new MemoryValue("Suck Cannon Object 9", 0x0028EDC0, "Int16", "Suck Cannon Objects", "Tyhrranosis - Suck cannon object ID 9"));
            memoryValues.Add(new MemoryValue("Suck Cannon Object 10", 0x0028EDC4, "Int16", "Suck Cannon Objects", "Tyhrranosis - Suck cannon object ID 10"));
            memoryValues.Add(new MemoryValue("Suck Cannon Object 11", 0x0028EDC8, "Int16", "Suck Cannon Objects", "Tyhrranosis - Suck cannon object ID 11"));
            memoryValues.Add(new MemoryValue("Suck Cannon Object 12", 0x0028EDCC, "Int16", "Suck Cannon Objects", "Tyhrranosis - Suck cannon object ID 12"));
            memoryValues.Add(new MemoryValue("Suck Cannon Object 13", 0x0028EDD0, "Int16", "Suck Cannon Objects", "Tyhrranosis - Suck cannon object ID 13"));
            memoryValues.Add(new MemoryValue("Suck Cannon Object 14", 0x0028EDD4, "Int16", "Suck Cannon Objects", "Tyhrranosis - Suck cannon object ID 14"));
            memoryValues.Add(new MemoryValue("Suck Cannon Object 15", 0x0028EDD8, "Int16", "Suck Cannon Objects", "Tyhrranosis - Suck cannon object ID 15"));
            memoryValues.Add(new MemoryValue("Suck Cannon Object 16", 0x0028EDDC, "Int16", "Suck Cannon Objects", "Tyhrranosis - Suck cannon object ID 16"));
            memoryValues.Add(new MemoryValue("Suck Cannon Object 17", 0x0028EDE0, "Int16", "Suck Cannon Objects", "Tyhrranosis - Suck cannon object ID 17"));
            memoryValues.Add(new MemoryValue("Suck Cannon Object 18", 0x0028EDE4, "Int16", "Suck Cannon Objects", "Tyhrranosis - Suck cannon object ID 18"));
            memoryValues.Add(new MemoryValue("Suck Cannon Object 19", 0x0028EDE8, "Int16", "Suck Cannon Objects", "Tyhrranosis - Suck cannon object ID 19"));
            memoryValues.Add(new MemoryValue("Suck Cannon Object 20", 0x0028EDEC, "Int16", "Suck Cannon Objects", "Tyhrranosis - Suck cannon object ID 20"));

            // ==================== TYHRRANOSIS GUN ====================
            memoryValues.Add(new MemoryValue("Tyhrranosis With Gun", 0x001BC2FA, "Int8", "Misc", "Tyhrranosis with gun flag"));

            // ==================== SLY 2 CROSSOVER ====================
            memoryValues.Add(new MemoryValue("Sly 2 Last Mission", 0x003E5B7C, "Int32", "Misc", "Last mission completed in Sly 2"));

            return memoryValues;
        }
    }
}
