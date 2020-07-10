namespace Projekt_proba1
{
    partial class FormInformacijeFilm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInformacijeFilm));
            this.pboxKinoSlika = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRezervirajKartu = new System.Windows.Forms.Button();
            this.lblKorisnickoIme = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblFilmIme = new System.Windows.Forms.Label();
            this.lblRedateljFilma = new System.Windows.Forms.Label();
            this.lblDvoranaId = new System.Windows.Forms.Label();
            this.pboxFilmCover = new System.Windows.Forms.PictureBox();
            this.txtSadrzaj = new System.Windows.Forms.TextBox();
            this.cboxVrijeme = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pboxKinoSlika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxFilmCover)).BeginInit();
            this.SuspendLayout();
            // 
            // pboxKinoSlika
            // 
            this.pboxKinoSlika.Image = ((System.Drawing.Image)(resources.GetObject("pboxKinoSlika.Image")));
            this.pboxKinoSlika.Location = new System.Drawing.Point(16, 65);
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
            this.label1.Location = new System.Drawing.Point(156, 103);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 36);
            this.label1.TabIndex = 14;
            this.label1.Text = "INFORMACIJE O FILMU";
            // 
            // btnRezervirajKartu
            // 
            this.btnRezervirajKartu.Location = new System.Drawing.Point(479, 506);
            this.btnRezervirajKartu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRezervirajKartu.Name = "btnRezervirajKartu";
            this.btnRezervirajKartu.Size = new System.Drawing.Size(253, 28);
            this.btnRezervirajKartu.TabIndex = 19;
            this.btnRezervirajKartu.Text = "Rezerviraj ulaznicu";
            this.btnRezervirajKartu.UseVisualStyleBackColor = true;
            this.btnRezervirajKartu.Click += new System.EventHandler(this.btnRezervirajKartu_Click);
            // 
            // lblKorisnickoIme
            // 
            this.lblKorisnickoIme.AutoSize = true;
            this.lblKorisnickoIme.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblKorisnickoIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKorisnickoIme.ForeColor = System.Drawing.Color.FloralWhite;
            this.lblKorisnickoIme.Location = new System.Drawing.Point(630, 13);
            this.lblKorisnickoIme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKorisnickoIme.Name = "lblKorisnickoIme";
            this.lblKorisnickoIme.Size = new System.Drawing.Size(87, 20);
            this.lblKorisnickoIme.TabIndex = 21;
            this.lblKorisnickoIme.Text = "Korisnik id";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pictureBox2.Location = new System.Drawing.Point(-3, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(753, 46);
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(276, 247);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Film:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(243, 314);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "Dvorana:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(248, 279);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Vrijeme:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(243, 347);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "Redatelj:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(248, 380);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 29;
            this.label6.Text = "Sadržaj:";
            // 
            // lblFilmIme
            // 
            this.lblFilmIme.AutoSize = true;
            this.lblFilmIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilmIme.Location = new System.Drawing.Point(344, 247);
            this.lblFilmIme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFilmIme.Name = "lblFilmIme";
            this.lblFilmIme.Size = new System.Drawing.Size(31, 18);
            this.lblFilmIme.TabIndex = 34;
            this.lblFilmIme.Text = "film";
            // 
            // lblRedateljFilma
            // 
            this.lblRedateljFilma.AutoSize = true;
            this.lblRedateljFilma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRedateljFilma.Location = new System.Drawing.Point(344, 348);
            this.lblRedateljFilma.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRedateljFilma.Name = "lblRedateljFilma";
            this.lblRedateljFilma.Size = new System.Drawing.Size(55, 18);
            this.lblRedateljFilma.TabIndex = 36;
            this.lblRedateljFilma.Text = "redatelj";
            // 
            // lblDvoranaId
            // 
            this.lblDvoranaId.AutoSize = true;
            this.lblDvoranaId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDvoranaId.Location = new System.Drawing.Point(344, 314);
            this.lblDvoranaId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDvoranaId.Name = "lblDvoranaId";
            this.lblDvoranaId.Size = new System.Drawing.Size(61, 18);
            this.lblDvoranaId.TabIndex = 37;
            this.lblDvoranaId.Text = "dvorana";
            // 
            // pboxFilmCover
            // 
            this.pboxFilmCover.Location = new System.Drawing.Point(17, 215);
            this.pboxFilmCover.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pboxFilmCover.Name = "pboxFilmCover";
            this.pboxFilmCover.Size = new System.Drawing.Size(165, 226);
            this.pboxFilmCover.TabIndex = 39;
            this.pboxFilmCover.TabStop = false;
            // 
            // txtSadrzaj
            // 
            this.txtSadrzaj.Location = new System.Drawing.Point(347, 380);
            this.txtSadrzaj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSadrzaj.Multiline = true;
            this.txtSadrzaj.Name = "txtSadrzaj";
            this.txtSadrzaj.ReadOnly = true;
            this.txtSadrzaj.Size = new System.Drawing.Size(311, 99);
            this.txtSadrzaj.TabIndex = 40;
            // 
            // cboxVrijeme
            // 
            this.cboxVrijeme.FormattingEnabled = true;
            this.cboxVrijeme.Location = new System.Drawing.Point(347, 279);
            this.cboxVrijeme.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboxVrijeme.Name = "cboxVrijeme";
            this.cboxVrijeme.Size = new System.Drawing.Size(185, 24);
            this.cboxVrijeme.TabIndex = 41;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 10);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(90, 29);
            this.btnBack.TabIndex = 69;
            this.btnBack.Text = "Nazad";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FormInformacijeFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 546);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.cboxVrijeme);
            this.Controls.Add(this.txtSadrzaj);
            this.Controls.Add(this.pboxFilmCover);
            this.Controls.Add(this.lblDvoranaId);
            this.Controls.Add(this.lblRedateljFilma);
            this.Controls.Add(this.lblFilmIme);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pboxKinoSlika);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRezervirajKartu);
            this.Controls.Add(this.lblKorisnickoIme);
            this.Controls.Add(this.pictureBox2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormInformacijeFilm";
            this.Text = "Informacije o filmu";
            this.Load += new System.EventHandler(this.FormInformacijeFilm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboxKinoSlika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxFilmCover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pboxKinoSlika;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRezervirajKartu;
        private System.Windows.Forms.Label lblKorisnickoIme;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblFilmIme;
        private System.Windows.Forms.Label lblRedateljFilma;
        private System.Windows.Forms.Label lblDvoranaId;
        private System.Windows.Forms.PictureBox pboxFilmCover;
        private System.Windows.Forms.TextBox txtSadrzaj;
        private System.Windows.Forms.ComboBox cboxVrijeme;
        private System.Windows.Forms.Button btnBack;
    }
}