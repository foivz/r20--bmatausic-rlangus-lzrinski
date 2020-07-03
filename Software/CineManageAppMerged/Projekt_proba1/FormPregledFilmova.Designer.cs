namespace Projekt_proba1
{
    partial class FormPregledFilmova
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
            this.gboxUrediFilmove = new System.Windows.Forms.GroupBox();
            this.btnDodajNoviFilm = new System.Windows.Forms.Button();
            this.btnAzurirajFilm = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnPrikazPosovanja = new System.Windows.Forms.Button();
            this.dtPickerDatum = new System.Windows.Forms.DateTimePicker();
            this.lblKorisnickoIme = new System.Windows.Forms.Label();
            this.dgvFilmovi = new System.Windows.Forms.DataGridView();
            this.btnFilterDatum = new System.Windows.Forms.Button();
            this.btnPocetniPrikaz = new System.Windows.Forms.Button();
            this.btnOdjava = new System.Windows.Forms.Button();
            this.pboxKinoSlika = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.gboxFilter = new System.Windows.Forms.GroupBox();
            this.btnFilterKategorija = new System.Windows.Forms.Button();
            this.btnFilterNaziv = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNazivFilter = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboxKategorije = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOdaberiFilm = new System.Windows.Forms.Button();
            this.gboxUrediFilmove.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilmovi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxKinoSlika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.gboxFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboxUrediFilmove
            // 
            this.gboxUrediFilmove.Controls.Add(this.btnDodajNoviFilm);
            this.gboxUrediFilmove.Controls.Add(this.btnAzurirajFilm);
            this.gboxUrediFilmove.Controls.Add(this.btnObrisi);
            this.gboxUrediFilmove.Controls.Add(this.btnPrikazPosovanja);
            this.gboxUrediFilmove.Location = new System.Drawing.Point(10, 392);
            this.gboxUrediFilmove.Name = "gboxUrediFilmove";
            this.gboxUrediFilmove.Size = new System.Drawing.Size(175, 155);
            this.gboxUrediFilmove.TabIndex = 23;
            this.gboxUrediFilmove.TabStop = false;
            this.gboxUrediFilmove.Text = "Admin funkcije";
            this.gboxUrediFilmove.Visible = false;
            // 
            // btnDodajNoviFilm
            // 
            this.btnDodajNoviFilm.Location = new System.Drawing.Point(10, 26);
            this.btnDodajNoviFilm.Name = "btnDodajNoviFilm";
            this.btnDodajNoviFilm.Size = new System.Drawing.Size(75, 20);
            this.btnDodajNoviFilm.TabIndex = 5;
            this.btnDodajNoviFilm.Text = "Dodaj";
            this.btnDodajNoviFilm.UseVisualStyleBackColor = true;
            // 
            // btnAzurirajFilm
            // 
            this.btnAzurirajFilm.Location = new System.Drawing.Point(10, 93);
            this.btnAzurirajFilm.Name = "btnAzurirajFilm";
            this.btnAzurirajFilm.Size = new System.Drawing.Size(75, 20);
            this.btnAzurirajFilm.TabIndex = 6;
            this.btnAzurirajFilm.Text = "Ažuriraj";
            this.btnAzurirajFilm.UseVisualStyleBackColor = true;
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(10, 61);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(75, 20);
            this.btnObrisi.TabIndex = 8;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = true;
            // 
            // btnPrikazPosovanja
            // 
            this.btnPrikazPosovanja.Location = new System.Drawing.Point(10, 126);
            this.btnPrikazPosovanja.Name = "btnPrikazPosovanja";
            this.btnPrikazPosovanja.Size = new System.Drawing.Size(144, 23);
            this.btnPrikazPosovanja.TabIndex = 19;
            this.btnPrikazPosovanja.Text = "Prikaz poslovanja";
            this.btnPrikazPosovanja.UseVisualStyleBackColor = true;
            this.btnPrikazPosovanja.Visible = false;
            // 
            // dtPickerDatum
            // 
            this.dtPickerDatum.CustomFormat = "\"yyyy-MM-dd hh:mm:ss tt\"";
            this.dtPickerDatum.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPickerDatum.Location = new System.Drawing.Point(116, 101);
            this.dtPickerDatum.Name = "dtPickerDatum";
            this.dtPickerDatum.Size = new System.Drawing.Size(152, 20);
            this.dtPickerDatum.TabIndex = 22;
            this.dtPickerDatum.Value = new System.DateTime(2020, 7, 1, 0, 0, 0, 0);
            // 
            // lblKorisnickoIme
            // 
            this.lblKorisnickoIme.AutoSize = true;
            this.lblKorisnickoIme.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblKorisnickoIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKorisnickoIme.ForeColor = System.Drawing.Color.FloralWhite;
            this.lblKorisnickoIme.Location = new System.Drawing.Point(488, 15);
            this.lblKorisnickoIme.Name = "lblKorisnickoIme";
            this.lblKorisnickoIme.Size = new System.Drawing.Size(69, 16);
            this.lblKorisnickoIme.TabIndex = 21;
            this.lblKorisnickoIme.Text = "Korisnik id";
            // 
            // dgvFilmovi
            // 
            this.dgvFilmovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFilmovi.Location = new System.Drawing.Point(20, 167);
            this.dgvFilmovi.Name = "dgvFilmovi";
            this.dgvFilmovi.RowHeadersWidth = 51;
            this.dgvFilmovi.Size = new System.Drawing.Size(613, 205);
            this.dgvFilmovi.TabIndex = 20;
            // 
            // btnFilterDatum
            // 
            this.btnFilterDatum.Location = new System.Drawing.Point(287, 100);
            this.btnFilterDatum.Name = "btnFilterDatum";
            this.btnFilterDatum.Size = new System.Drawing.Size(117, 23);
            this.btnFilterDatum.TabIndex = 18;
            this.btnFilterDatum.Text = "Filtriraj po datumu";
            this.btnFilterDatum.UseVisualStyleBackColor = true;
            this.btnFilterDatum.Click += new System.EventHandler(this.btnFilterDatum_Click);
            // 
            // btnPocetniPrikaz
            // 
            this.btnPocetniPrikaz.Location = new System.Drawing.Point(151, 133);
            this.btnPocetniPrikaz.Name = "btnPocetniPrikaz";
            this.btnPocetniPrikaz.Size = new System.Drawing.Size(108, 23);
            this.btnPocetniPrikaz.TabIndex = 17;
            this.btnPocetniPrikaz.Text = "Očisti filtere";
            this.btnPocetniPrikaz.UseVisualStyleBackColor = true;
            this.btnPocetniPrikaz.Click += new System.EventHandler(this.btnPocetniPrikaz_Click);
            // 
            // btnOdjava
            // 
            this.btnOdjava.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOdjava.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdjava.Location = new System.Drawing.Point(565, 8);
            this.btnOdjava.Name = "btnOdjava";
            this.btnOdjava.Size = new System.Drawing.Size(74, 23);
            this.btnOdjava.TabIndex = 16;
            this.btnOdjava.Text = "Odjava";
            this.btnOdjava.UseVisualStyleBackColor = false;
            // 
            // pboxKinoSlika
            // 
            this.pboxKinoSlika.Location = new System.Drawing.Point(20, 54);
            this.pboxKinoSlika.Name = "pboxKinoSlika";
            this.pboxKinoSlika.Size = new System.Drawing.Size(89, 88);
            this.pboxKinoSlika.TabIndex = 15;
            this.pboxKinoSlika.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(124, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "PREGLED FILMOVA";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pictureBox2.Location = new System.Drawing.Point(-4, -6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(653, 45);
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // gboxFilter
            // 
            this.gboxFilter.Controls.Add(this.btnFilterKategorija);
            this.gboxFilter.Controls.Add(this.btnFilterNaziv);
            this.gboxFilter.Controls.Add(this.label4);
            this.gboxFilter.Controls.Add(this.txtNazivFilter);
            this.gboxFilter.Controls.Add(this.dtPickerDatum);
            this.gboxFilter.Controls.Add(this.label3);
            this.gboxFilter.Controls.Add(this.cboxKategorije);
            this.gboxFilter.Controls.Add(this.label2);
            this.gboxFilter.Controls.Add(this.btnFilterDatum);
            this.gboxFilter.Controls.Add(this.btnPocetniPrikaz);
            this.gboxFilter.Location = new System.Drawing.Point(203, 385);
            this.gboxFilter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gboxFilter.Name = "gboxFilter";
            this.gboxFilter.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gboxFilter.Size = new System.Drawing.Size(429, 162);
            this.gboxFilter.TabIndex = 25;
            this.gboxFilter.TabStop = false;
            this.gboxFilter.Text = "Filtriranje";
            // 
            // btnFilterKategorija
            // 
            this.btnFilterKategorija.Location = new System.Drawing.Point(287, 28);
            this.btnFilterKategorija.Name = "btnFilterKategorija";
            this.btnFilterKategorija.Size = new System.Drawing.Size(117, 23);
            this.btnFilterKategorija.TabIndex = 25;
            this.btnFilterKategorija.Text = "Filtriraj po kategoriji";
            this.btnFilterKategorija.UseVisualStyleBackColor = true;
            this.btnFilterKategorija.Click += new System.EventHandler(this.btnFilterKategorija_Click);
            // 
            // btnFilterNaziv
            // 
            this.btnFilterNaziv.Location = new System.Drawing.Point(287, 63);
            this.btnFilterNaziv.Name = "btnFilterNaziv";
            this.btnFilterNaziv.Size = new System.Drawing.Size(117, 23);
            this.btnFilterNaziv.TabIndex = 24;
            this.btnFilterNaziv.Text = "Filtriraj po nazivu";
            this.btnFilterNaziv.UseVisualStyleBackColor = true;
            this.btnFilterNaziv.Click += new System.EventHandler(this.btnFilterNaziv_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 105);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Datum prikazivanja";
            // 
            // txtNazivFilter
            // 
            this.txtNazivFilter.Location = new System.Drawing.Point(116, 66);
            this.txtNazivFilter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNazivFilter.Name = "txtNazivFilter";
            this.txtNazivFilter.Size = new System.Drawing.Size(164, 20);
            this.txtNazivFilter.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-1, 68);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Naziv filma/redatelja";
            // 
            // cboxKategorije
            // 
            this.cboxKategorije.FormattingEnabled = true;
            this.cboxKategorije.Location = new System.Drawing.Point(116, 31);
            this.cboxKategorije.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboxKategorije.Name = "cboxKategorije";
            this.cboxKategorije.Size = new System.Drawing.Size(106, 21);
            this.cboxKategorije.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Kategorija";
            // 
            // btnOdaberiFilm
            // 
            this.btnOdaberiFilm.Location = new System.Drawing.Point(539, 92);
            this.btnOdaberiFilm.Name = "btnOdaberiFilm";
            this.btnOdaberiFilm.Size = new System.Drawing.Size(93, 50);
            this.btnOdaberiFilm.TabIndex = 26;
            this.btnOdaberiFilm.Text = "Odaberi film";
            this.btnOdaberiFilm.UseVisualStyleBackColor = true;
            this.btnOdaberiFilm.Click += new System.EventHandler(this.btnOdaberiFilm_Click);
            // 
            // FormPregledFilmova
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 557);
            this.Controls.Add(this.btnOdaberiFilm);
            this.Controls.Add(this.gboxUrediFilmove);
            this.Controls.Add(this.lblKorisnickoIme);
            this.Controls.Add(this.dgvFilmovi);
            this.Controls.Add(this.btnOdjava);
            this.Controls.Add(this.pboxKinoSlika);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.gboxFilter);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormPregledFilmova";
            this.Text = "FormPregledFilmova";
            this.Load += new System.EventHandler(this.FormPregledFilmova_Load);
            this.gboxUrediFilmove.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilmovi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxKinoSlika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.gboxFilter.ResumeLayout(false);
            this.gboxFilter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxUrediFilmove;
        private System.Windows.Forms.Button btnDodajNoviFilm;
        private System.Windows.Forms.Button btnAzurirajFilm;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.DateTimePicker dtPickerDatum;
        private System.Windows.Forms.Label lblKorisnickoIme;
        private System.Windows.Forms.DataGridView dgvFilmovi;
        private System.Windows.Forms.Button btnPrikazPosovanja;
        private System.Windows.Forms.Button btnFilterDatum;
        private System.Windows.Forms.Button btnPocetniPrikaz;
        private System.Windows.Forms.Button btnOdjava;
        private System.Windows.Forms.PictureBox pboxKinoSlika;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox gboxFilter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNazivFilter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboxKategorije;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFilterKategorija;
        private System.Windows.Forms.Button btnFilterNaziv;
        private System.Windows.Forms.Button btnOdaberiFilm;
    }
}