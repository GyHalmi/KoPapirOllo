
namespace KoPapirOllo_VizsgaFeladat
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.stratégiákToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVeletlen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMinden = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuElozotUti = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuKilep = new System.Windows.Forms.ToolStripMenuItem();
            this.contJatekter = new System.Windows.Forms.GroupBox();
            this.lblNyertes = new System.Windows.Forms.Label();
            this.lblKorSzamlalo = new System.Windows.Forms.Label();
            this.lblGepTipp = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rdbOllo = new System.Windows.Forms.RadioButton();
            this.rdbPapir = new System.Windows.Forms.RadioButton();
            this.rdbKo = new System.Windows.Forms.RadioButton();
            this.btnJatekIndul = new System.Windows.Forms.Button();
            this.chbVegenMent = new System.Windows.Forms.CheckBox();
            this.btnMentes = new System.Windows.Forms.Button();
            this.numKorok = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.contJatekter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numKorok)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stratégiákToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(253, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // stratégiákToolStripMenuItem
            // 
            this.stratégiákToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuVeletlen,
            this.mnuMinden,
            this.mnuElozotUti,
            this.toolStripSeparator1,
            this.mnuKilep});
            this.stratégiákToolStripMenuItem.Name = "stratégiákToolStripMenuItem";
            this.stratégiákToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.stratégiákToolStripMenuItem.Text = "Stratégiák";
            // 
            // mnuVeletlen
            // 
            this.mnuVeletlen.Name = "mnuVeletlen";
            this.mnuVeletlen.Size = new System.Drawing.Size(180, 22);
            this.mnuVeletlen.Text = "Véletlen";
            this.mnuVeletlen.Click += new System.EventHandler(this.stratVeletlen_Click);
            // 
            // mnuMinden
            // 
            this.mnuMinden.Name = "mnuMinden";
            this.mnuMinden.Size = new System.Drawing.Size(180, 22);
            this.mnuMinden.Text = "Minden";
            this.mnuMinden.Click += new System.EventHandler(this.stratMinden_Click);
            // 
            // mnuElozotUti
            // 
            this.mnuElozotUti.Name = "mnuElozotUti";
            this.mnuElozotUti.Size = new System.Drawing.Size(180, 22);
            this.mnuElozotUti.Text = "Előzőt üti";
            this.mnuElozotUti.Click += new System.EventHandler(this.stratElozotUti_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // mnuKilep
            // 
            this.mnuKilep.Name = "mnuKilep";
            this.mnuKilep.Size = new System.Drawing.Size(180, 22);
            this.mnuKilep.Text = "Kilépés";
            // 
            // contJatekter
            // 
            this.contJatekter.Controls.Add(this.groupBox1);
            this.contJatekter.Controls.Add(this.lblNyertes);
            this.contJatekter.Controls.Add(this.lblKorSzamlalo);
            this.contJatekter.Controls.Add(this.lblGepTipp);
            this.contJatekter.Controls.Add(this.label2);
            this.contJatekter.Controls.Add(this.rdbOllo);
            this.contJatekter.Controls.Add(this.rdbPapir);
            this.contJatekter.Controls.Add(this.rdbKo);
            this.contJatekter.Controls.Add(this.btnJatekIndul);
            this.contJatekter.Controls.Add(this.numKorok);
            this.contJatekter.Controls.Add(this.label1);
            this.contJatekter.Location = new System.Drawing.Point(12, 27);
            this.contJatekter.Name = "contJatekter";
            this.contJatekter.Size = new System.Drawing.Size(229, 269);
            this.contJatekter.TabIndex = 1;
            this.contJatekter.TabStop = false;
            this.contJatekter.Text = "Játéktér";
            // 
            // lblNyertes
            // 
            this.lblNyertes.AutoSize = true;
            this.lblNyertes.Location = new System.Drawing.Point(136, 232);
            this.lblNyertes.Name = "lblNyertes";
            this.lblNyertes.Size = new System.Drawing.Size(44, 13);
            this.lblNyertes.TabIndex = 13;
            this.lblNyertes.Text = "Játékos";
            // 
            // lblKorSzamlalo
            // 
            this.lblKorSzamlalo.AutoSize = true;
            this.lblKorSzamlalo.Location = new System.Drawing.Point(27, 232);
            this.lblKorSzamlalo.Name = "lblKorSzamlalo";
            this.lblKorSzamlalo.Size = new System.Drawing.Size(80, 13);
            this.lblKorSzamlalo.TabIndex = 12;
            this.lblKorSzamlalo.Text = "1. kör nyertese:";
            // 
            // lblGepTipp
            // 
            this.lblGepTipp.AutoSize = true;
            this.lblGepTipp.Location = new System.Drawing.Point(148, 203);
            this.lblGepTipp.Name = "lblGepTipp";
            this.lblGepTipp.Size = new System.Drawing.Size(32, 13);
            this.lblGepTipp.TabIndex = 11;
            this.lblGepTipp.Text = "papír";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "A gép választása:";
            // 
            // rdbOllo
            // 
            this.rdbOllo.AutoSize = true;
            this.rdbOllo.Location = new System.Drawing.Point(151, 167);
            this.rdbOllo.Name = "rdbOllo";
            this.rdbOllo.Size = new System.Drawing.Size(43, 17);
            this.rdbOllo.TabIndex = 9;
            this.rdbOllo.TabStop = true;
            this.rdbOllo.Text = "Olló";
            this.rdbOllo.UseVisualStyleBackColor = true;
            // 
            // rdbPapir
            // 
            this.rdbPapir.AutoSize = true;
            this.rdbPapir.Location = new System.Drawing.Point(83, 167);
            this.rdbPapir.Name = "rdbPapir";
            this.rdbPapir.Size = new System.Drawing.Size(51, 17);
            this.rdbPapir.TabIndex = 8;
            this.rdbPapir.TabStop = true;
            this.rdbPapir.Text = "Papír";
            this.rdbPapir.UseVisualStyleBackColor = true;
            // 
            // rdbKo
            // 
            this.rdbKo.AutoSize = true;
            this.rdbKo.Location = new System.Drawing.Point(30, 167);
            this.rdbKo.Name = "rdbKo";
            this.rdbKo.Size = new System.Drawing.Size(38, 17);
            this.rdbKo.TabIndex = 7;
            this.rdbKo.TabStop = true;
            this.rdbKo.Text = "Kő";
            this.rdbKo.UseVisualStyleBackColor = true;
            // 
            // btnJatekIndul
            // 
            this.btnJatekIndul.Location = new System.Drawing.Point(28, 126);
            this.btnJatekIndul.Name = "btnJatekIndul";
            this.btnJatekIndul.Size = new System.Drawing.Size(164, 23);
            this.btnJatekIndul.TabIndex = 6;
            this.btnJatekIndul.Text = "Játék indítása";
            this.btnJatekIndul.UseVisualStyleBackColor = true;
            this.btnJatekIndul.Click += new System.EventHandler(this.btnJatekIndul_Click);
            // 
            // chbVegenMent
            // 
            this.chbVegenMent.AutoSize = true;
            this.chbVegenMent.Location = new System.Drawing.Point(111, 27);
            this.chbVegenMent.Name = "chbVegenMent";
            this.chbVegenMent.Size = new System.Drawing.Size(83, 17);
            this.chbVegenMent.TabIndex = 5;
            this.chbVegenMent.Text = "Végén ment";
            this.chbVegenMent.UseVisualStyleBackColor = true;
            // 
            // btnMentes
            // 
            this.btnMentes.Location = new System.Drawing.Point(14, 23);
            this.btnMentes.Name = "btnMentes";
            this.btnMentes.Size = new System.Drawing.Size(75, 23);
            this.btnMentes.TabIndex = 4;
            this.btnMentes.Text = "Mentés";
            this.btnMentes.UseVisualStyleBackColor = true;
            this.btnMentes.Click += new System.EventHandler(this.btnMentes_Click);
            // 
            // numKorok
            // 
            this.numKorok.Location = new System.Drawing.Point(139, 32);
            this.numKorok.Name = "numKorok";
            this.numKorok.Size = new System.Drawing.Size(55, 20);
            this.numKorok.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Körök száma:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMentes);
            this.groupBox1.Controls.Add(this.chbVegenMent);
            this.groupBox1.Location = new System.Drawing.Point(7, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 58);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Statisztika";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 306);
            this.Controls.Add(this.contJatekter);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Kő - Papír - Olló";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contJatekter.ResumeLayout(false);
            this.contJatekter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numKorok)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem stratégiákToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuVeletlen;
        private System.Windows.Forms.ToolStripMenuItem mnuMinden;
        private System.Windows.Forms.ToolStripMenuItem mnuElozotUti;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuKilep;
        private System.Windows.Forms.GroupBox contJatekter;
        private System.Windows.Forms.Label lblNyertes;
        private System.Windows.Forms.Label lblKorSzamlalo;
        private System.Windows.Forms.Label lblGepTipp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdbOllo;
        private System.Windows.Forms.RadioButton rdbPapir;
        private System.Windows.Forms.RadioButton rdbKo;
        private System.Windows.Forms.Button btnJatekIndul;
        private System.Windows.Forms.CheckBox chbVegenMent;
        private System.Windows.Forms.Button btnMentes;
        private System.Windows.Forms.NumericUpDown numKorok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

