namespace Projekt_proba1
{
    partial class FormAzuriranjeFilma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAzuriranjeFilma));
            this.pboxKinoSlika = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblKorisnickoIme = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dgvVremena = new System.Windows.Forms.DataGridView();
            this.btnDodajVrijeme = new System.Windows.Forms.Button();
            this.cboxVrijemePrikazivanja = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tboxDodajSadrzajFilma = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tboxDodajRedateljFilma = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAzurirajjFilm = new System.Windows.Forms.Button();
            this.btnCancelDodavanje = new System.Windows.Forms.Button();
            this.cboxDodajDvoranu = new System.Windows.Forms.ComboBox();
            this.tboxDodajCijenuUlaznice = new System.Windows.Forms.TextBox();
            this.tboxDodajTrajanjeFilma = new System.Windows.Forms.TextBox();
            this.tboxDodajImeFilma = new System.Windows.Forms.TextBox();
            this.cboxDodajZanrFilma = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pboxKinoSlika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVremena)).BeginInit();
            this.SuspendLayout();
            // 
            // pboxKinoSlika
            // 
            this.pboxKinoSlika.Image = ((System.Drawing.Image)(resources.GetObject("pboxKinoSlika.Image")));
            this.pboxKinoSlika.Location = new System.Drawing.Point(17, 70);
            this.pboxKinoSlika.Margin = new System.Windows.Forms.Padding(4);
            this.pboxKinoSlika.Name = "pboxKinoSlika";
            this.pboxKinoSlika.Size = new System.Drawing.Size(119, 108);
            this.pboxKinoSlika.TabIndex = 101;
            this.pboxKinoSlika.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(157, 107);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 36);
            this.label1.TabIndex = 100;
            this.label1.Text = "AŽURIRANJE FILMA";
            // 
            // lblKorisnickoIme
            // 
            this.lblKorisnickoIme.AutoSize = true;
            this.lblKorisnickoIme.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblKorisnickoIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKorisnickoIme.ForeColor = System.Drawing.Color.FloralWhite;
            this.lblKorisnickoIme.Location = new System.Drawing.Point(600, 13);
            this.lblKorisnickoIme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKorisnickoIme.Name = "lblKorisnickoIme";
            this.lblKorisnickoIme.Size = new System.Drawing.Size(87, 20);
            this.lblKorisnickoIme.TabIndex = 103;
            this.lblKorisnickoIme.Text = "Korisnik id";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pictureBox2.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(851, 46);
            this.pictureBox2.TabIndex = 104;
            this.pictureBox2.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana Pro", 7.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(15, 545);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(141, 14);
            this.label12.TabIndex = 130;
            this.label12.Text = "Odabrana vremena:";
            // 
            // dgvVremena
            // 
            this.dgvVremena.AllowUserToAddRows = false;
            this.dgvVremena.AllowUserToDeleteRows = false;
            this.dgvVremena.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVremena.Location = new System.Drawing.Point(18, 564);
            this.dgvVremena.Name = "dgvVremena";
            this.dgvVremena.RowHeadersWidth = 51;
            this.dgvVremena.RowTemplate.Height = 24;
            this.dgvVremena.Size = new System.Drawing.Size(408, 211);
            this.dgvVremena.TabIndex = 129;
            // 
            // btnDodajVrijeme
            // 
            this.btnDodajVrijeme.Location = new System.Drawing.Point(419, 500);
            this.btnDodajVrijeme.Name = "btnDodajVrijeme";
            this.btnDodajVrijeme.Size = new System.Drawing.Size(264, 27);
            this.btnDodajVrijeme.TabIndex = 127;
            this.btnDodajVrijeme.Text = "Dodaj vrijeme";
            this.btnDodajVrijeme.UseVisualStyleBackColor = true;
            this.btnDodajVrijeme.Click += new System.EventHandler(this.btnDodajVrijeme_Click);
            // 
            // cboxVrijemePrikazivanja
            // 
            this.cboxVrijemePrikazivanja.FormattingEnabled = true;
            this.cboxVrijemePrikazivanja.Location = new System.Drawing.Point(203, 502);
            this.cboxVrijemePrikazivanja.Margin = new System.Windows.Forms.Padding(4);
            this.cboxVrijemePrikazivanja.Name = "cboxVrijemePrikazivanja";
            this.cboxVrijemePrikazivanja.Size = new System.Drawing.Size(179, 24);
            this.cboxVrijemePrikazivanja.TabIndex = 126;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(212, 458);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 18);
            this.label11.TabIndex = 125;
            this.label11.Text = "kn";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(654, 208);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 18);
            this.label10.TabIndex = 124;
            this.label10.Text = "min";
            // 
            // tboxDodajSadrzajFilma
            // 
            this.tboxDodajSadrzajFilma.Location = new System.Drawing.Point(130, 303);
            this.tboxDodajSadrzajFilma.Margin = new System.Windows.Forms.Padding(4);
            this.tboxDodajSadrzajFilma.Multiline = true;
            this.tboxDodajSadrzajFilma.Name = "tboxDodajSadrzajFilma";
            this.tboxDodajSadrzajFilma.Size = new System.Drawing.Size(553, 121);
            this.tboxDodajSadrzajFilma.TabIndex = 123;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 303);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 18);
            this.label9.TabIndex = 122;
            this.label9.Text = "Sadržaj filma:";
            // 
            // tboxDodajRedateljFilma
            // 
            this.tboxDodajRedateljFilma.Location = new System.Drawing.Point(130, 254);
            this.tboxDodajRedateljFilma.Margin = new System.Windows.Forms.Padding(4);
            this.tboxDodajRedateljFilma.Name = "tboxDodajRedateljFilma";
            this.tboxDodajRedateljFilma.Size = new System.Drawing.Size(252, 22);
            this.tboxDodajRedateljFilma.TabIndex = 121;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 255);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 18);
            this.label8.TabIndex = 120;
            this.label8.Text = "Redatelj filma:";
            // 
            // btnAzurirajjFilm
            // 
            this.btnAzurirajjFilm.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAzurirajjFilm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAzurirajjFilm.Location = new System.Drawing.Point(452, 596);
            this.btnAzurirajjFilm.Margin = new System.Windows.Forms.Padding(4);
            this.btnAzurirajjFilm.Name = "btnAzurirajjFilm";
            this.btnAzurirajjFilm.Size = new System.Drawing.Size(145, 55);
            this.btnAzurirajjFilm.TabIndex = 119;
            this.btnAzurirajjFilm.Text = "AŽURIRAJ";
            this.btnAzurirajjFilm.UseVisualStyleBackColor = false;
            this.btnAzurirajjFilm.Click += new System.EventHandler(this.btnAzurirajjFilm_Click);
            // 
            // btnCancelDodavanje
            // 
            this.btnCancelDodavanje.BackColor = System.Drawing.Color.Crimson;
            this.btnCancelDodavanje.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelDodavanje.Location = new System.Drawing.Point(544, 691);
            this.btnCancelDodavanje.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelDodavanje.Name = "btnCancelDodavanje";
            this.btnCancelDodavanje.Size = new System.Drawing.Size(145, 55);
            this.btnCancelDodavanje.TabIndex = 118;
            this.btnCancelDodavanje.Text = "ODUSTANI";
            this.btnCancelDodavanje.UseVisualStyleBackColor = false;
            this.btnCancelDodavanje.Click += new System.EventHandler(this.btnCancelDodavanje_Click);
            // 
            // cboxDodajDvoranu
            // 
            this.cboxDodajDvoranu.FormattingEnabled = true;
            this.cboxDodajDvoranu.Location = new System.Drawing.Point(452, 455);
            this.cboxDodajDvoranu.Margin = new System.Windows.Forms.Padding(4);
            this.cboxDodajDvoranu.Name = "cboxDodajDvoranu";
            this.cboxDodajDvoranu.Size = new System.Drawing.Size(165, 24);
            this.cboxDodajDvoranu.TabIndex = 117;
            // 
            // tboxDodajCijenuUlaznice
            // 
            this.tboxDodajCijenuUlaznice.Location = new System.Drawing.Point(150, 457);
            this.tboxDodajCijenuUlaznice.Margin = new System.Windows.Forms.Padding(4);
            this.tboxDodajCijenuUlaznice.Name = "tboxDodajCijenuUlaznice";
            this.tboxDodajCijenuUlaznice.Size = new System.Drawing.Size(54, 22);
            this.tboxDodajCijenuUlaznice.TabIndex = 116;
            // 
            // tboxDodajTrajanjeFilma
            // 
            this.tboxDodajTrajanjeFilma.Location = new System.Drawing.Point(608, 206);
            this.tboxDodajTrajanjeFilma.Margin = new System.Windows.Forms.Padding(4);
            this.tboxDodajTrajanjeFilma.Name = "tboxDodajTrajanjeFilma";
            this.tboxDodajTrajanjeFilma.Size = new System.Drawing.Size(38, 22);
            this.tboxDodajTrajanjeFilma.TabIndex = 115;
            // 
            // tboxDodajImeFilma
            // 
            this.tboxDodajImeFilma.Location = new System.Drawing.Point(128, 207);
            this.tboxDodajImeFilma.Margin = new System.Windows.Forms.Padding(4);
            this.tboxDodajImeFilma.Name = "tboxDodajImeFilma";
            this.tboxDodajImeFilma.Size = new System.Drawing.Size(350, 22);
            this.tboxDodajImeFilma.TabIndex = 114;
            // 
            // cboxDodajZanrFilma
            // 
            this.cboxDodajZanrFilma.FormattingEnabled = true;
            this.cboxDodajZanrFilma.Location = new System.Drawing.Point(480, 252);
            this.cboxDodajZanrFilma.Margin = new System.Windows.Forms.Padding(4);
            this.cboxDodajZanrFilma.Name = "cboxDodajZanrFilma";
            this.cboxDodajZanrFilma.Size = new System.Drawing.Size(203, 24);
            this.cboxDodajZanrFilma.TabIndex = 113;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(368, 458);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 18);
            this.label7.TabIndex = 112;
            this.label7.Text = "Dvorana:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 503);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 18);
            this.label6.TabIndex = 111;
            this.label6.Text = "Raspored prikazivanja:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 458);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 18);
            this.label5.TabIndex = 110;
            this.label5.Text = "Cijena ulaznice:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(388, 255);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 18);
            this.label4.TabIndex = 109;
            this.label4.Text = "Žanr filma:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(486, 207);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 18);
            this.label3.TabIndex = 108;
            this.label3.Text = "Trajanje filma:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 208);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 18);
            this.label2.TabIndex = 107;
            this.label2.Text = "Naziv filma:";
            // 
            // FormAzuriranjeFilma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 803);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dgvVremena);
            this.Controls.Add(this.btnDodajVrijeme);
            this.Controls.Add(this.cboxVrijemePrikazivanja);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tboxDodajSadrzajFilma);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tboxDodajRedateljFilma);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnAzurirajjFilm);
            this.Controls.Add(this.btnCancelDodavanje);
            this.Controls.Add(this.cboxDodajDvoranu);
            this.Controls.Add(this.tboxDodajCijenuUlaznice);
            this.Controls.Add(this.tboxDodajTrajanjeFilma);
            this.Controls.Add(this.tboxDodajImeFilma);
            this.Controls.Add(this.cboxDodajZanrFilma);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pboxKinoSlika);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblKorisnickoIme);
            this.Controls.Add(this.pictureBox2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAzuriranjeFilma";
            this.Text = "Ažuriranje filma";
            this.Load += new System.EventHandler(this.FormAzuriranjeFilma_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.FormAzuriranjeFilma_HelpRequested);
            ((System.ComponentModel.ISupportInitialize)(this.pboxKinoSlika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVremena)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pboxKinoSlika;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblKorisnickoIme;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgvVremena;
        private System.Windows.Forms.Button btnDodajVrijeme;
        private System.Windows.Forms.ComboBox cboxVrijemePrikazivanja;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tboxDodajSadrzajFilma;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tboxDodajRedateljFilma;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAzurirajjFilm;
        private System.Windows.Forms.Button btnCancelDodavanje;
        private System.Windows.Forms.ComboBox cboxDodajDvoranu;
        private System.Windows.Forms.TextBox tboxDodajCijenuUlaznice;
        private System.Windows.Forms.TextBox tboxDodajTrajanjeFilma;
        private System.Windows.Forms.TextBox tboxDodajImeFilma;
        private System.Windows.Forms.ComboBox cboxDodajZanrFilma;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}