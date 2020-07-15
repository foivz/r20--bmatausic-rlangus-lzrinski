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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPregledFilmova));
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
            this.btnPrijava = new System.Windows.Forms.Button();
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
            this.gboxUrediFilmove.Location = new System.Drawing.Point(13, 482);
            this.gboxUrediFilmove.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gboxUrediFilmove.Name = "gboxUrediFilmove";
            this.gboxUrediFilmove.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gboxUrediFilmove.Size = new System.Drawing.Size(233, 191);
            this.gboxUrediFilmove.TabIndex = 23;
            this.gboxUrediFilmove.TabStop = false;
            this.gboxUrediFilmove.Text = "Admin funkcije";
            this.gboxUrediFilmove.Visible = false;
            // 
            // btnDodajNoviFilm
            // 
            this.btnDodajNoviFilm.Location = new System.Drawing.Point(21, 32);
            this.btnDodajNoviFilm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDodajNoviFilm.Name = "btnDodajNoviFilm";
            this.btnDodajNoviFilm.Size = new System.Drawing.Size(192, 25);
            this.btnDodajNoviFilm.TabIndex = 5;
            this.btnDodajNoviFilm.Text = "Dodaj";
            this.btnDodajNoviFilm.UseVisualStyleBackColor = true;
            this.btnDodajNoviFilm.Click += new System.EventHandler(this.btnDodajNoviFilm_Click);
            // 
            // btnAzurirajFilm
            // 
            this.btnAzurirajFilm.Location = new System.Drawing.Point(21, 114);
            this.btnAzurirajFilm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAzurirajFilm.Name = "btnAzurirajFilm";
            this.btnAzurirajFilm.Size = new System.Drawing.Size(192, 25);
            this.btnAzurirajFilm.TabIndex = 6;
            this.btnAzurirajFilm.Text = "Ažuriraj";
            this.btnAzurirajFilm.UseVisualStyleBackColor = true;
            this.btnAzurirajFilm.Click += new System.EventHandler(this.btnAzurirajFilm_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(21, 75);
            this.btnObrisi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(192, 25);
            this.btnObrisi.TabIndex = 8;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnPrikazPosovanja
            // 
            this.btnPrikazPosovanja.Location = new System.Drawing.Point(21, 155);
            this.btnPrikazPosovanja.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPrikazPosovanja.Name = "btnPrikazPosovanja";
            this.btnPrikazPosovanja.Size = new System.Drawing.Size(192, 28);
            this.btnPrikazPosovanja.TabIndex = 19;
            this.btnPrikazPosovanja.Text = "Prikaz poslovanja";
            this.btnPrikazPosovanja.UseVisualStyleBackColor = true;
            this.btnPrikazPosovanja.Visible = false;
            this.btnPrikazPosovanja.Click += new System.EventHandler(this.btnPrikazPosovanja_Click);
            // 
            // dtPickerDatum
            // 
            this.dtPickerDatum.CustomFormat = "\"yyyy-MM-dd hh:mm:ss tt\"";
            this.dtPickerDatum.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPickerDatum.Location = new System.Drawing.Point(172, 124);
            this.dtPickerDatum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtPickerDatum.Name = "dtPickerDatum";
            this.dtPickerDatum.Size = new System.Drawing.Size(201, 22);
            this.dtPickerDatum.TabIndex = 22;
            this.dtPickerDatum.Value = new System.DateTime(2020, 7, 1, 0, 0, 0, 0);
            // 
            // lblKorisnickoIme
            // 
            this.lblKorisnickoIme.AutoSize = true;
            this.lblKorisnickoIme.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblKorisnickoIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKorisnickoIme.ForeColor = System.Drawing.Color.FloralWhite;
            this.lblKorisnickoIme.Location = new System.Drawing.Point(677, 10);
            this.lblKorisnickoIme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKorisnickoIme.Name = "lblKorisnickoIme";
            this.lblKorisnickoIme.Size = new System.Drawing.Size(87, 20);
            this.lblKorisnickoIme.TabIndex = 21;
            this.lblKorisnickoIme.Text = "Korisnik id";
            // 
            // dgvFilmovi
            // 
            this.dgvFilmovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFilmovi.Location = new System.Drawing.Point(27, 206);
            this.dgvFilmovi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvFilmovi.Name = "dgvFilmovi";
            this.dgvFilmovi.RowHeadersWidth = 51;
            this.dgvFilmovi.Size = new System.Drawing.Size(856, 252);
            this.dgvFilmovi.TabIndex = 20;
            // 
            // btnFilterDatum
            // 
            this.btnFilterDatum.Location = new System.Drawing.Point(400, 123);
            this.btnFilterDatum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFilterDatum.Name = "btnFilterDatum";
            this.btnFilterDatum.Size = new System.Drawing.Size(156, 28);
            this.btnFilterDatum.TabIndex = 18;
            this.btnFilterDatum.Text = "Filtriraj po datumu";
            this.btnFilterDatum.UseVisualStyleBackColor = true;
            this.btnFilterDatum.Click += new System.EventHandler(this.btnFilterDatum_Click);
            // 
            // btnPocetniPrikaz
            // 
            this.btnPocetniPrikaz.Location = new System.Drawing.Point(219, 164);
            this.btnPocetniPrikaz.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPocetniPrikaz.Name = "btnPocetniPrikaz";
            this.btnPocetniPrikaz.Size = new System.Drawing.Size(144, 28);
            this.btnPocetniPrikaz.TabIndex = 17;
            this.btnPocetniPrikaz.Text = "Očisti filtere";
            this.btnPocetniPrikaz.UseVisualStyleBackColor = true;
            this.btnPocetniPrikaz.Click += new System.EventHandler(this.btnPocetniPrikaz_Click);
            // 
            // btnOdjava
            // 
            this.btnOdjava.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOdjava.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdjava.Location = new System.Drawing.Point(784, 6);
            this.btnOdjava.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOdjava.Name = "btnOdjava";
            this.btnOdjava.Size = new System.Drawing.Size(99, 28);
            this.btnOdjava.TabIndex = 16;
            this.btnOdjava.Text = "Odjava";
            this.btnOdjava.UseVisualStyleBackColor = false;
            this.btnOdjava.Click += new System.EventHandler(this.btnOdjava_Click);
            // 
            // pboxKinoSlika
            // 
            this.pboxKinoSlika.Image = ((System.Drawing.Image)(resources.GetObject("pboxKinoSlika.Image")));
            this.pboxKinoSlika.Location = new System.Drawing.Point(27, 66);
            this.pboxKinoSlika.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pboxKinoSlika.Name = "pboxKinoSlika";
            this.pboxKinoSlika.Size = new System.Drawing.Size(119, 108);
            this.pboxKinoSlika.TabIndex = 15;
            this.pboxKinoSlika.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 103);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 36);
            this.label1.TabIndex = 14;
            this.label1.Text = "PREGLED FILMOVA";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pictureBox2.Location = new System.Drawing.Point(-1, -5);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(907, 46);
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
            this.gboxFilter.Location = new System.Drawing.Point(271, 474);
            this.gboxFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gboxFilter.Name = "gboxFilter";
            this.gboxFilter.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gboxFilter.Size = new System.Drawing.Size(612, 199);
            this.gboxFilter.TabIndex = 25;
            this.gboxFilter.TabStop = false;
            this.gboxFilter.Text = "Filtriranje";
            // 
            // btnFilterKategorija
            // 
            this.btnFilterKategorija.Location = new System.Drawing.Point(400, 34);
            this.btnFilterKategorija.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFilterKategorija.Name = "btnFilterKategorija";
            this.btnFilterKategorija.Size = new System.Drawing.Size(156, 28);
            this.btnFilterKategorija.TabIndex = 25;
            this.btnFilterKategorija.Text = "Filtriraj po kategoriji";
            this.btnFilterKategorija.UseVisualStyleBackColor = true;
            this.btnFilterKategorija.Click += new System.EventHandler(this.btnFilterKategorija_Click);
            // 
            // btnFilterNaziv
            // 
            this.btnFilterNaziv.Location = new System.Drawing.Point(400, 78);
            this.btnFilterNaziv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFilterNaziv.Name = "btnFilterNaziv";
            this.btnFilterNaziv.Size = new System.Drawing.Size(156, 28);
            this.btnFilterNaziv.TabIndex = 24;
            this.btnFilterNaziv.Text = "Filtriraj po nazivu";
            this.btnFilterNaziv.UseVisualStyleBackColor = true;
            this.btnFilterNaziv.Click += new System.EventHandler(this.btnFilterNaziv_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "Datum prikazivanja";
            // 
            // txtNazivFilter
            // 
            this.txtNazivFilter.Location = new System.Drawing.Point(172, 81);
            this.txtNazivFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNazivFilter.Name = "txtNazivFilter";
            this.txtNazivFilter.Size = new System.Drawing.Size(217, 22);
            this.txtNazivFilter.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Naziv filma/redatelja";
            // 
            // cboxKategorije
            // 
            this.cboxKategorije.FormattingEnabled = true;
            this.cboxKategorije.Location = new System.Drawing.Point(172, 38);
            this.cboxKategorije.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboxKategorije.Name = "cboxKategorije";
            this.cboxKategorije.Size = new System.Drawing.Size(140, 24);
            this.cboxKategorije.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Kategorija";
            // 
            // btnOdaberiFilm
            // 
            this.btnOdaberiFilm.Location = new System.Drawing.Point(759, 156);
            this.btnOdaberiFilm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOdaberiFilm.Name = "btnOdaberiFilm";
            this.btnOdaberiFilm.Size = new System.Drawing.Size(124, 42);
            this.btnOdaberiFilm.TabIndex = 26;
            this.btnOdaberiFilm.Text = "Odaberi film";
            this.btnOdaberiFilm.UseVisualStyleBackColor = true;
            this.btnOdaberiFilm.Click += new System.EventHandler(this.btnOdaberiFilm_Click);
            // 
            // btnPrijava
            // 
            this.btnPrijava.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPrijava.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrijava.Location = new System.Drawing.Point(784, 6);
            this.btnPrijava.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPrijava.Name = "btnPrijava";
            this.btnPrijava.Size = new System.Drawing.Size(99, 28);
            this.btnPrijava.TabIndex = 27;
            this.btnPrijava.Text = "Prijavi se";
            this.btnPrijava.UseVisualStyleBackColor = false;
            this.btnPrijava.Click += new System.EventHandler(this.btnPrijava_Click);
            // 
            // FormPregledFilmova
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 686);
            this.Controls.Add(this.btnPrijava);
            this.Controls.Add(this.btnOdaberiFilm);
            this.Controls.Add(this.gboxUrediFilmove);
            this.Controls.Add(this.lblKorisnickoIme);
            this.Controls.Add(this.dgvFilmovi);
            this.Controls.Add(this.btnOdjava);
            this.Controls.Add(this.pboxKinoSlika);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.gboxFilter);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormPregledFilmova";
            this.Text = "Pregled filmova";
            this.Load += new System.EventHandler(this.FormPregledFilmova_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.FormPregledFilmova_HelpRequested);
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
        private System.Windows.Forms.Button btnPrijava;
    }
}