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
        //tipus
        public string Tipus { get; set; }
        //üzemanyag
        public string Uzemanyag { get; set; }
        //évjárat
        public int Ev { get; set; }
        //kép
        public string Kep { get; set; }
        public Car(string nev, string tipus, string uzemanyag, int ev, string source)
        {
            Nev = nev;
            Tipus = tipus;
            Uzemanyag = uzemanyag;
            Ev = ev;
            Kep = $@"..\..\..\imges\{source}"; 
        }

    }


}
