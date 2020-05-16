using System;
using System.Collections.Generic;

namespace ProjN3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Weapone> arsenal = new List<Weapone>();

            Weapone smg = new Weapone("smg",50);
            Weapone pistol = new Weapone("pistol",15);
            Weapone rifle = new Weapone("rifle",30);

            arsenal.Add(smg);
            arsenal.Add(pistol);
            arsenal.Add(rifle);

            foreach (Weapone x in arsenal)
            {
                x.Reload();
                x.Shoot(1.1, 2.2);
                x.EmptyMagazine();
                Console.WriteLine();
            }
        }
    }
}
