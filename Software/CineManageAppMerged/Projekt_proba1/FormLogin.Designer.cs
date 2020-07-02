namespace Projekt_proba1
{
    partial class FormLogin
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
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.lblPrijava = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKorisnickoIme = new System.Windows.Forms.TextBox();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.linkStvoriRacun = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPrijava = new System.Windows.Forms.Button();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.btnNeregistrirani = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 392);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // lblPrijava
            // 
            this.lblPrijava.AutoSize = true;
            this.lblPrijava.Font = new System.Drawing.Font("Candara", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrijava.Location = new System.Drawing.Point(233, 49);
            this.lblPrijava.Name = "lblPrijava";
            this.lblPrijava.Size = new System.Drawing.Size(112, 40);
            this.lblPrijava.TabIndex = 1;
            this.lblPrijava.Text = "Prijava";
            this.lblPrijava.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Korisničko ime:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(207, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Lozinka:";
            // 
            // txtKorisnickoIme
            // 
            this.txtKorisnickoIme.Location = new System.Drawing.Point(297, 128);
            this.txtKorisnickoIme.Multiline = true;
            this.txtKorisnickoIme.Name = "txtKorisnickoIme";
            this.txtKorisnickoIme.Size = new System.Drawing.Size(110, 23);
            this.txtKorisnickoIme.TabIndex = 5;
            // 
            // txtLozinka
            // 
            this.txtLozinka.Location = new System.Drawing.Point(297, 195);
            this.txtLozinka.Multiline = true;
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.PasswordChar = '*';
            this.txtLozinka.Size = new System.Drawing.Size(110, 23);
            this.txtLozinka.TabIndex = 6;
            // 
            // linkStvoriRacun
            // 
            this.linkStvoriRacun.AutoSize = true;
            this.linkStvoriRacun.Location = new System.Drawing.Point(365, 366);
            this.linkStvoriRacun.Name = "linkStvoriRacun";
            this.linkStvoriRacun.Size = new System.Drawing.Size(42, 17);
            this.linkStvoriRacun.TabIndex = 7;
            this.linkStvoriRacun.TabStop = true;
            this.linkStvoriRacun.Text = "ovdje";
            this.linkStvoriRacun.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 366);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nemate račun? Stvorite ga";
            // 
            // btnPrijava
            // 
            this.btnPrijava.Location = new System.Drawing.Point(244, 251);
            this.btnPrijava.Name = "btnPrijava";
            this.btnPrijava.Size = new System.Drawing.Size(101, 28);
            this.btnPrijava.TabIndex = 9;
            this.btnPrijava.Text = "Prijavi se";
            this.btnPrijava.UseVisualStyleBackColor = true;
            this.btnPrijava.Click += new System.EventHandler(this.btnPrijava_Click);
            // 
            // dgvLista
            // 
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Location = new System.Drawing.Point(12, 12);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.RowHeadersWidth = 51;
            this.dgvLista.RowTemplate.Height = 24;
            this.dgvLista.Size = new System.Drawing.Size(552, 110);
            this.dgvLista.TabIndex = 10;
            // 
            // btnNeregistrirani
            // 
            this.btnNeregistrirani.Location = new System.Drawing.Point(211, 304);
            this.btnNeregistrirani.Name = "btnNeregistrirani";
            this.btnNeregistrirani.Size = new System.Drawing.Size(163, 28);
            this.btnNeregistrirani.TabIndex = 11;
            this.btnNeregistrirani.Text = "Nastavi kao gost";
            this.btnNeregistrirani.UseVisualStyleBackColor = true;
            this.btnNeregistrirani.Click += new System.EventHandler(this.btnNeregistrirani_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 392);
            this.Controls.Add(this.btnNeregistrirani);
            this.Controls.Add(this.dgvLista);
            this.Controls.Add(this.btnPrijava);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linkStvoriRacun);
            this.Controls.Add(this.txtLozinka);
            this.Controls.Add(this.txtKorisnickoIme);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPrijava);
            this.Controls.Add(this.splitter1);
            this.Name = "FormLogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label lblPrijava;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKorisnickoIme;
        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.LinkLabel linkStvoriRacun;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPrijava;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.Button btnNeregistrirani;
    }
}

