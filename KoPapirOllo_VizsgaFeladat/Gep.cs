using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoPapirOllo_VizsgaFeladat
{
    class Gep : Ellenfel
    {
        private Veletlen strVel;
        private Minden strMind;
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
            Tipp tipp = Tipp.NincsTipp;
            if (Form1.strVeletlen) tipp = strVel.tippel();
            if (Form1.strMinden) tipp = strMind.tippel();
            if (Form1.strElozotUti) tipp = strElUt.tippel();
            Tipp = tipp;

        }
    }
}
