using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoPapirOllo_VizsgaFeladat
{
    class Veletlen : Strategia
    {
        public Veletlen(): base("Véletlen")
        {

        }
        public override Tipp tippel()
        {
            return (Tipp)veletlenSzam();
        }
    }
}
