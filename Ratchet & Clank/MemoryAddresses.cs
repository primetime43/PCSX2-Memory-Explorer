using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ratchet___Clank
{
    public static class MemoryAddresses
    {
        public enum RA1_Address_MISC : int
        {
            // Misc
            State = 0x001413D4, // 4 bytes
            XCoordinate = 0x0013F3D0, // Float
            YCoordinate = 0x0013F3D4, // Float
            ZCoordinate = 0x0013F3D8, // Float
            Rotation = 0x0013F3E8, // Float
            Bolts = 0x0015ED98, // 4 bytes
            RunningSpeed = 0x0013F5E4, // Float
            Nanotech = 0x001415F8, // Byte
        }

        public enum RA1_Address_AMMO : int
        {
            // Ammo - All are 4 bytes
            BombGloveAmmo = 0x0013D450,
            DevastatorAmmo = 0x0013D454,
            VisibombGunAmmo = 0x0013D45C,
            BlasterAmmo = 0x0013D464,
            PyrocitorAmmo = 0x0013D468,
            MineGloveAmmo = 0x0013D46C,
            TeslaClawAmmo = 0x0013D474,
            GloveOfDoomAmmo = 0x0013D478,
            RYNOAmmo = 0x0013D484,
            DroneDeviceAmmo = 0x0013D488,
            DecoyGloveAmmo = 0x0013D48C,
        }

        public enum RA1_Address_INVENTORY : int
        {
            // Inventory  1 = Owned, 0 = Not Owned - All are 1 byte
            HeliPack = 0x0013D4C2,
            ThrusterPack = 0x0013D4C3,
            HydroPack = 0x0013D4C4,
            SonicSummoner = 0x0013D4C5,
            O2Mask = 0x0013D4C6,
            PilotsHelmet = 0x0013D4C7,
            Wrench = 0x0013D4C8,
            SuckCannon = 0x0013D4C9,
            BombGlove = 0x0013D4CA,
            Devastator = 0x0013D4CB,
            SwingShot = 0x0013D4CC,
            VisibombGun = 0x0013D4CD,
            Taunter = 0x0013D4CE,
            Blaster = 0x0013D4CF,
            Pyrocitor = 0x0013D4D0,
            MineGlove = 0x0013D4D1,
            Walloper = 0x0013D4D2,
            TeslaClaw = 0x0013D4D3,
            GloveOfDoom = 0x0013D4D4,
            MorphORay = 0x0013D4D5,
            Hydrodisplacer = 0x0013D4D6,
            RYNO = 0x0013D4D7,
            DroneDevice = 0x0013D4D8,
            DecoyGlove = 0x0013D4D9,
            Trespasser = 0x0013D4DA,
            MetalDetector = 0x0013D4DB,
            Magneboots = 0x0013D4DC,
            Grindboots = 0x0013D4DD,
            Hoverboard = 0x0013D4DE,
            Hydropack = 0x0013D4DF,
            Holodisguise = 0x0013D4E0,
            PDA = 0x0013D4E1,
            MapOMatic = 0x0013D4E2,
            BoltGrabber = 0x0013D4E3,
            Persuader = 0x0013D4E4,
            Zoomerator = 0x0013D4E5,
            Raritanium = 0x0013D4E6,
            Codebot = 0x0013D4E7,
            PremiumNanotech = 0x0013D3BC,
            UltraNanotech = 0x0013D3BD,
        }

        public enum RA1_Address_GOLD : int
        {
            // Gold Weapons/Gadgets - All are 1 byte
            GoldHeliPack = 0x0013E522,
            GoldThrusterPack = 0x0013E523,
            GoldHydroPack = 0x0013E524,
            GoldSonicSummoner = 0x0013E525,
            GoldO2Mask = 0x0013E526,
            GoldPilotsHelmet = 0x0013E527,
            GoldWrench = 0x0013E528,
            GoldSuckCannon = 0x0013E529,
            GoldBombGlove = 0x0013E52A,
            GoldDevastator = 0x0013E52B,
            GoldSwingShot = 0x0013E52C,
            GoldVisibombGun = 0x0013E52D,
            GoldTaunter = 0x0013E52E,
            GoldBlaster = 0x0013E52F,
            GoldPyrocitor = 0x0013E530,
            GoldMineGlove = 0x0013E531,
            GoldWalloper = 0x0013E532,
            GoldTeslaClaw = 0x0013E533,
            GoldGloveOfDoom = 0x0013E534,
            GoldMorphORay = 0x0013E535,
            GoldHydrodisplacer = 0x0013E536,
            GoldRYNO = 0x0013E537,
            GoldDroneDevice = 0x0013E538,
            GoldDecoyGlove = 0x0013E539,
            GoldTrespasser = 0x0013E53A,
            GoldMetalDetector = 0x0013E53B,
            GoldMagneboots = 0x0013E53C,
            GoldGrindboots = 0x0013E53D,
            GoldHoverboard = 0x0013E53E,
            GoldHydropack = 0x0013E53F,
            GoldHolodisguise = 0x0013E540,
            GoldPDA = 0x0013E541,
            GoldMapOMatic = 0x0013E542,
            GoldBoltGrabber = 0x0013E543,
            GoldPersuader = 0x0013E544
        }

        public enum RA2_Address : int
        {
            Bolts = 0x001A7A00
        }
    }
}
