using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace KoPapirOllo_VizsgaFeladat
{
    abstract class Strategia
    {
        private static Random rnd;
        //public static int jatszottKorok { get; set; }
        //public static int gepNyert { get; set; }
        //public static int jatekosNyert { get; set; }
        public string Nev { get; set; }

        public Strategia(string nev)
        {
            rnd = new Random();
            Nev = nev;
            //jatszottKorok = 0;
            //jatekosNyert = 0;
            //gepNyert = 0;
        }

        public abstract Tipp tippel();
        
        protected int veletlenSzam()
        {
            return rnd.Next(0, 3);
        }
        //public override string ToString()
        //{
        //    return $"Stratégia: ${Nev} ({jatszottKorok} kör)\n" +
        //        $"Gép nyert: {gepNyert}, Játékos nyert: {jatekosNyert}, Döntetlen: {jatszottKorok - gepNyert - jatekosNyert}";
        //}

    }
}
