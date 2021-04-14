using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoPapirOllo_VizsgaFeladat
{
    class ElozotUti : Strategia
    {
        public Tipp jatekosUtolsoTippje { get; set; }
        public ElozotUti() :base ("Előzőt üti")
        {
            jatekosUtolsoTippje = Tipp.NincsTipp;
        }
        public override Tipp tippel()
        {
            Tipp tipp = Tipp.NincsTipp;
            if (jatekosUtolsoTippje == tipp)
            {
                tipp = (Tipp)veletlenSzam();
            }
            else
            {
                Jatekos tamado = new Jatekos();
                Jatekos vedo = new Jatekos();
                vedo.Tipp = jatekosUtolsoTippje;
                do
                {
                    tamado.Tipp = (Tipp)veletlenSzam();
                } while (!JatekVezeto.tamadoNyert(tamado, vedo));
                tipp = tamado.Tipp;
            }
            return tipp;
        }
    }
}
