using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoPapirOllo_VizsgaFeladat
{
    class Minden :  Strategia
    {
        private static int[] tippIndexek;
        public Minden() : base("Minden")
        {
            tippIndexekFeltolt();
        }
        public override Tipp tippel()
        {
            if (mindKilove()) tippIndexekFeltolt();

            int index;
            do
            {
                index = veletlenSzam();
            }
            while (tippIndexek[index] == -1);
            
            int tipp = tippIndexek[index];
            tippIndexek[index] = -1;
            return (Tipp)tipp;
        }
        private void tippIndexekFeltolt()
        {
            tippIndexek = new int[3];
            for (int i = 0; i < tippIndexek.Length; i++)
            {
                tippIndexek[i] = i;
            }
        }
        private bool mindKilove()
        {
            int i = 0;
            while (i < tippIndexek.Length && tippIndexek[i] == -1)
            {
                i++;
            }
            return i >= tippIndexek.Length;
        }
    }
}
