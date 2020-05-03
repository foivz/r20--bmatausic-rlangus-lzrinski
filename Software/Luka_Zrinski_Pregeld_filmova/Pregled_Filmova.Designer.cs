namespace test
{
    partial class Pregled_Filmova
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
            this.pregledFilmova = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.gboxUrediFilmove = new System.Windows.Forms.GroupBox();
            this.btnDodajFilm = new System.Windows.Forms.Button();
            this.btnAzurirajFilm = new System.Windows.Forms.Button();
            this.btnObrisiFilm = new System.Windows.Forms.Button();
            this.btnPrikazPoslovanja = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pregledFilmova)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gboxUrediFilmove.SuspendLayout();
            this.SuspendLayout();
            // 
            // pregledFilmova
            // 
            this.pregledFilmova.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pregledFilmova.Location = new System.Drawing.Point(11, 81);
            this.pregledFilmova.Margin = new System.Windows.Forms.Padding(2);
            this.pregledFilmova.Name = "pregledFilmova";
            this.pregledFilmova.RowHeadersWidth = 51;
            this.pregledFilmova.RowTemplate.Height = 24;
            this.pregledFilmova.Size = new System.Drawing.Size(452, 213);
            this.pregledFilmova.TabIndex = 0;
            this.pregledFilmova.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.tablicaData_CellMouseDoubleClick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.Gray;
            this.dateTimePicker1.Location = new System.Drawing.Point(11, 322);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(205, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.button1.Location = new System.Drawing.Point(350, 322);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 41);
            this.button1.TabIndex = 2;
            this.button1.Text = "Filtriraj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.button2.Location = new System.Drawing.Point(232, 322);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 41);
            this.button2.TabIndex = 3;
            this.button2.Text = "Početni prikaz";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Pregled filmova ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Silver;
            this.pictureBox1.Image = global::test.Properties.Resources.Cinemapic;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(539, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Odjava";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // gboxUrediFilmove
            // 
            this.gboxUrediFilmove.Controls.Add(this.btnObrisiFilm);
            this.gboxUrediFilmove.Controls.Add(this.btnAzurirajFilm);
            this.gboxUrediFilmove.Controls.Add(this.btnDodajFilm);
            this.gboxUrediFilmove.Location = new System.Drawing.Point(9, 386);
            this.gboxUrediFilmove.Name = "gboxUrediFilmove";
            this.gboxUrediFilmove.Size = new System.Drawing.Size(268, 82);
            this.gboxUrediFilmove.TabIndex = 7;
            this.gboxUrediFilmove.TabStop = false;
            this.gboxUrediFilmove.Text = "Uredi filmove";
            // 
            // btnDodajFilm
            // 
            this.btnDodajFilm.Location = new System.Drawing.Point(14, 33);
            this.btnDodajFilm.Name = "btnDodajFilm";
            this.btnDodajFilm.Size = new System.Drawing.Size(75, 23);
            this.btnDodajFilm.TabIndex = 0;
            this.btnDodajFilm.Text = "Dodaj";
            this.btnDodajFilm.UseVisualStyleBackColor = true;
            // 
            // btnAzurirajFilm
            // 
            this.btnAzurirajFilm.Location = new System.Drawing.Point(95, 33);
            this.btnAzurirajFilm.Name = "btnAzurirajFilm";
            this.btnAzurirajFilm.Size = new System.Drawing.Size(75, 23);
            this.btnAzurirajFilm.TabIndex = 1;
            this.btnAzurirajFilm.Text = "Ažuriraj";
            this.btnAzurirajFilm.UseVisualStyleBackColor = true;
            // 
            // btnObrisiFilm
            // 
            this.btnObrisiFilm.Location = new System.Drawing.Point(176, 33);
            this.btnObrisiFilm.Name = "btnObrisiFilm";
            this.btnObrisiFilm.Size = new System.Drawing.Size(75, 23);
            this.btnObrisiFilm.TabIndex = 2;
            this.btnObrisiFilm.Text = "Obriši";
            this.btnObrisiFilm.UseVisualStyleBackColor = true;
            // 
            // btnPrikazPoslovanja
            // 
            this.btnPrikazPoslovanja.Location = new System.Drawing.Point(486, 419);
            this.btnPrikazPoslovanja.Name = "btnPrikazPoslovanja";
            this.btnPrikazPoslovanja.Size = new System.Drawing.Size(128, 23);
            this.btnPrikazPoslovanja.TabIndex = 3;
            this.btnPrikazPoslovanja.Text = "Prikaz poslovanja";
            this.btnPrikazPoslovanja.UseVisualStyleBackColor = true;
            // 
            // Pregled_Filmova
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(626, 474);
            this.Controls.Add(this.btnPrikazPoslovanja);
            this.Controls.Add(this.gboxUrediFilmove);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.pregledFilmova);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Pregled_Filmova";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pregledFilmova)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gboxUrediFilmove.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView pregledFilmova;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox gboxUrediFilmove;
        private System.Windows.Forms.Button btnObrisiFilm;
        private System.Windows.Forms.Button btnAzurirajFilm;
        private System.Windows.Forms.Button btnDodajFilm;
        private System.Windows.Forms.Button btnPrikazPoslovanja;
    }
}

