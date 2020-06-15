using System;
using System.Collections.Generic;
using System.Dynamic;

namespace ProjN3
{
    class Program
    {
        static void Main(string[] args)
        {
            string wep;
            bool guy1 = true;
            bool guy2 = true;
            while (guy1)
            {
                Console.WriteLine("choose weapone: Awp for sniper, Colt for pistol, Uzi for smg");//for wapone choose
                wep = Console.ReadLine();
                switch (wep)
                {
                    case "Awp":
                        Weapone g = new Weapone("Awp", 10);
                        guy1 = false;
                        break;
                    case "Colt":
                        Weapone g = new Weapone("Colt", 10);
                        guy1 = false;
                        break;
                    case "Uzi":
                        Weapone g = new Weapone("Uzi", 10);
                        guy1 = false;
                        break;
                    default:
                        Console.WriteLine("try again");
                        break;
                }
            }
            
            while (guy2) 
            {
                Console.WriteLine("lets get play");//for play
                wep = Console.ReadLine();
                switch (wep)
                {
                    case "f":
                        g.shoot();
                        break;
                    case "r":
                        g.Reload();
                        break;
                    case "e":
                        g.EmptyMAgazine();
                        break;
                    default:
                        Console.WriteLine("try again");
                        break;
                }
                
            }
            
        }
    }
}
