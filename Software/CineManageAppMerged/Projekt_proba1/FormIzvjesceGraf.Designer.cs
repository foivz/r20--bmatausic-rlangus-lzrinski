namespace Projekt_proba1
{
    partial class FormIzvjesceGraf
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
            this.lblKorisnickoIme = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cboxFilterGraf = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pboxKinoSlika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.pboxKinoSlika.Location = new System.Drawing.Point(12, 52);
            this.pboxKinoSlika.Name = "pboxKinoSlika";
            this.pboxKinoSlika.Size = new System.Drawing.Size(89, 88);
            this.pboxKinoSlika.TabIndex = 15;
            this.pboxKinoSlika.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "GRAFOVI POSLOVANJA";
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
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(13, 168);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(563, 310);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // cboxFilterGraf
            // 
            this.cboxFilterGraf.FormattingEnabled = true;
            this.cboxFilterGraf.Location = new System.Drawing.Point(13, 496);
            this.cboxFilterGraf.Name = "cboxFilterGraf";
            this.cboxFilterGraf.Size = new System.Drawing.Size(121, 21);
            this.cboxFilterGraf.TabIndex = 26;
            // 
            // FormIzvjesceGraf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 538);
            this.Controls.Add(this.cboxFilterGraf);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnOdjava);
            this.Controls.Add(this.pboxKinoSlika);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblKorisnickoIme);
            this.Controls.Add(this.pictureBox2);
            this.Name = "FormIzvjesceGraf";
            this.Text = "Grafičko izvješće";
            ((System.ComponentModel.ISupportInitialize)(this.pboxKinoSlika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOdjava;
        private System.Windows.Forms.PictureBox pboxKinoSlika;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblKorisnickoIme;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cboxFilterGraf;
    }
}