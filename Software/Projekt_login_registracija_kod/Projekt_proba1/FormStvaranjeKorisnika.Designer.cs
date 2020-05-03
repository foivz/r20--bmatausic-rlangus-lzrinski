namespace Projekt_proba1
{
    partial class FormStvaranjeKorisnika
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
            this.txtLozinkaStvaranje = new System.Windows.Forms.TextBox();
            this.txtKorisnickoImeStvaranje = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPrijava = new System.Windows.Forms.Label();
            this.btnStvori = new System.Windows.Forms.Button();
            this.txtPonoviLozinku = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblLozinka = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtLozinkaStvaranje
            // 
            this.txtLozinkaStvaranje.Location = new System.Drawing.Point(141, 228);
            this.txtLozinkaStvaranje.Multiline = true;
            this.txtLozinkaStvaranje.Name = "txtLozinkaStvaranje";
            this.txtLozinkaStvaranje.PasswordChar = '*';
            this.txtLozinkaStvaranje.Size = new System.Drawing.Size(167, 23);
            this.txtLozinkaStvaranje.TabIndex = 10;
            this.txtLozinkaStvaranje.TextChanged += new System.EventHandler(this.txtLozinkaStvaranje_TextChanged);
            // 
            // txtKorisnickoImeStvaranje
            // 
            this.txtKorisnickoImeStvaranje.Location = new System.Drawing.Point(141, 161);
            this.txtKorisnickoImeStvaranje.Multiline = true;
            this.txtKorisnickoImeStvaranje.Name = "txtKorisnickoImeStvaranje";
            this.txtKorisnickoImeStvaranje.Size = new System.Drawing.Size(167, 23);
            this.txtKorisnickoImeStvaranje.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Lozinka:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Korisničko ime:";
            // 
            // lblPrijava
            // 
            this.lblPrijava.AutoSize = true;
            this.lblPrijava.Font = new System.Drawing.Font("Candara", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrijava.Location = new System.Drawing.Point(99, 39);
            this.lblPrijava.Name = "lblPrijava";
            this.lblPrijava.Size = new System.Drawing.Size(253, 40);
            this.lblPrijava.TabIndex = 11;
            this.lblPrijava.Text = "Stvaranje računa";
            this.lblPrijava.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStvori
            // 
            this.btnStvori.Location = new System.Drawing.Point(220, 358);
            this.btnStvori.Name = "btnStvori";
            this.btnStvori.Size = new System.Drawing.Size(158, 33);
            this.btnStvori.TabIndex = 12;
            this.btnStvori.Text = "Stvori";
            this.btnStvori.UseVisualStyleBackColor = true;
            this.btnStvori.Click += new System.EventHandler(this.btnStvori_Click);
            // 
            // txtPonoviLozinku
            // 
            this.txtPonoviLozinku.Location = new System.Drawing.Point(141, 295);
            this.txtPonoviLozinku.Multiline = true;
            this.txtPonoviLozinku.Name = "txtPonoviLozinku";
            this.txtPonoviLozinku.PasswordChar = '*';
            this.txtPonoviLozinku.Size = new System.Drawing.Size(167, 23);
            this.txtPonoviLozinku.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Ponovi lozinku:";
            // 
            // lblLozinka
            // 
            this.lblLozinka.AutoSize = true;
            this.lblLozinka.Location = new System.Drawing.Point(282, 233);
            this.lblLozinka.Name = "lblLozinka";
            this.lblLozinka.Size = new System.Drawing.Size(0, 17);
            this.lblLozinka.TabIndex = 15;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(141, 102);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(167, 23);
            this.txtEmail.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(73, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "E-mail:";
            // 
            // FormStvaranjeKorisnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 403);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblLozinka);
            this.Controls.Add(this.txtPonoviLozinku);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnStvori);
            this.Controls.Add(this.lblPrijava);
            this.Controls.Add(this.txtLozinkaStvaranje);
            this.Controls.Add(this.txtKorisnickoImeStvaranje);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "FormStvaranjeKorisnika";
            this.Text = "Stvaranje novog računa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLozinkaStvaranje;
        private System.Windows.Forms.TextBox txtKorisnickoImeStvaranje;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPrijava;
        private System.Windows.Forms.Button btnStvori;
        private System.Windows.Forms.TextBox txtPonoviLozinku;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblLozinka;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
    }
}