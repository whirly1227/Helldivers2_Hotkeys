using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media.Media3D;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Keyboard = InputMethods.Keyboard;

namespace Helldivers2_Hotkeys
{
    internal class Stratagems
    {
        private static Key Up = Key.W;
        private static Key Down = Key.S;
        private static Key Left = Key.A;
        private static Key Right = Key.D;

        public static Key[] Resupply                       = [Down, Down, Up, Right];
        public static Key[] Reinforce                      = [Up, Down, Right, Left, Up];
        public static Key[] SOS                            = [Up, Down, Right, Up];
        public static Key[] Machine_Gun                    = [Down, Left, Down, Up, Right];
        public static Key[] Anti_Materiel_Rifle            = [Down, Left, Right, Up, Down];
        public static Key[] Stalwart                       = [Down, Left, Down, Up, Up, Left];
        public static Key[] Expendable_Anti_Tank           = [Down, Down, Left, Up, Right];
        public static Key[] Recoilless_Rifle	           = [Down, Left, Right, Right, Left];
        public static Key[] Flamethrower                   = [];
        public static Key[] Autocannon                     = [Down, Left, Down, Up, Up, Right];
        public static Key[] Railgun                        = [];
        public static Key[] Spear                          = [];
        public static Key[] Eagle_Strafing_Run             = [Up, Right, Right];
        public static Key[] Eagle_Airstrike	               = [Up, Right, Down, Right];
        public static Key[] Eagle_Cluster_Bomb             = [Up, Right, Down, Down, Right];
        public static Key[] Eagle_Napalm_Airstrike         = [Up, Right, Down, Up];
        public static Key[] Eagle_Smoke_Strike             = [];
        public static Key[] Eagle_110MM_Rocket_Pods        = [Up, Right, Up, Left];
        public static Key[] Eagle_500KG_Bomb               = [Up, Right, Down, Down, Down];
        public static Key[] Orbital_Gatling_Barrage        = [Right, Down, Left, Up, Up];
        public static Key[] Orbital_Airburst_Strike        = [Right, Right, Right];
        public static Key[] Orbital_120MM_HE_Barrage	   = [Right, Right, Down, Left, Right, Down];
        public static Key[] Orbital_380MM_HE_Barrage       = [Right, Down, Up, Up, Left, Down, Down];
        public static Key[] Orbital_Walking_Barrage        = [];
        public static Key[] Orbital_Laser	               = [];
        public static Key[] Orbital_Railcannon_Strike      = [];
        public static Key[] Orbital_Precision_Strike       = [Right, Right, Up];
        public static Key[] Orbital_Gas_Strike             = [];
        public static Key[] Orbital_EMS_Strike             = [];
        public static Key[] Orbital_Smoke_Strike           = [];
        public static Key[] Jump_Pack                      = [Down, Up, Up, Down, Up];
        public static Key[] HMG_Replacement                = [];
        public static Key[] Shield_Generator_Relay         = [];
        public static Key[] Tesla_Tower                    = [];
        public static Key[] Anti_Personnel_Minefield       = [];
        public static Key[] Supply_Pack                    = [];
        public static Key[] Grenade_Launcher               = [];
        public static Key[] Laser_Canon                    = [];
        public static Key[] Incendiary_Mines               = [];
        public static Key[] Guard_Dog_Rover                = [];
        public static Key[] Ballistic_Shield_Backpack      = [];
        public static Key[] Arc_Thrower                    = [];
        public static Key[] Shield_Generator_Pack          = [Down, Up, Left, Right, Left, Right];
        public static Key[] Machine_Gun_Sentry             = [Down, Up, Right, Right, Up];
        public static Key[] Gatling_Sentry                 = [Down, Up, Right, Left];
        public static Key[] Mortar_Sentry                  = [];
        public static Key[] Guard_Dog                      = [Down, Up, Left, Up, Right, Down];
        public static Key[] Autocannon_Sentry	           = [];
        public static Key[] Rocket_Sentry	               = [];
        public static Key[] EMS_Mortar_Sentry              = [];
    }
}
