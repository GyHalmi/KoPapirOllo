using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoPapirOllo_VizsgaFeladat
{
    static class JatekVezeto
    {

        public static int tervezettKorok;
        public static int lejatszottKorok;
                     
        public static bool tamadoNyert(Ellenfel tamado, Ellenfel vedo)
        {
            bool nyert = false;
            string tamadoTipp = tamado.tippSzoveg();
            string vedoTipp = vedo.tippSzoveg();
            if (vedoTipp == "kő" && tamadoTipp == "papír") nyert = true;
            if (vedoTipp == "papír" && tamadoTipp == "olló") nyert = true;
            if (vedoTipp == "olló" && tamadoTipp == "kő") nyert = true;
            return nyert;
        }
             
        public static string nyertes(Ellenfel jatekos, Ellenfel gep)
        {
            string nyert = "Döntetlen";
            if (jatekos.Tipp != gep.Tipp)
            {
                nyert = tamadoNyert(gep, jatekos) ? gep.Nev : jatekos.Nev;
            }
            return nyert;
        }


    }
}
