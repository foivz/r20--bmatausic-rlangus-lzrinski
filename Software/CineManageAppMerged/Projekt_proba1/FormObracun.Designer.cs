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
            this.rbtnFilterZaradaGodina = new System.Windows.Forms.RadioButton();
            this.rbtnFilterZaradaMjesec = new System.Windows.Forms.RadioButton();
            this.rbtnFilterZaradaDan = new System.Windows.Forms.RadioButton();
            this.cboxFilterZaradaFilm = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvZaradaOdUlaznica = new System.Windows.Forms.DataGridView();
            this.btnOdjava = new System.Windows.Forms.Button();
            this.pboxKinoSlika = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIzradiIzvjestaj = new System.Windows.Forms.Button();
            this.lblKorisnickoIme = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnFilterUlazniceGodina = new System.Windows.Forms.RadioButton();
            this.rbtnFilterUlazniceMjesec = new System.Windows.Forms.RadioButton();
            this.rbtnFilterUlazniceDan = new System.Windows.Forms.RadioButton();
            this.cboxFilterUlazniceFilm = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvBrojProdanihUlaznica = new System.Windows.Forms.DataGridView();
            this.btnPrikaziGraf = new System.Windows.Forms.Button();
            this.gboxInfoTransakcije.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaradaOdUlaznica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxKinoSlika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBrojProdanihUlaznica)).BeginInit();
            this.SuspendLayout();
            // 
            // gboxInfoTransakcije
            // 
            this.gboxInfoTransakcije.Controls.Add(this.rbtnFilterZaradaGodina);
            this.gboxInfoTransakcije.Controls.Add(this.rbtnFilterZaradaMjesec);
            this.gboxInfoTransakcije.Controls.Add(this.rbtnFilterZaradaDan);
            this.gboxInfoTransakcije.Controls.Add(this.cboxFilterZaradaFilm);
            this.gboxInfoTransakcije.Controls.Add(this.label3);
            this.gboxInfoTransakcije.Controls.Add(this.label2);
            this.gboxInfoTransakcije.Controls.Add(this.dgvZaradaOdUlaznica);
            this.gboxInfoTransakcije.Location = new System.Drawing.Point(12, 187);
            this.gboxInfoTransakcije.Name = "gboxInfoTransakcije";
            this.gboxInfoTransakcije.Size = new System.Drawing.Size(608, 234);
            this.gboxInfoTransakcije.TabIndex = 65;
            this.gboxInfoTransakcije.TabStop = false;
            this.gboxInfoTransakcije.Text = "Prikaz zarade od prodanih ulaznica";
            // 
            // rbtnFilterZaradaGodina
            // 
            this.rbtnFilterZaradaGodina.AutoSize = true;
            this.rbtnFilterZaradaGodina.Location = new System.Drawing.Point(543, 186);
            this.rbtnFilterZaradaGodina.Name = "rbtnFilterZaradaGodina";
            this.rbtnFilterZaradaGodina.Size = new System.Drawing.Size(59, 17);
            this.rbtnFilterZaradaGodina.TabIndex = 6;
            this.rbtnFilterZaradaGodina.TabStop = true;
            this.rbtnFilterZaradaGodina.Text = "Godina";
            this.rbtnFilterZaradaGodina.UseVisualStyleBackColor = true;
            // 
            // rbtnFilterZaradaMjesec
            // 
            this.rbtnFilterZaradaMjesec.AutoSize = true;
            this.rbtnFilterZaradaMjesec.Location = new System.Drawing.Point(478, 186);
            this.rbtnFilterZaradaMjesec.Name = "rbtnFilterZaradaMjesec";
            this.rbtnFilterZaradaMjesec.Size = new System.Drawing.Size(59, 17);
            this.rbtnFilterZaradaMjesec.TabIndex = 5;
            this.rbtnFilterZaradaMjesec.TabStop = true;
            this.rbtnFilterZaradaMjesec.Text = "Mjesec";
            this.rbtnFilterZaradaMjesec.UseVisualStyleBackColor = true;
            // 
            // rbtnFilterZaradaDan
            // 
            this.rbtnFilterZaradaDan.AutoSize = true;
            this.rbtnFilterZaradaDan.Location = new System.Drawing.Point(427, 186);
            this.rbtnFilterZaradaDan.Name = "rbtnFilterZaradaDan";
            this.rbtnFilterZaradaDan.Size = new System.Drawing.Size(45, 17);
            this.rbtnFilterZaradaDan.TabIndex = 4;
            this.rbtnFilterZaradaDan.TabStop = true;
            this.rbtnFilterZaradaDan.Text = "Dan";
            this.rbtnFilterZaradaDan.UseVisualStyleBackColor = true;
            // 
            // cboxFilterZaradaFilm
            // 
            this.cboxFilterZaradaFilm.FormattingEnabled = true;
            this.cboxFilterZaradaFilm.Location = new System.Drawing.Point(83, 182);
            this.cboxFilterZaradaFilm.Name = "cboxFilterZaradaFilm";
            this.cboxFilterZaradaFilm.Size = new System.Drawing.Size(121, 21);
            this.cboxFilterZaradaFilm.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(362, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Zarada po:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Filter po filmu:";
            // 
            // dgvZaradaOdUlaznica
            // 
            this.dgvZaradaOdUlaznica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZaradaOdUlaznica.Location = new System.Drawing.Point(6, 19);
            this.dgvZaradaOdUlaznica.Name = "dgvZaradaOdUlaznica";
            this.dgvZaradaOdUlaznica.Size = new System.Drawing.Size(596, 150);
            this.dgvZaradaOdUlaznica.TabIndex = 0;
            // 
            // btnOdjava
            // 
            this.btnOdjava.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOdjava.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdjava.Location = new System.Drawing.Point(546, 5);
            this.btnOdjava.Name = "btnOdjava";
            this.btnOdjava.Size = new System.Drawing.Size(74, 23);
            this.btnOdjava.TabIndex = 61;
            this.btnOdjava.Text = "Odjava";
            this.btnOdjava.UseVisualStyleBackColor = false;
            this.btnOdjava.Click += new System.EventHandler(this.btnOdjava_Click);
            // 
            // pboxKinoSlika
            // 
            this.pboxKinoSlika.Image = ((System.Drawing.Image)(resources.GetObject("pboxKinoSlika.Image")));
            this.pboxKinoSlika.Location = new System.Drawing.Point(12, 53);
            this.pboxKinoSlika.Name = "pboxKinoSlika";
            this.pboxKinoSlika.Size = new System.Drawing.Size(89, 88);
            this.pboxKinoSlika.TabIndex = 60;
            this.pboxKinoSlika.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 29);
            this.label1.TabIndex = 59;
            this.label1.Text = "OBRAČUN";
            // 
            // btnIzradiIzvjestaj
            // 
            this.btnIzradiIzvjestaj.Location = new System.Drawing.Point(12, 716);
            this.btnIzradiIzvjestaj.Name = "btnIzradiIzvjestaj";
            this.btnIzradiIzvjestaj.Size = new System.Drawing.Size(310, 41);
            this.btnIzradiIzvjestaj.TabIndex = 62;
            this.btnIzradiIzvjestaj.Text = "Izradi izvještaj";
            this.btnIzradiIzvjestaj.UseVisualStyleBackColor = true;
            // 
            // lblKorisnickoIme
            // 
            this.lblKorisnickoIme.AutoSize = true;
            this.lblKorisnickoIme.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblKorisnickoIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKorisnickoIme.ForeColor = System.Drawing.Color.FloralWhite;
            this.lblKorisnickoIme.Location = new System.Drawing.Point(471, 9);
            this.lblKorisnickoIme.Name = "lblKorisnickoIme";
            this.lblKorisnickoIme.Size = new System.Drawing.Size(69, 16);
            this.lblKorisnickoIme.TabIndex = 63;
            this.lblKorisnickoIme.Text = "Korisnik id";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pictureBox2.Location = new System.Drawing.Point(-2, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(634, 37);
            this.pictureBox2.TabIndex = 64;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnFilterUlazniceGodina);
            this.groupBox1.Controls.Add(this.rbtnFilterUlazniceMjesec);
            this.groupBox1.Controls.Add(this.rbtnFilterUlazniceDan);
            this.groupBox1.Controls.Add(this.cboxFilterUlazniceFilm);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dgvBrojProdanihUlaznica);
            this.groupBox1.Location = new System.Drawing.Point(12, 451);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(608, 234);
            this.groupBox1.TabIndex = 66;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Broj prodanih ulaznica";
            // 
            // rbtnFilterUlazniceGodina
            // 
            this.rbtnFilterUlazniceGodina.AutoSize = true;
            this.rbtnFilterUlazniceGodina.Location = new System.Drawing.Point(543, 186);
            this.rbtnFilterUlazniceGodina.Name = "rbtnFilterUlazniceGodina";
            this.rbtnFilterUlazniceGodina.Size = new System.Drawing.Size(59, 17);
            this.rbtnFilterUlazniceGodina.TabIndex = 6;
            this.rbtnFilterUlazniceGodina.TabStop = true;
            this.rbtnFilterUlazniceGodina.Text = "Godina";
            this.rbtnFilterUlazniceGodina.UseVisualStyleBackColor = true;
            // 
            // rbtnFilterUlazniceMjesec
            // 
            this.rbtnFilterUlazniceMjesec.AutoSize = true;
            this.rbtnFilterUlazniceMjesec.Location = new System.Drawing.Point(478, 186);
            this.rbtnFilterUlazniceMjesec.Name = "rbtnFilterUlazniceMjesec";
            this.rbtnFilterUlazniceMjesec.Size = new System.Drawing.Size(59, 17);
            this.rbtnFilterUlazniceMjesec.TabIndex = 5;
            this.rbtnFilterUlazniceMjesec.TabStop = true;
            this.rbtnFilterUlazniceMjesec.Text = "Mjesec";
            this.rbtnFilterUlazniceMjesec.UseVisualStyleBackColor = true;
            // 
            // rbtnFilterUlazniceDan
            // 
            this.rbtnFilterUlazniceDan.AutoSize = true;
            this.rbtnFilterUlazniceDan.Location = new System.Drawing.Point(427, 186);
            this.rbtnFilterUlazniceDan.Name = "rbtnFilterUlazniceDan";
            this.rbtnFilterUlazniceDan.Size = new System.Drawing.Size(45, 17);
            this.rbtnFilterUlazniceDan.TabIndex = 4;
            this.rbtnFilterUlazniceDan.TabStop = true;
            this.rbtnFilterUlazniceDan.Text = "Dan";
            this.rbtnFilterUlazniceDan.UseVisualStyleBackColor = true;
            // 
            // cboxFilterUlazniceFilm
            // 
            this.cboxFilterUlazniceFilm.FormattingEnabled = true;
            this.cboxFilterUlazniceFilm.Location = new System.Drawing.Point(83, 182);
            this.cboxFilterUlazniceFilm.Name = "cboxFilterUlazniceFilm";
            this.cboxFilterUlazniceFilm.Size = new System.Drawing.Size(121, 21);
            this.cboxFilterUlazniceFilm.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(362, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Zarada po:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Filter po filmu:";
            // 
            // dgvBrojProdanihUlaznica
            // 
            this.dgvBrojProdanihUlaznica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBrojProdanihUlaznica.Location = new System.Drawing.Point(6, 19);
            this.dgvBrojProdanihUlaznica.Name = "dgvBrojProdanihUlaznica";
            this.dgvBrojProdanihUlaznica.Size = new System.Drawing.Size(596, 150);
            this.dgvBrojProdanihUlaznica.TabIndex = 0;
            // 
            // btnPrikaziGraf
            // 
            this.btnPrikaziGraf.Location = new System.Drawing.Point(328, 716);
            this.btnPrikaziGraf.Name = "btnPrikaziGraf";
            this.btnPrikaziGraf.Size = new System.Drawing.Size(292, 41);
            this.btnPrikaziGraf.TabIndex = 67;
            this.btnPrikaziGraf.Text = "Prikaži graf";
            this.btnPrikaziGraf.UseVisualStyleBackColor = true;
            // 
            // FormObracun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 781);
            this.Controls.Add(this.btnPrikaziGraf);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gboxInfoTransakcije);
            this.Controls.Add(this.btnOdjava);
            this.Controls.Add(this.pboxKinoSlika);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIzradiIzvjestaj);
            this.Controls.Add(this.lblKorisnickoIme);
            this.Controls.Add(this.pictureBox2);
            this.Name = "FormObracun";
            this.Text = "Obračun";
            this.gboxInfoTransakcije.ResumeLayout(false);
            this.gboxInfoTransakcije.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaradaOdUlaznica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxKinoSlika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBrojProdanihUlaznica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gboxInfoTransakcije;
        private System.Windows.Forms.Button btnOdjava;
        private System.Windows.Forms.PictureBox pboxKinoSlika;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIzradiIzvjestaj;
        private System.Windows.Forms.Label lblKorisnickoIme;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dgvZaradaOdUlaznica;
        private System.Windows.Forms.RadioButton rbtnFilterZaradaGodina;
        private System.Windows.Forms.RadioButton rbtnFilterZaradaMjesec;
        private System.Windows.Forms.RadioButton rbtnFilterZaradaDan;
        private System.Windows.Forms.ComboBox cboxFilterZaradaFilm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnFilterUlazniceGodina;
        private System.Windows.Forms.RadioButton rbtnFilterUlazniceMjesec;
        private System.Windows.Forms.RadioButton rbtnFilterUlazniceDan;
        private System.Windows.Forms.ComboBox cboxFilterUlazniceFilm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvBrojProdanihUlaznica;
        private System.Windows.Forms.Button btnPrikaziGraf;
    }
}