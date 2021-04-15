using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoPapirOllo_VizsgaFeladat
{
    class Gep : Ellenfel
    {
        public Veletlen strVel;
        public Minden strMind;
        public ElozotUti strElUt;

        public Gep() : this("Gép")
        {
            ;
        }
        public Gep(string nev) : base(nev)
        {
            Nev = nev;
            strVel = new Veletlen();
            strMind = new Minden();
            strElUt = new ElozotUti();
            
        }
        public void tippel()
        {
            int i = 0;
            while (!Strategia.LetezoStrategiak[i].Aktiv)
            {
                i++;
            }
            Tipp = Strategia.LetezoStrategiak[i].tippel();

            //Tipp tipp = Tipp.NincsTipp;
            //if (Form1.strVeletlen) tipp = strVel.tippel();
            //if (Form1.strMinden) tipp = strMind.tippel();
            //if (Form1.strElozotUti) tipp = strElUt.tippel();
            //Tipp = tipp;

        }
    }
}
