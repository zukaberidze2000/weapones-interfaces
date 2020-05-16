using System;
using System.Collections.Generic;
using System.Text;

namespace ProjN3
{
    class Weapone : Functions
    { 
        string name { get; set; } // name of weapone
        object magazine { get; set; } //magazine
        int bulletNum { get; set; } // number of bullets
        public Weapone(string itsname,int x) //contsructor
        {
            this.name = itsname;
            this.bulletNum = x;
        }
        public void Shoot(double x, double y) //shoot to cordinate x y
        {
            Console.WriteLine($"bullet goes to codrinates: {x} {y}"); 
        }
        public void EmptyMagazine() // make magazine empty
        {
            magazine = 0;
            Console.WriteLine("magazine in empty");
        }
        public void Reload() //Reload
        {
            this.magazine = this.bulletNum;
            Console.WriteLine($"{this.name} is ready to shoot with {bulletNum} bullets");
        }
    }
}
