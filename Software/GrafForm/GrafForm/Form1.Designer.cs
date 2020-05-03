namespace GrafForm
{
    partial class GrafoviForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GrafoviForm));
            this.label1 = new System.Windows.Forms.Label();
            this.cBoxGrafovi = new System.Windows.Forms.ComboBox();
            this.pictureBoxGrafovi = new System.Windows.Forms.PictureBox();
            this.btnOdjava = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGrafovi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Grafovi poslovanja";
            // 
            // cBoxGrafovi
            // 
            this.cBoxGrafovi.FormattingEnabled = true;
            this.cBoxGrafovi.Location = new System.Drawing.Point(30, 69);
            this.cBoxGrafovi.Name = "cBoxGrafovi";
            this.cBoxGrafovi.Size = new System.Drawing.Size(174, 24);
            this.cBoxGrafovi.TabIndex = 2;
            this.cBoxGrafovi.Text = "-- Odaberi graf za prikaz --";
            // 
            // pictureBoxGrafovi
            // 
            this.pictureBoxGrafovi.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxGrafovi.Image")));
            this.pictureBoxGrafovi.Location = new System.Drawing.Point(30, 99);
            this.pictureBoxGrafovi.Name = "pictureBoxGrafovi";
            this.pictureBoxGrafovi.Size = new System.Drawing.Size(597, 434);
            this.pictureBoxGrafovi.TabIndex = 3;
            this.pictureBoxGrafovi.TabStop = false;
            // 
            // btnOdjava
            // 
            this.btnOdjava.Location = new System.Drawing.Point(531, 21);
            this.btnOdjava.Name = "btnOdjava";
            this.btnOdjava.Size = new System.Drawing.Size(111, 34);
            this.btnOdjava.TabIndex = 4;
            this.btnOdjava.Text = "Odjava";
            this.btnOdjava.UseVisualStyleBackColor = true;
            // 
            // GrafoviForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 543);
            this.Controls.Add(this.btnOdjava);
            this.Controls.Add(this.pictureBoxGrafovi);
            this.Controls.Add(this.cBoxGrafovi);
            this.Controls.Add(this.label1);
            this.Name = "GrafoviForm";
            this.Text = "GrafoviForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGrafovi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBoxGrafovi;
        private System.Windows.Forms.PictureBox pictureBoxGrafovi;
        private System.Windows.Forms.Button btnOdjava;
    }
}

