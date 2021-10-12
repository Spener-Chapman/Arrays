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
            Console.WriteLine();
            // we wish to store the ammo of all weapons:
            //pistol 6/6
            // shotgun 2/2
            // ... etc

            int weapon = 0; // 0 = pistol, 1 = shotgun, ... etc

            
            Console.WriteLine("BEFORE arrays:");

            int pistolAmmo = 6; // declaration & initialization
            int shotGunAmmo = 2;
            int BFG = 20;
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

            // too much, many chane for errors
            Console.WriteLine();
            Console.WriteLine("arrays:");

            // this is an array
            int[] ammo; // declaration telling ammo is an array of intergers (the [])
            // so "ammo" is an array of interger

            ammo = new int[3]; // initialization (telling the compiler the size)
            ammo[0] = 6; //pistol
            ammo[1] = 2; //shotgun
            ammo[2] = 20; //bfg

            string[] weaponName = new string[3];
            weaponName[0] = "Pistol";
            weaponName[1] = "Shotgun";
            weaponName[2] = "BFG";


            // how do we show the ammo of teh current weapon?

            Console.WriteLine("pistol ammo:" + ammo[0]);
            Console.WriteLine("pistol ammo:" + ammo[1]);

            // NOT CORRECT
            // BELOW IS CORRECT

            Console.WriteLine("ammo: " + ammo[weapon]); // this is correct
            weapon = 2;
            Console.WriteLine("ammo: " + ammo[weapon]);
            
            Console.WriteLine(weaponName[weapon] + " ammo: " + ammo[weapon]);




            Console.ReadKey(true);
        }
    }
}
