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
    //enum Tipp { NincsTipp=-1, Ko, Papir, Ollo };
    enum Tipp { Ko, Papir, Ollo, NincsTipp };
    public partial class Form1 : Form
    {

        private List<RadioButton> rdbk;
        private ToolStripMenuItem[] strategiak;

        public static bool strVeletlen;
        public static bool strMinden;
        public static bool strElozotUti;

        private Jatekos jatekos;
        private Gep gep;

        public Form1()
        {
            InitializeComponent();
            rdbLista();
            strategiaMenukLista();
            jatekterIni();

            jatekos = new Jatekos("Gyuri");
            gep = new Gep();

            numKorok.Value = 12;
            //MessageBox.Show(" az ElozotUti-hez el kell juttatni a jatekos.ElozoTipp-et ");


        }
   private void jatekterIni()
        {
            rdbAktiv(false);
            numKorok.Minimum = 2;
            numKorok.Maximum = 20;

            mnuVeletlen.Checked = true;
            strVeletlen = true;

            lblGepTipp.Text = "";
            lblNyertes.Text = "";

            rdbKo.Tag = Tipp.Ko;
            rdbPapir.Tag = Tipp.Papir;
            rdbOllo.Tag = Tipp.Ollo;

            rdbKo.Click += rdb_Click;
            rdbPapir.Click += rdb_Click;
            rdbOllo.Click += rdb_Click;
        }
        private void jatekIndul()
        {
            JatekVezeto.tervezettKorok = (int)numKorok.Value;
            JatekVezeto.lejatszottKorok = 0;
            jatekos.NyertKorok = 0;
            gep.NyertKorok = 0;
            rdbAktiv(true);
            rdbMindUres();
            lblNyertes.Text = "";
            lblGepTipp.Text = "";
        }

     

        private void egyKor()
        {
            gep.tippel();
            kiirastFrissit();
            lblNyertes.Text = JatekVezeto.nyertes(jatekos, gep);
            jatekos.ElozoTipp = jatekos.Tipp;
            gep.strElUt.jatekosUtolsoTippje = jatekos.ElozoTipp;
            JatekVezeto.lejatszottKorok++;
            if (JatekVezeto.tamadoNyert(jatekos, gep)) jatekos.NyertKorok++;
            if (JatekVezeto.tamadoNyert(gep, jatekos)) gep.NyertKorok++;
            //statisztikatJegyzez();
        }

        private void vege()
        {
            if (chbVegenMent.Checked) mentes();
            rdbAktiv(false);
            MessageBox.Show("vége\n" +
                $"{jatekos.Nev} ({jatekos.NyertKorok}) - {gep.Nev} ({gep.NyertKorok})");
        }

        //private void statisztikatJegyzez()
        //{
        //    string strat = "";
        //    if (stratVeletlen.Checked) strat = "véletlen";
        //    if (stratMinden.Checked) strat = "minden";
        //    if (stratElozotUti.Checked) strat = "előzőt üti";

        //    statisztika.Add(new Kor(jatekosTippje, gepTippje, strat, gepNyert()));
        //}


        private void mentes()
        {
            string fajl = "statisztika.txt";
            string tartalom = "MÓDSZER;LEJÁTSZOTT KÖRÖK;NYERT KÖRÖK\n";

            //int vel = 0;
            //int mind = 0;
            //int eloz = 0;
            //int nyertVel = 0;
            //int nyertMind = 0;
            //int nyertEloz = 0;
            //foreach (Kor kor in statisztika)
            //{
            //    if (kor.Strategia == "véletlen")
            //    {
            //        vel++;
            //        if (kor.GepNyert) nyertVel++;
            //    }
            //    if (kor.Strategia == "minden")
            //    {
            //        mind++;
            //        if (kor.GepNyert) nyertMind++;
            //    }
            //    if (kor.Strategia == "előzőt üti")
            //    {
            //        eloz++;
            //        if (kor.GepNyert) nyertEloz++;
            //    }
            //}
            //tartalom += $"véletlen;{vel};{nyertVel}\n";
            //tartalom += $"minden;{mind};{nyertMind}\n";
            //tartalom += $"előzőt üti;{eloz};{nyertEloz}\n";

            File.WriteAllText(fajl, tartalom);

        }


        //kezelőfelület
        private void strategiaMenukLista()
        {
            strategiak = new ToolStripMenuItem[3];
            strategiak[0] = mnuVeletlen;
            strategiak[1] = mnuMinden;
            strategiak[2] = mnuElozotUti;
        }
        private void rdbLista()
        {
            rdbk = new List<RadioButton>();
            foreach (var cont in contJatekter.Controls)
            {
                if (cont is RadioButton) rdbk.Add((RadioButton)cont);
            }
        }

        private void rdbAktiv(bool bgep)
        {
            foreach (var r in rdbk)
            {
                r.Enabled = bgep;
            }
        }
        private void rdbMindUres()
        {
            foreach (var r in rdbk)
            {
                r.Checked = false;
            }
        }

        private void kiirastFrissit()
        {
            lblGepTipp.Text = gep.tippSzoveg();
            string korKiiras = ". kör nyertese:";
            lblKorSzamlalo.Text = JatekVezeto.lejatszottKorok + 1 + korKiiras;
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
    
        private void stratVeletlen_Click(object sender, EventArgs e)
        {
            pipalHaNemVolt(sender);
            strVeletlen = true;
            strMinden = false;
            strElozotUti = false;
        }private void stratMinden_Click(object sender, EventArgs e)
        {
            pipalHaNemVolt(sender);
            strVeletlen = false;
            strMinden = true;
            strElozotUti = false;
        }
        private void stratElozotUti_Click(object sender, EventArgs e)
        {
            pipalHaNemVolt(sender);
            strVeletlen = false;
            strMinden = false;
            strElozotUti = true;
        }
        private void btnJatekIndul_Click(object sender, EventArgs e)
        {
            jatekIndul();
        }
        private void rdb_Click(object sender, EventArgs e)
        {
            jatekos.Tipp = (Tipp)((RadioButton)sender).Tag;
            if (JatekVezeto.lejatszottKorok < JatekVezeto.tervezettKorok) egyKor();
            else vege();

        }
        private void btnMentes_Click(object sender, EventArgs e)
        {
            mentes();
        }
    }
}
