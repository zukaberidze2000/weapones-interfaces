using System;
using System.Collections.Generic;
using System.Text;

namespace ProjN3
{
    class Person
    {
        public string nickname { get; private set; }
        public List<Weapone> Weapones { get; set; }
        public Person(string name)
        {
            this.nickname = name;
            Weapones = new List<Weapone>();
        }

        public void ChangeWeapone(List<Weapone> Weapones, string WeaponeName)
        {
            foreach (var weapone in Weapones)
            {
                if (weapone.name.Equals(WeaponeName))
                {
                    weapone.IsActive = true; 
                }
            }
        }
    }
}
