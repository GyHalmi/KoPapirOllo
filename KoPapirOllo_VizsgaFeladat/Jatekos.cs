using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoPapirOllo_VizsgaFeladat
{
    class Jatekos : Ellenfel
    {
        public Tipp ElozoTipp { get; set; }

        public Jatekos() : this("Játékos")
        {
            ;
        }
        public Jatekos(string nev) : base(nev)
        {
            ElozoTipp = Tipp.NincsTipp;
        }
    }
}
