using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ammo system");
            // we wish to store the ammo of all weapons:
            //pistol 6/6
            // shotgun 2/2
            // ... etc

            int weapon = 0; // 0 = pistol, 1 = shotgun, ... etc

            
            Console.WriteLine("BEFORE arrays:");

            int pistolAmmo = 6; // declaration & initialization
            int shotGunAmmo = 2;
            // .... etc

            // how do we show the ammo of teh current weapon?
            if (weapon == 0)
            {
                Console.WriteLine("pistol ammo:" + pistolAmmo); 
            }
            else if (weapon == 1)
            {
                Console.WriteLine("shotgun ammo:" + shotGunAmmo);
            }
            // etc


            Console.WriteLine("arrays:");






            Console.ReadKey(true);
        }
    }
}
