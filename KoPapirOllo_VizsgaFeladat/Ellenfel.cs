using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoPapirOllo_VizsgaFeladat
{
    abstract class Ellenfel
    {
        public string Nev { get; set; }
        public Tipp Tipp { get; set; }
        public int NyertKorok { get; set; }
        public Ellenfel(string nev)
        {
            Nev = nev;
            NyertKorok = 0;
            Tipp = Tipp.NincsTipp;
        }
        public string tippSzoveg()
        {
            string valasz = "";
            switch (Tipp)
            {
                case Tipp.Ko:
                    valasz = "kő";
                    break;
                case Tipp.Papir:
                    valasz = "papír";
                    break;
                case Tipp.Ollo:
                    valasz = "olló";
                    break;
                default:
                    break;
            }
            return valasz;
        }

    }
}
