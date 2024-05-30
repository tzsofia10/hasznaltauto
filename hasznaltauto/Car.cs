using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hasznaltauto
{
    internal class Car
    {
        public string Nev { get; set; }

        public string Tipus { get; set;}

        public string Uzemanyag { get; set; }

        public int Ev { get; set; }
     
        public string Kep { get; set; }

        public Car(string Nev, string Tipus, string Uzemanyag, int Ev, string source) 
        {
            Nev = Nev;
            Tipus = Tipus;
            Uzemanyag = Uzemanyag;
            Tipus = Tipus;
            Kep = $@"..\..\..\imges\{source}";
        }

    }


}
