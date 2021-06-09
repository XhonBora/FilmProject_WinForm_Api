namespace FilmProject
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
            this.txtEmriFilmit = new System.Windows.Forms.TextBox();
            this.txtRegjisori = new System.Windows.Forms.TextBox();
            this.dtProdhimit = new System.Windows.Forms.DateTimePicker();
            this.txtMinutat = new System.Windows.Forms.TextBox();
            this.rdbPozitiv = new System.Windows.Forms.RadioButton();
            this.rdbNegativ = new System.Windows.Forms.RadioButton();
            this.chbPo = new System.Windows.Forms.CheckBox();
            this.chbJo = new System.Windows.Forms.CheckBox();
            this.comboKategoria = new System.Windows.Forms.ComboBox();
            this.txtBuxheti = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnDil = new System.Windows.Forms.Button();
            this.btnRuaj = new System.Windows.Forms.Button();
            this.btnKerko = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnPastro = new System.Windows.Forms.Button();
            this.btnFshi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEmriFilmit
            // 
            this.txtEmriFilmit.Location = new System.Drawing.Point(267, 49);
            this.txtEmriFilmit.MaxLength = 50;
            this.txtEmriFilmit.Name = "txtEmriFilmit";
            this.txtEmriFilmit.Size = new System.Drawing.Size(427, 20);
            this.txtEmriFilmit.TabIndex = 0;
            // 
            // txtRegjisori
            // 
            this.txtRegjisori.Location = new System.Drawing.Point(267, 84);
            this.txtRegjisori.MaxLength = 50;
            this.txtRegjisori.Name = "txtRegjisori";
            this.txtRegjisori.Size = new System.Drawing.Size(427, 20);
            this.txtRegjisori.TabIndex = 1;
            // 
            // dtProdhimit
            // 
            this.dtProdhimit.CustomFormat = "dd-MM-yyyy";
            this.dtProdhimit.Location = new System.Drawing.Point(267, 119);
            this.dtProdhimit.Name = "dtProdhimit";
            this.dtProdhimit.Size = new System.Drawing.Size(427, 20);
            this.dtProdhimit.TabIndex = 2;
            // 
            // txtMinutat
            // 
            this.txtMinutat.Location = new System.Drawing.Point(267, 155);
            this.txtMinutat.MaxLength = 20;
            this.txtMinutat.Name = "txtMinutat";
            this.txtMinutat.Size = new System.Drawing.Size(427, 20);
            this.txtMinutat.TabIndex = 3;
            this.txtMinutat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMinutat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMinutat_KeyPress);
            // 
            // rdbPozitiv
            // 
            this.rdbPozitiv.AutoSize = true;
            this.rdbPozitiv.Location = new System.Drawing.Point(267, 195);
            this.rdbPozitiv.Name = "rdbPozitiv";
            this.rdbPozitiv.Size = new System.Drawing.Size(56, 17);
            this.rdbPozitiv.TabIndex = 4;
            this.rdbPozitiv.TabStop = true;
            this.rdbPozitiv.Text = "Pozitiv";
            this.rdbPozitiv.UseVisualStyleBackColor = true;
            // 
            // rdbNegativ
            // 
            this.rdbNegativ.AutoSize = true;
            this.rdbNegativ.Location = new System.Drawing.Point(331, 195);
            this.rdbNegativ.Name = "rdbNegativ";
            this.rdbNegativ.Size = new System.Drawing.Size(62, 17);
            this.rdbNegativ.TabIndex = 5;
            this.rdbNegativ.TabStop = true;
            this.rdbNegativ.Text = "Negativ";
            this.rdbNegativ.UseVisualStyleBackColor = true;
            // 
            // chbPo
            // 
            this.chbPo.AutoSize = true;
            this.chbPo.Location = new System.Drawing.Point(267, 234);
            this.chbPo.Name = "chbPo";
            this.chbPo.Size = new System.Drawing.Size(39, 17);
            this.chbPo.TabIndex = 6;
            this.chbPo.Text = "Po";
            this.chbPo.UseVisualStyleBackColor = true;
            // 
            // chbJo
            // 
            this.chbJo.AutoSize = true;
            this.chbJo.Location = new System.Drawing.Point(331, 234);
            this.chbJo.Name = "chbJo";
            this.chbJo.Size = new System.Drawing.Size(37, 17);
            this.chbJo.TabIndex = 7;
            this.chbJo.Text = "Jo";
            this.chbJo.UseVisualStyleBackColor = true;
            // 
            // comboKategoria
            // 
            this.comboKategoria.FormattingEnabled = true;
            this.comboKategoria.Items.AddRange(new object[] {
            "--Zgjidh--",
            "Thriller",
            "Comedy",
            "Sci-Fi",
            "Drama"});
            this.comboKategoria.Location = new System.Drawing.Point(267, 271);
            this.comboKategoria.Name = "comboKategoria";
            this.comboKategoria.Size = new System.Drawing.Size(427, 21);
            this.comboKategoria.TabIndex = 8;
            // 
            // txtBuxheti
            // 
            this.txtBuxheti.Location = new System.Drawing.Point(267, 314);
            this.txtBuxheti.MaxLength = 20;
            this.txtBuxheti.Name = "txtBuxheti";
            this.txtBuxheti.Size = new System.Drawing.Size(427, 20);
            this.txtBuxheti.TabIndex = 9;
            this.txtBuxheti.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBuxheti.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuxheti_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Emri i filmit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Emri i regjisorit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(154, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Data e prodhimit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(154, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Minutat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(154, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Vlerësimi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(154, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Është shqiptar";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(154, 279);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Kategoria";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(154, 314);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Buxheti";
            // 
            // btnDil
            // 
            this.btnDil.BackColor = System.Drawing.Color.White;
            this.btnDil.Location = new System.Drawing.Point(267, 377);
            this.btnDil.Name = "btnDil";
            this.btnDil.Size = new System.Drawing.Size(60, 23);
            this.btnDil.TabIndex = 18;
            this.btnDil.Text = "Dil";
            this.btnDil.UseVisualStyleBackColor = false;
            this.btnDil.Click += new System.EventHandler(this.btnDil_Click);
            // 
            // btnRuaj
            // 
            this.btnRuaj.BackColor = System.Drawing.Color.LimeGreen;
            this.btnRuaj.Location = new System.Drawing.Point(489, 377);
            this.btnRuaj.Name = "btnRuaj";
            this.btnRuaj.Size = new System.Drawing.Size(75, 23);
            this.btnRuaj.TabIndex = 19;
            this.btnRuaj.Text = "Ruaj";
            this.btnRuaj.UseVisualStyleBackColor = false;
            this.btnRuaj.Click += new System.EventHandler(this.btnRuaj_Click);
            // 
            // btnKerko
            // 
            this.btnKerko.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnKerko.Location = new System.Drawing.Point(570, 377);
            this.btnKerko.Name = "btnKerko";
            this.btnKerko.Size = new System.Drawing.Size(60, 23);
            this.btnKerko.TabIndex = 20;
            this.btnKerko.Text = "Kërko";
            this.btnKerko.UseVisualStyleBackColor = false;
            this.btnKerko.Click += new System.EventHandler(this.btnKerko_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(154, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Id";
            this.label9.Visible = false;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(267, 6);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(426, 20);
            this.txtId.TabIndex = 23;
            this.txtId.Visible = false;
            // 
            // btnPastro
            // 
            this.btnPastro.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPastro.Location = new System.Drawing.Point(331, 377);
            this.btnPastro.Name = "btnPastro";
            this.btnPastro.Size = new System.Drawing.Size(60, 23);
            this.btnPastro.TabIndex = 24;
            this.btnPastro.Text = "Pastro";
            this.btnPastro.UseVisualStyleBackColor = false;
            this.btnPastro.Click += new System.EventHandler(this.btnPastro_Click);
            // 
            // btnFshi
            // 
            this.btnFshi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnFshi.Location = new System.Drawing.Point(636, 377);
            this.btnFshi.Name = "btnFshi";
            this.btnFshi.Size = new System.Drawing.Size(58, 23);
            this.btnFshi.TabIndex = 25;
            this.btnFshi.Text = "Fshi";
            this.btnFshi.UseVisualStyleBackColor = false;
            this.btnFshi.Click += new System.EventHandler(this.btnFshi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFshi);
            this.Controls.Add(this.btnPastro);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnKerko);
            this.Controls.Add(this.btnRuaj);
            this.Controls.Add(this.btnDil);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBuxheti);
            this.Controls.Add(this.comboKategoria);
            this.Controls.Add(this.chbJo);
            this.Controls.Add(this.chbPo);
            this.Controls.Add(this.rdbNegativ);
            this.Controls.Add(this.rdbPozitiv);
            this.Controls.Add(this.txtMinutat);
            this.Controls.Add(this.dtProdhimit);
            this.Controls.Add(this.txtRegjisori);
            this.Controls.Add(this.txtEmriFilmit);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Regjistrimi i një filmi në databazë";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtEmriFilmit;
        public System.Windows.Forms.TextBox txtRegjisori;
        public System.Windows.Forms.DateTimePicker dtProdhimit;
        public System.Windows.Forms.TextBox txtMinutat;
        public System.Windows.Forms.RadioButton rdbPozitiv;
        public System.Windows.Forms.RadioButton rdbNegativ;
        public System.Windows.Forms.CheckBox chbPo;
        public System.Windows.Forms.CheckBox chbJo;
        public System.Windows.Forms.ComboBox comboKategoria;
        public System.Windows.Forms.TextBox txtBuxheti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnDil;
        private System.Windows.Forms.Button btnRuaj;
        private System.Windows.Forms.Button btnKerko;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnPastro;
        private System.Windows.Forms.Button btnFshi;
    }
}

