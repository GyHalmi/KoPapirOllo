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

        public static List<Strategia> LetezoStrategiak = new List<Strategia>();
        public string Nev { get; set; }
        public bool Aktiv { get; set; }

        public Strategia(string nev)
        {
            rnd = new Random();
            Nev = nev;
            LetezoStrategiak.Add(this);
        }

        public abstract Tipp tippel();

        public void aktival()
        {
            foreach (var str in LetezoStrategiak)
            {
                if (str == this) str.Aktiv = true;
                else str.Aktiv = false;
            }
        }
        
        protected int veletlenSzam()
        {
            return rnd.Next(0, 3);
        }

    }
}
