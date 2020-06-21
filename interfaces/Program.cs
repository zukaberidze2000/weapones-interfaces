using System;
using System.Collections.Generic;
using System.Dynamic;

namespace ProjN3
{
    class Program
    {
        static void Main(string[] args)
        {
            var PlayerN1 = new Person("leviatani");
            var m4 = new Weapone("M4", 30);
            var iz43 = new Weapone("IZ43", 2);
            var p90 = new Weapone("P90", 50);

            PlayerN1.Weapones.Add(m4);
            PlayerN1.Weapones.Add(iz43);
            PlayerN1.Weapones.Add(p90);

            PlayerN1.ChangeWeapone(PlayerN1.Weapones, p90.name);
            foreach(var weapone in PlayerN1.Weapones)
            {
                Console.WriteLine(weapone.name);
                Console.WriteLine(weapone.IsActive);
            }
            Console.ReadKey();
        }
    }
}
