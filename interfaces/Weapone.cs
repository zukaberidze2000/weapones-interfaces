using System;
using System.Collections.Generic;
using System.Text;

namespace ProjN3
{
    class Weapone : Functions
    { 
        public string name { get; set; } // name of weapone
        List<Bullet> magazine; //magazine
        int bulletNum { get; set; } // number of bullets  
        public bool IsActive { get; set; }
        public Weapone(string itsname,int x) //contsructor
        {
            Console.WriteLine("you have " + itsname);
            List<Bullet> magazine = new List<Bullet>(x);
            this.name = itsname;
            this.bulletNum = x;
        }
        public void Shoot() //shoot 
        {
            magazine.RemoveAt(magazine.Count - 1);
            Console.WriteLine("Fire");
            if (magazine.Count == 0) 
                Console.WriteLine("you need reload");
        }
        public void EmptyMagazine() // make magazine empty
        {
            magazine.Clear();
            Console.WriteLine("magazine is empty");
        }
        public void Reload() //Reload
        {
            Bullet b = new Bullet();
            for (int i = 0; i < bulletNum + 1; i++)
            {
                magazine.Add(b);
            }
            Console.WriteLine($"{this.name} is ready to shoot with {bulletNum} bullets");
        }
    }
}
