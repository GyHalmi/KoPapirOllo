using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KoPapirOllo_VizsgaFeladat
{
    public partial class Form1 : Form
    {
        private int tervezettKorok;
        private int lejatszottKorok;
        private List<Kor> statisztika;

        private Tipp jatekosTippje;
        private Tipp gepTippje;
        private Random rnd;
        private List<RadioButton> rdbk;

        enum Tipp { Ko, Papir, Ollo };

        ToolStripMenuItem[] strategiak;
        int[] mindenTipp;
        Tipp jatekosUtolso;

        public Form1()
        {
            InitializeComponent();
            rdbLista();
            jatekterIni();
            mindenTippFeltolt();
            strategiaTomb();

            MessageBox.Show("minden stratégia tesztelése..........");

        }
        private void mindenTippFeltolt()
        {
            mindenTipp = new int[3];
            for (int i = 0; i < mindenTipp.Length; i++)
            {
                mindenTipp[i] = i;
            }
        }
        private void rdbLista()
        {
            rdbk = new List<RadioButton>();
            foreach (var cont in contJatekter.Controls)
            {
                if (cont is RadioButton) rdbk.Add((RadioButton)cont);
            }
        }

        private void rdbAktiv(bool b)
        {
            foreach (var r in rdbk)
            {
                r.Enabled = b;
            }
        }
        private void rdbMindUres()
        {
            foreach (var r in rdbk)
            {
                r.Checked = false;
            }
        }

        private void jatekterIni()
        {
            rdbAktiv(false);
            numKorok.Minimum = 2;
            numKorok.Maximum = 20;
            //stratVeletlen.Checked = true;
            stratElozotUti.Checked = true;
            lblNyertes.Text = "";

            rdbKo.Tag = Tipp.Ko;
            rdbPapir.Tag = Tipp.Papir;
            rdbOllo.Tag = Tipp.Ollo;

            rdbKo.Click += rdb_Click;
            rdbPapir.Click += rdb_Click;
            rdbOllo.Click += rdb_Click;

            stratVeletlen.Tag = "véletlen";
            stratMinden.Tag = "minden";
            stratElozotUti.Tag = "előzőt üti";
        }

        private void strategiaTomb()
        {
            strategiak = new ToolStripMenuItem[3];
            strategiak[0] = stratVeletlen;
            strategiak[1] = stratMinden;
            strategiak[2] = stratElozotUti;
        }

        private void kezdes()
        {
            statisztika = new List<Kor>();
            rnd = new Random();
            strategiak = new ToolStripMenuItem[3];
            strategiak[0] = stratVeletlen;
            strategiak[1] = stratMinden;
            strategiak[2] = stratElozotUti;
            tervezettKorok = (int)numKorok.Value;
            lejatszottKorok = 0;
            rdbAktiv(true);
            lblNyertes.Text = "";
            rdbMindUres();
        }

        private void egyKor()
        {
            gepTipp();
            kiirastFrissit();
            lblNyertes.Text = nyertes();
            tippekTarolasa();
            lejatszottKorok++;
            //statisztikatJegyzez();
        }

        private void tippekTarolasa()
        {
            jatekosUtolso = jatekosTippje;
        }

        private void vege()
        {
            if (chbVegenMent.Checked) mentes();
            rdbAktiv(false);
            MessageBox.Show("vége");
        }

        //private void statisztikatJegyzez()
        //{
        //    string strat = "";
        //    if (stratVeletlen.Checked) strat = "véletlen";
        //    if (stratMinden.Checked) strat = "minden";
        //    if (stratElozotUti.Checked) strat = "előzőt üti";

        //    statisztika.Add(new Kor(jatekosTippje, gepTippje, strat, gepNyert()));
        //}

        private void gepTipp()
        {
            Tipp gTipp = (Tipp)1;
            //int utsoTipp = (int)Tipp.Ko;
            int velSzam()
            {
                return rnd.Next(0, 3);
            }

            if (stratVeletlen.Checked)
            {
                gTipp = (Tipp)velSzam();
            }
            if (stratMinden.Checked)
            {
                bool mindKilove()
                {
                    int i = 0;
                    while (i <mindenTipp.Length && mindenTipp[i] == -1)
                    {
                        i++;
                    }
                    return i >= mindenTipp.Length;
                }

                if (mindKilove()) mindenTippFeltolt();
                int index = velSzam();
                while (mindenTipp[index] == -1)
                {
                    index = velSzam();
                }
                gTipp = (Tipp)index;
                mindenTipp[index] = -1; // ezt lehet nem itt kéne
            }
            if (stratElozotUti.Checked)
            {
                int i = 1;
                while (!tamadoNyert((Tipp)i, jatekosUtolso))
                {
                    i++;
                }
                gTipp = (Tipp)i;
            }
            gepTippje = gTipp;
        }

        private void kiirastFrissit()
        {
            lblGepTipp.Text = tippSzoveg(gepTippje);
            string korKiiras = ". kör nyertese:";
            lblKorSzamlalo.Text = lejatszottKorok + 1 + korKiiras;
        }

        private void mentes()
        {
            string fajl = "statisztika.txt";
            string tartalom = "MÓDSZER;LEJÁTSZOTT KÖRÖK;NYERT KÖRÖK\n";

            int vel = 0;
            int mind = 0;
            int eloz = 0;
            int nyertVel = 0;
            int nyertMind = 0;
            int nyertEloz = 0;
            foreach (Kor kor in statisztika)
            {
                if (kor.Strategia == "véletlen")
                {
                    vel++;
                    if (kor.GepNyert) nyertVel++;
                }
                if (kor.Strategia == "minden")
                {
                    mind++;
                    if (kor.GepNyert) nyertMind++;
                }
                if (kor.Strategia == "előzőt üti")
                {
                    eloz++;
                    if (kor.GepNyert) nyertEloz++;
                }
            }
            tartalom += $"véletlen;{vel};{nyertVel}\n";
            tartalom += $"minden;{mind};{nyertMind}\n";
            tartalom += $"előzőt üti;{eloz};{nyertEloz}\n";
            File.WriteAllText(fajl, tartalom);

        }
        private bool tamadoNyert(Tipp tamado, Tipp vedo)
        {
            bool nyert = false;
            string tam = tippSzoveg(tamado);
            string ved = tippSzoveg(vedo);
            if (ved == "kő" && tam == "papír") nyert = true;
            if (ved == "papír" && tam == "olló") nyert = true;
            if (ved == "olló" && tam == "kő") nyert = true;
            return nyert;
        }
        private string nyertes()
        {
            string nyert = "Döntetlen";
            if (jatekosTippje != gepTippje)
            {
                nyert = tamadoNyert(gepTippje, jatekosTippje) ? "Gép" : "Játékos";
            }
            return nyert;
        }

        private void btnJatekIndul_Click(object sender, EventArgs e)
        {
            kezdes();
        }
        private void rdb_Click(object sender, EventArgs e)
        {
            jatekosTippje = (Tipp)((RadioButton)sender).Tag;

            if (lejatszottKorok < tervezettKorok) egyKor();
            else vege();

        }

        private void btnMentes_Click(object sender, EventArgs e)
        {
            mentes();
        }

        private string tippSzoveg(Tipp tipp)
        {
            string valasz = "";
            switch (tipp)
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

        private void stratMinden_Click(object sender, EventArgs e)
        {
            pipalHaNemVolt(sender);
            if (stratMinden.Checked) mindenTippFeltolt();
        }

        private void stratVeletlen_Click(object sender, EventArgs e)
        {
            pipalHaNemVolt(sender);
        }

        private void stratElozotUti_Click(object sender, EventArgs e)
        {
            pipalHaNemVolt(sender);
        }

        private void pipalHaNemVolt(object sender)
        {
            ToolStripMenuItem strat = (ToolStripMenuItem)sender;
            if (strat.Checked == false)
            {
                foreach (var st in strategiak)
                {
                    if (strat.Name == st.Name) st.Checked = true;
                    else st.Checked = false;
                }
            }
        }

    }
}
