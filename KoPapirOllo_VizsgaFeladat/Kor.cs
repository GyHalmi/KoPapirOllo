using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoPapirOllo_VizsgaFeladat
{
    class Kor
    {
        public string JatekosTippje { get; set; }
        public string GepTippje { get; set; }
        public string Strategia { get; set; }
        public bool GepNyert { get; set; }

        public Kor(string jatekosTippje, string gepTippje, string strategia, bool gepNyert)
        {
            JatekosTippje = jatekosTippje;
            GepTippje = gepTippje;
            Strategia = strategia;
            GepNyert = gepNyert;
        }
    }
}
