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
            this.btnOdjava = new System.Windows.Forms.Button();
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
            this.lblVrijemePrikaza = new System.Windows.Forms.Label();
            this.lblRedateljFilma = new System.Windows.Forms.Label();
            this.lblDvoranaId = new System.Windows.Forms.Label();
            this.lblSadrzajFilma = new System.Windows.Forms.Label();
            this.pboxFilmCover = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pboxKinoSlika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxFilmCover)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOdjava
            // 
            this.btnOdjava.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOdjava.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdjava.Location = new System.Drawing.Point(493, 6);
            this.btnOdjava.Name = "btnOdjava";
            this.btnOdjava.Size = new System.Drawing.Size(74, 23);
            this.btnOdjava.TabIndex = 16;
            this.btnOdjava.Text = "Odjava";
            this.btnOdjava.UseVisualStyleBackColor = false;
            // 
            // pboxKinoSlika
            // 
            this.pboxKinoSlika.Location = new System.Drawing.Point(12, 53);
            this.pboxKinoSlika.Name = "pboxKinoSlika";
            this.pboxKinoSlika.Size = new System.Drawing.Size(89, 88);
            this.pboxKinoSlika.TabIndex = 15;
            this.pboxKinoSlika.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "INFORMACIJE O FILMU";
            // 
            // btnRezervirajKartu
            // 
            this.btnRezervirajKartu.Location = new System.Drawing.Point(377, 404);
            this.btnRezervirajKartu.Name = "btnRezervirajKartu";
            this.btnRezervirajKartu.Size = new System.Drawing.Size(190, 23);
            this.btnRezervirajKartu.TabIndex = 19;
            this.btnRezervirajKartu.Text = "Rezerviraj ulaznicu";
            this.btnRezervirajKartu.UseVisualStyleBackColor = true;
            // 
            // lblKorisnickoIme
            // 
            this.lblKorisnickoIme.AutoSize = true;
            this.lblKorisnickoIme.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblKorisnickoIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKorisnickoIme.ForeColor = System.Drawing.Color.FloralWhite;
            this.lblKorisnickoIme.Location = new System.Drawing.Point(416, 9);
            this.lblKorisnickoIme.Name = "lblKorisnickoIme";
            this.lblKorisnickoIme.Size = new System.Drawing.Size(69, 16);
            this.lblKorisnickoIme.TabIndex = 21;
            this.lblKorisnickoIme.Text = "Korisnik id";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pictureBox2.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(590, 37);
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(186, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "Film:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(186, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "Dvorana:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(186, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "Vrijeme:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(186, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 16);
            this.label5.TabIndex = 28;
            this.label5.Text = "Redatelj:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(186, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 29;
            this.label6.Text = "Sadržaj:";
            // 
            // lblFilmIme
            // 
            this.lblFilmIme.AutoSize = true;
            this.lblFilmIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilmIme.Location = new System.Drawing.Point(233, 200);
            this.lblFilmIme.Name = "lblFilmIme";
            this.lblFilmIme.Size = new System.Drawing.Size(27, 15);
            this.lblFilmIme.TabIndex = 34;
            this.lblFilmIme.Text = "film";
            // 
            // lblVrijemePrikaza
            // 
            this.lblVrijemePrikaza.AutoSize = true;
            this.lblVrijemePrikaza.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVrijemePrikaza.Location = new System.Drawing.Point(257, 227);
            this.lblVrijemePrikaza.Name = "lblVrijemePrikaza";
            this.lblVrijemePrikaza.Size = new System.Drawing.Size(47, 15);
            this.lblVrijemePrikaza.TabIndex = 35;
            this.lblVrijemePrikaza.Text = "vrijeme";
            // 
            // lblRedateljFilma
            // 
            this.lblRedateljFilma.AutoSize = true;
            this.lblRedateljFilma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRedateljFilma.Location = new System.Drawing.Point(263, 281);
            this.lblRedateljFilma.Name = "lblRedateljFilma";
            this.lblRedateljFilma.Size = new System.Drawing.Size(48, 15);
            this.lblRedateljFilma.TabIndex = 36;
            this.lblRedateljFilma.Text = "redatelj";
            // 
            // lblDvoranaId
            // 
            this.lblDvoranaId.AutoSize = true;
            this.lblDvoranaId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDvoranaId.Location = new System.Drawing.Point(263, 255);
            this.lblDvoranaId.Name = "lblDvoranaId";
            this.lblDvoranaId.Size = new System.Drawing.Size(51, 15);
            this.lblDvoranaId.TabIndex = 37;
            this.lblDvoranaId.Text = "dvorana";
            // 
            // lblSadrzajFilma
            // 
            this.lblSadrzajFilma.AutoSize = true;
            this.lblSadrzajFilma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSadrzajFilma.Location = new System.Drawing.Point(258, 307);
            this.lblSadrzajFilma.Name = "lblSadrzajFilma";
            this.lblSadrzajFilma.Size = new System.Drawing.Size(47, 15);
            this.lblSadrzajFilma.TabIndex = 38;
            this.lblSadrzajFilma.Text = "sadrzaj";
            // 
            // pboxFilmCover
            // 
            this.pboxFilmCover.Location = new System.Drawing.Point(13, 175);
            this.pboxFilmCover.Name = "pboxFilmCover";
            this.pboxFilmCover.Size = new System.Drawing.Size(124, 184);
            this.pboxFilmCover.TabIndex = 39;
            this.pboxFilmCover.TabStop = false;
            // 
            // FormInformacijeFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 459);
            this.Controls.Add(this.pboxFilmCover);
            this.Controls.Add(this.lblSadrzajFilma);
            this.Controls.Add(this.lblDvoranaId);
            this.Controls.Add(this.lblRedateljFilma);
            this.Controls.Add(this.lblVrijemePrikaza);
            this.Controls.Add(this.lblFilmIme);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOdjava);
            this.Controls.Add(this.pboxKinoSlika);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRezervirajKartu);
            this.Controls.Add(this.lblKorisnickoIme);
            this.Controls.Add(this.pictureBox2);
            this.Name = "FormInformacijeFilm";
            this.Text = "Informacije o filmu";
            ((System.ComponentModel.ISupportInitialize)(this.pboxKinoSlika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxFilmCover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnOdjava;
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
        private System.Windows.Forms.Label lblVrijemePrikaza;
        private System.Windows.Forms.Label lblRedateljFilma;
        private System.Windows.Forms.Label lblDvoranaId;
        private System.Windows.Forms.Label lblSadrzajFilma;
        private System.Windows.Forms.PictureBox pboxFilmCover;
    }
}