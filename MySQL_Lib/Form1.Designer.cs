namespace MySQL_Lib
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
            this.listFozde = new System.Windows.Forms.ListBox();
            this.fozet = new System.Windows.Forms.GroupBox();
            this.hozzaad = new System.Windows.Forms.Button();
            this.tulajdonos = new System.Windows.Forms.TextBox();
            this.nev = new System.Windows.Forms.TextBox();
            this.alapitasdatum = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.asd = new System.Windows.Forms.Label();
            this.torles = new System.Windows.Forms.Button();
            this.listCefre = new System.Windows.Forms.ListBox();
            this.cefretorles = new System.Windows.Forms.Button();
            this.cefreGroup = new System.Windows.Forms.GroupBox();
            this.idszam = new System.Windows.Forms.TextBox();
            this.egysegartext = new System.Windows.Forms.TextBox();
            this.fozde_idtext = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.hozzaadCefre = new System.Windows.Forms.Button();
            this.alkoholtext = new System.Windows.Forms.TextBox();
            this.gyumolcstext = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxFozde = new System.Windows.Forms.TextBox();
            this.textBoxAlkohol = new System.Windows.Forms.TextBox();
            this.textBoxEgysegar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.modositCefre = new System.Windows.Forms.Button();
            this.textBoxGyumolcs = new System.Windows.Forms.TextBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textTulaj = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.modositFozde = new System.Windows.Forms.Button();
            this.textNev = new System.Windows.Forms.TextBox();
            this.textId = new System.Windows.Forms.TextBox();
            this.dateAlapit = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.fozet.SuspendLayout();
            this.cefreGroup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listFozde
            // 
            this.listFozde.FormattingEnabled = true;
            this.listFozde.Location = new System.Drawing.Point(13, 13);
            this.listFozde.Name = "listFozde";
            this.listFozde.Size = new System.Drawing.Size(121, 199);
            this.listFozde.TabIndex = 0;
            this.listFozde.SelectedIndexChanged += new System.EventHandler(this.listFozde_SelectedIndexChanged);
            // 
            // fozet
            // 
            this.fozet.Controls.Add(this.hozzaad);
            this.fozet.Controls.Add(this.tulajdonos);
            this.fozet.Controls.Add(this.nev);
            this.fozet.Controls.Add(this.alapitasdatum);
            this.fozet.Controls.Add(this.label3);
            this.fozet.Controls.Add(this.label2);
            this.fozet.Controls.Add(this.asd);
            this.fozet.Location = new System.Drawing.Point(140, 13);
            this.fozet.Name = "fozet";
            this.fozet.Size = new System.Drawing.Size(368, 199);
            this.fozet.TabIndex = 1;
            this.fozet.TabStop = false;
            this.fozet.Text = "Főzet felvétele";
            // 
            // hozzaad
            // 
            this.hozzaad.Location = new System.Drawing.Point(272, 105);
            this.hozzaad.Name = "hozzaad";
            this.hozzaad.Size = new System.Drawing.Size(75, 23);
            this.hozzaad.TabIndex = 6;
            this.hozzaad.Text = "Hozzáad";
            this.hozzaad.UseVisualStyleBackColor = true;
            this.hozzaad.Click += new System.EventHandler(this.hozzaad_Click);
            // 
            // tulajdonos
            // 
            this.tulajdonos.Location = new System.Drawing.Point(147, 47);
            this.tulajdonos.Name = "tulajdonos";
            this.tulajdonos.Size = new System.Drawing.Size(100, 20);
            this.tulajdonos.TabIndex = 5;
            // 
            // nev
            // 
            this.nev.Location = new System.Drawing.Point(147, 13);
            this.nev.Name = "nev";
            this.nev.Size = new System.Drawing.Size(100, 20);
            this.nev.TabIndex = 4;
            // 
            // alapitasdatum
            // 
            this.alapitasdatum.Location = new System.Drawing.Point(147, 70);
            this.alapitasdatum.Name = "alapitasdatum";
            this.alapitasdatum.Size = new System.Drawing.Size(200, 20);
            this.alapitasdatum.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Alapítás dátuma:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tulajdonos:";
            // 
            // asd
            // 
            this.asd.AutoSize = true;
            this.asd.Location = new System.Drawing.Point(6, 16);
            this.asd.Name = "asd";
            this.asd.Size = new System.Drawing.Size(30, 13);
            this.asd.TabIndex = 0;
            this.asd.Text = "Név:";
            this.asd.Click += new System.EventHandler(this.Nev_Click);
            // 
            // torles
            // 
            this.torles.Location = new System.Drawing.Point(12, 216);
            this.torles.Name = "torles";
            this.torles.Size = new System.Drawing.Size(122, 23);
            this.torles.TabIndex = 2;
            this.torles.Text = "Kijelölt törlése";
            this.torles.UseVisualStyleBackColor = true;
            this.torles.Click += new System.EventHandler(this.torles_Click);
            // 
            // listCefre
            // 
            this.listCefre.FormattingEnabled = true;
            this.listCefre.Location = new System.Drawing.Point(12, 245);
            this.listCefre.Name = "listCefre";
            this.listCefre.Size = new System.Drawing.Size(122, 173);
            this.listCefre.TabIndex = 3;
            this.listCefre.SelectedIndexChanged += new System.EventHandler(this.listCefre_SelectedIndexChanged);
            // 
            // cefretorles
            // 
            this.cefretorles.Location = new System.Drawing.Point(13, 424);
            this.cefretorles.Name = "cefretorles";
            this.cefretorles.Size = new System.Drawing.Size(121, 23);
            this.cefretorles.TabIndex = 4;
            this.cefretorles.Text = "Kijelölt törlése";
            this.cefretorles.UseVisualStyleBackColor = true;
            this.cefretorles.Click += new System.EventHandler(this.cefretorles_Click);
            // 
            // cefreGroup
            // 
            this.cefreGroup.Controls.Add(this.idszam);
            this.cefreGroup.Controls.Add(this.egysegartext);
            this.cefreGroup.Controls.Add(this.fozde_idtext);
            this.cefreGroup.Controls.Add(this.label6);
            this.cefreGroup.Controls.Add(this.hozzaadCefre);
            this.cefreGroup.Controls.Add(this.alkoholtext);
            this.cefreGroup.Controls.Add(this.gyumolcstext);
            this.cefreGroup.Controls.Add(this.label1);
            this.cefreGroup.Controls.Add(this.label4);
            this.cefreGroup.Controls.Add(this.label5);
            this.cefreGroup.Location = new System.Drawing.Point(140, 245);
            this.cefreGroup.Name = "cefreGroup";
            this.cefreGroup.Size = new System.Drawing.Size(368, 193);
            this.cefreGroup.TabIndex = 5;
            this.cefreGroup.TabStop = false;
            this.cefreGroup.Text = "Cefre felvétele";
            // 
            // idszam
            // 
            this.idszam.Location = new System.Drawing.Point(222, 19);
            this.idszam.Name = "idszam";
            this.idszam.Size = new System.Drawing.Size(100, 20);
            this.idszam.TabIndex = 11;
            // 
            // egysegartext
            // 
            this.egysegartext.Location = new System.Drawing.Point(68, 79);
            this.egysegartext.Name = "egysegartext";
            this.egysegartext.Size = new System.Drawing.Size(100, 20);
            this.egysegartext.TabIndex = 9;
            // 
            // fozde_idtext
            // 
            this.fozde_idtext.Location = new System.Drawing.Point(68, 108);
            this.fozde_idtext.Name = "fozde_idtext";
            this.fozde_idtext.Size = new System.Drawing.Size(100, 20);
            this.fozde_idtext.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Főzde:";
            // 
            // hozzaadCefre
            // 
            this.hozzaadCefre.Location = new System.Drawing.Point(272, 141);
            this.hozzaadCefre.Name = "hozzaadCefre";
            this.hozzaadCefre.Size = new System.Drawing.Size(75, 23);
            this.hozzaadCefre.TabIndex = 6;
            this.hozzaadCefre.Text = "Hozzáad";
            this.hozzaadCefre.UseVisualStyleBackColor = true;
            this.hozzaadCefre.Click += new System.EventHandler(this.hozzaadCefre_Click);
            // 
            // alkoholtext
            // 
            this.alkoholtext.Location = new System.Drawing.Point(68, 47);
            this.alkoholtext.Name = "alkoholtext";
            this.alkoholtext.Size = new System.Drawing.Size(100, 20);
            this.alkoholtext.TabIndex = 5;
            // 
            // gyumolcstext
            // 
            this.gyumolcstext.Location = new System.Drawing.Point(68, 16);
            this.gyumolcstext.Name = "gyumolcstext";
            this.gyumolcstext.Size = new System.Drawing.Size(100, 20);
            this.gyumolcstext.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Egységár:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Alkohol:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Gyümölcs:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.textBoxFozde);
            this.groupBox1.Controls.Add(this.textBoxAlkohol);
            this.groupBox1.Controls.Add(this.textBoxEgysegar);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.modositCefre);
            this.groupBox1.Controls.Add(this.textBoxGyumolcs);
            this.groupBox1.Controls.Add(this.textBoxId);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(514, 245);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 193);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cefre módosítása";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(4, 141);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(39, 13);
            this.label15.TabIndex = 12;
            this.label15.Text = "Főzde:";
            // 
            // textBoxFozde
            // 
            this.textBoxFozde.Location = new System.Drawing.Point(68, 134);
            this.textBoxFozde.Name = "textBoxFozde";
            this.textBoxFozde.Size = new System.Drawing.Size(100, 20);
            this.textBoxFozde.TabIndex = 11;
            // 
            // textBoxAlkohol
            // 
            this.textBoxAlkohol.Location = new System.Drawing.Point(68, 79);
            this.textBoxAlkohol.Name = "textBoxAlkohol";
            this.textBoxAlkohol.Size = new System.Drawing.Size(100, 20);
            this.textBoxAlkohol.TabIndex = 9;
            // 
            // textBoxEgysegar
            // 
            this.textBoxEgysegar.Location = new System.Drawing.Point(68, 108);
            this.textBoxEgysegar.Name = "textBoxEgysegar";
            this.textBoxEgysegar.Size = new System.Drawing.Size(100, 20);
            this.textBoxEgysegar.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Egységár:";
            // 
            // modositCefre
            // 
            this.modositCefre.Location = new System.Drawing.Point(272, 141);
            this.modositCefre.Name = "modositCefre";
            this.modositCefre.Size = new System.Drawing.Size(75, 23);
            this.modositCefre.TabIndex = 6;
            this.modositCefre.Text = "Módosít";
            this.modositCefre.UseVisualStyleBackColor = true;
            this.modositCefre.Click += new System.EventHandler(this.modositCefre_Click);
            // 
            // textBoxGyumolcs
            // 
            this.textBoxGyumolcs.Location = new System.Drawing.Point(68, 47);
            this.textBoxGyumolcs.Name = "textBoxGyumolcs";
            this.textBoxGyumolcs.Size = new System.Drawing.Size(100, 20);
            this.textBoxGyumolcs.TabIndex = 5;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(68, 16);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(100, 20);
            this.textBoxId.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Alkohol:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Gyümölcs:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "ID:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textTulaj);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.modositFozde);
            this.groupBox2.Controls.Add(this.textNev);
            this.groupBox2.Controls.Add(this.textId);
            this.groupBox2.Controls.Add(this.dateAlapit);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Location = new System.Drawing.Point(523, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(368, 199);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Főzet módosítása";
            // 
            // textTulaj
            // 
            this.textTulaj.Location = new System.Drawing.Point(147, 77);
            this.textTulaj.Name = "textTulaj";
            this.textTulaj.Size = new System.Drawing.Size(100, 20);
            this.textTulaj.TabIndex = 8;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 47);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(27, 13);
            this.label14.TabIndex = 7;
            this.label14.Text = "Név";
            // 
            // modositFozde
            // 
            this.modositFozde.Location = new System.Drawing.Point(284, 144);
            this.modositFozde.Name = "modositFozde";
            this.modositFozde.Size = new System.Drawing.Size(75, 23);
            this.modositFozde.TabIndex = 6;
            this.modositFozde.Text = "Módosít";
            this.modositFozde.UseVisualStyleBackColor = true;
            this.modositFozde.Click += new System.EventHandler(this.modositFozet_Click);
            // 
            // textNev
            // 
            this.textNev.Location = new System.Drawing.Point(147, 47);
            this.textNev.Name = "textNev";
            this.textNev.Size = new System.Drawing.Size(100, 20);
            this.textNev.TabIndex = 5;
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(147, 13);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(100, 20);
            this.textId.TabIndex = 4;
            // 
            // dateAlapit
            // 
            this.dateAlapit.Location = new System.Drawing.Point(147, 115);
            this.dateAlapit.Name = "dateAlapit";
            this.dateAlapit.Size = new System.Drawing.Size(200, 20);
            this.dateAlapit.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 115);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Alapítás dátuma:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 77);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Tulajdonos:";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(21, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "ID:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 473);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cefreGroup);
            this.Controls.Add(this.cefretorles);
            this.Controls.Add(this.listCefre);
            this.Controls.Add(this.torles);
            this.Controls.Add(this.fozet);
            this.Controls.Add(this.listFozde);
            this.Name = "Form1";
            this.Text = "Form1";
            this.fozet.ResumeLayout(false);
            this.fozet.PerformLayout();
            this.cefreGroup.ResumeLayout(false);
            this.cefreGroup.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listFozde;
        private System.Windows.Forms.GroupBox fozet;
        private System.Windows.Forms.Button hozzaad;
        private System.Windows.Forms.TextBox tulajdonos;
        private System.Windows.Forms.TextBox nev;
        private System.Windows.Forms.DateTimePicker alapitasdatum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label asd;
        private System.Windows.Forms.Button torles;
        private System.Windows.Forms.ListBox listCefre;
        private System.Windows.Forms.Button cefretorles;
        private System.Windows.Forms.GroupBox cefreGroup;
        private System.Windows.Forms.TextBox egysegartext;
        private System.Windows.Forms.TextBox fozde_idtext;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button hozzaadCefre;
        private System.Windows.Forms.TextBox alkoholtext;
        private System.Windows.Forms.TextBox gyumolcstext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox idszam;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxFozde;
        private System.Windows.Forms.TextBox textBoxAlkohol;
        private System.Windows.Forms.TextBox textBoxEgysegar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button modositCefre;
        private System.Windows.Forms.TextBox textBoxGyumolcs;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button modositFozde;
        private System.Windows.Forms.TextBox textNev;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.DateTimePicker dateAlapit;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textTulaj;
    }
}

