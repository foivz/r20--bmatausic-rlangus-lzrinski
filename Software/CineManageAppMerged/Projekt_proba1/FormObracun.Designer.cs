namespace Projekt_proba1
{
    partial class FormObracun
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormObracun));
            this.gboxInfoTransakcije = new System.Windows.Forms.GroupBox();
            this.lblSumaUlaznice = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboxFilterZaradaFilm = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvZaradaOdUlaznica = new System.Windows.Forms.DataGridView();
            this.pboxKinoSlika = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIzradiIzvjestaj = new System.Windows.Forms.Button();
            this.lblKorisnickoIme = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblUkUlaznice = new System.Windows.Forms.Label();
            this.lblNazivProdano = new System.Windows.Forms.Label();
            this.cboxFilterUlazniceFilm = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnIzradiIzvjestajFilm = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboxFilmIzvjestaj = new System.Windows.Forms.ComboBox();
            this.gboxInfoTransakcije.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaradaOdUlaznica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxKinoSlika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboxInfoTransakcije
            // 
            this.gboxInfoTransakcije.Controls.Add(this.lblSumaUlaznice);
            this.gboxInfoTransakcije.Controls.Add(this.label6);
            this.gboxInfoTransakcije.Controls.Add(this.cboxFilterZaradaFilm);
            this.gboxInfoTransakcije.Controls.Add(this.label2);
            this.gboxInfoTransakcije.Controls.Add(this.dgvZaradaOdUlaznica);
            this.gboxInfoTransakcije.Location = new System.Drawing.Point(16, 230);
            this.gboxInfoTransakcije.Margin = new System.Windows.Forms.Padding(4);
            this.gboxInfoTransakcije.Name = "gboxInfoTransakcije";
            this.gboxInfoTransakcije.Padding = new System.Windows.Forms.Padding(4);
            this.gboxInfoTransakcije.Size = new System.Drawing.Size(811, 288);
            this.gboxInfoTransakcije.TabIndex = 65;
            this.gboxInfoTransakcije.TabStop = false;
            this.gboxInfoTransakcije.Text = "Prikaz zarade od prodanih ulaznica";
            // 
            // lblSumaUlaznice
            // 
            this.lblSumaUlaznice.AutoSize = true;
            this.lblSumaUlaznice.Location = new System.Drawing.Point(225, 262);
            this.lblSumaUlaznice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSumaUlaznice.Name = "lblSumaUlaznice";
            this.lblSumaUlaznice.Size = new System.Drawing.Size(23, 17);
            this.lblSumaUlaznice.TabIndex = 8;
            this.lblSumaUlaznice.Text = "uk";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 262);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(211, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Ukupna zarada od ulaznica:";
            // 
            // cboxFilterZaradaFilm
            // 
            this.cboxFilterZaradaFilm.FormattingEnabled = true;
            this.cboxFilterZaradaFilm.Location = new System.Drawing.Point(111, 224);
            this.cboxFilterZaradaFilm.Margin = new System.Windows.Forms.Padding(4);
            this.cboxFilterZaradaFilm.Name = "cboxFilterZaradaFilm";
            this.cboxFilterZaradaFilm.Size = new System.Drawing.Size(160, 24);
            this.cboxFilterZaradaFilm.TabIndex = 3;
            this.cboxFilterZaradaFilm.SelectionChangeCommitted += new System.EventHandler(this.cboxFilterZaradaFilm_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 228);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Filter po filmu:";
            // 
            // dgvZaradaOdUlaznica
            // 
            this.dgvZaradaOdUlaznica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZaradaOdUlaznica.Location = new System.Drawing.Point(8, 23);
            this.dgvZaradaOdUlaznica.Margin = new System.Windows.Forms.Padding(4);
            this.dgvZaradaOdUlaznica.Name = "dgvZaradaOdUlaznica";
            this.dgvZaradaOdUlaznica.RowHeadersWidth = 51;
            this.dgvZaradaOdUlaznica.Size = new System.Drawing.Size(795, 185);
            this.dgvZaradaOdUlaznica.TabIndex = 0;
            // 
            // pboxKinoSlika
            // 
            this.pboxKinoSlika.Image = ((System.Drawing.Image)(resources.GetObject("pboxKinoSlika.Image")));
            this.pboxKinoSlika.Location = new System.Drawing.Point(16, 65);
            this.pboxKinoSlika.Margin = new System.Windows.Forms.Padding(4);
            this.pboxKinoSlika.Name = "pboxKinoSlika";
            this.pboxKinoSlika.Size = new System.Drawing.Size(119, 108);
            this.pboxKinoSlika.TabIndex = 60;
            this.pboxKinoSlika.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(156, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 36);
            this.label1.TabIndex = 59;
            this.label1.Text = "OBRAČUN";
            // 
            // btnIzradiIzvjestaj
            // 
            this.btnIzradiIzvjestaj.Location = new System.Drawing.Point(16, 805);
            this.btnIzradiIzvjestaj.Margin = new System.Windows.Forms.Padding(4);
            this.btnIzradiIzvjestaj.Name = "btnIzradiIzvjestaj";
            this.btnIzradiIzvjestaj.Size = new System.Drawing.Size(413, 50);
            this.btnIzradiIzvjestaj.TabIndex = 62;
            this.btnIzradiIzvjestaj.Text = "Izradi izvještaj svih filmova";
            this.btnIzradiIzvjestaj.UseVisualStyleBackColor = true;
            this.btnIzradiIzvjestaj.Click += new System.EventHandler(this.btnIzradiIzvjestaj_Click);
            // 
            // lblKorisnickoIme
            // 
            this.lblKorisnickoIme.AutoSize = true;
            this.lblKorisnickoIme.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblKorisnickoIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKorisnickoIme.ForeColor = System.Drawing.Color.FloralWhite;
            this.lblKorisnickoIme.Location = new System.Drawing.Point(723, 13);
            this.lblKorisnickoIme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKorisnickoIme.Name = "lblKorisnickoIme";
            this.lblKorisnickoIme.Size = new System.Drawing.Size(87, 20);
            this.lblKorisnickoIme.TabIndex = 63;
            this.lblKorisnickoIme.Text = "Korisnik id";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pictureBox2.Location = new System.Drawing.Point(-3, -1);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(845, 46);
            this.pictureBox2.TabIndex = 64;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblUkUlaznice);
            this.groupBox1.Controls.Add(this.lblNazivProdano);
            this.groupBox1.Controls.Add(this.cboxFilterUlazniceFilm);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(16, 526);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(811, 234);
            this.groupBox1.TabIndex = 66;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Broj prodanih ulaznica";
            // 
            // lblUkUlaznice
            // 
            this.lblUkUlaznice.AutoSize = true;
            this.lblUkUlaznice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUkUlaznice.Location = new System.Drawing.Point(394, 83);
            this.lblUkUlaznice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUkUlaznice.Name = "lblUkUlaznice";
            this.lblUkUlaznice.Size = new System.Drawing.Size(45, 32);
            this.lblUkUlaznice.TabIndex = 10;
            this.lblUkUlaznice.Text = "uk";
            // 
            // lblNazivProdano
            // 
            this.lblNazivProdano.AutoSize = true;
            this.lblNazivProdano.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNazivProdano.Location = new System.Drawing.Point(8, 83);
            this.lblNazivProdano.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNazivProdano.Name = "lblNazivProdano";
            this.lblNazivProdano.Size = new System.Drawing.Size(378, 32);
            this.lblNazivProdano.TabIndex = 9;
            this.lblNazivProdano.Text = "Ukupno prodanih ulaznica:";
            // 
            // cboxFilterUlazniceFilm
            // 
            this.cboxFilterUlazniceFilm.FormattingEnabled = true;
            this.cboxFilterUlazniceFilm.Location = new System.Drawing.Point(111, 154);
            this.cboxFilterUlazniceFilm.Margin = new System.Windows.Forms.Padding(4);
            this.cboxFilterUlazniceFilm.Name = "cboxFilterUlazniceFilm";
            this.cboxFilterUlazniceFilm.Size = new System.Drawing.Size(160, 24);
            this.cboxFilterUlazniceFilm.TabIndex = 3;
            this.cboxFilterUlazniceFilm.SelectionChangeCommitted += new System.EventHandler(this.cboxFilterUlazniceFilm_SelectionChangeCommitted);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 158);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Filter po filmu:";
            // 
            // btnIzradiIzvjestajFilm
            // 
            this.btnIzradiIzvjestajFilm.Location = new System.Drawing.Point(437, 805);
            this.btnIzradiIzvjestajFilm.Margin = new System.Windows.Forms.Padding(4);
            this.btnIzradiIzvjestajFilm.Name = "btnIzradiIzvjestajFilm";
            this.btnIzradiIzvjestajFilm.Size = new System.Drawing.Size(389, 50);
            this.btnIzradiIzvjestajFilm.TabIndex = 67;
            this.btnIzradiIzvjestajFilm.Text = "Izradi izvještaj odabranog filma";
            this.btnIzradiIzvjestajFilm.UseVisualStyleBackColor = true;
            this.btnIzradiIzvjestajFilm.Click += new System.EventHandler(this.btnIzradiIzvjestajFilm_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 7);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(90, 29);
            this.btnBack.TabIndex = 68;
            this.btnBack.Text = "Nazad";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(147, 774);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 17);
            this.label3.TabIndex = 69;
            this.label3.Text = "-------Svi filmovi-------";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(477, 774);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 17);
            this.label4.TabIndex = 70;
            this.label4.Text = "Odaberi film za izvještaj:";
            // 
            // cboxFilmIzvjestaj
            // 
            this.cboxFilmIzvjestaj.FormattingEnabled = true;
            this.cboxFilmIzvjestaj.Location = new System.Drawing.Point(645, 771);
            this.cboxFilmIzvjestaj.Margin = new System.Windows.Forms.Padding(4);
            this.cboxFilmIzvjestaj.Name = "cboxFilmIzvjestaj";
            this.cboxFilmIzvjestaj.Size = new System.Drawing.Size(160, 24);
            this.cboxFilmIzvjestaj.TabIndex = 11;
            // 
            // FormObracun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 869);
            this.Controls.Add(this.cboxFilmIzvjestaj);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnIzradiIzvjestajFilm);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gboxInfoTransakcije);
            this.Controls.Add(this.pboxKinoSlika);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIzradiIzvjestaj);
            this.Controls.Add(this.lblKorisnickoIme);
            this.Controls.Add(this.pictureBox2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormObracun";
            this.Text = "Obračun";
            this.Load += new System.EventHandler(this.FormObracun_Load);
            this.gboxInfoTransakcije.ResumeLayout(false);
            this.gboxInfoTransakcije.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaradaOdUlaznica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxKinoSlika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gboxInfoTransakcije;
        private System.Windows.Forms.PictureBox pboxKinoSlika;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIzradiIzvjestaj;
        private System.Windows.Forms.Label lblKorisnickoIme;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dgvZaradaOdUlaznica;
        private System.Windows.Forms.ComboBox cboxFilterZaradaFilm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboxFilterUlazniceFilm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnIzradiIzvjestajFilm;
        private System.Windows.Forms.Label lblSumaUlaznice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblUkUlaznice;
        private System.Windows.Forms.Label lblNazivProdano;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboxFilmIzvjestaj;
    }
}