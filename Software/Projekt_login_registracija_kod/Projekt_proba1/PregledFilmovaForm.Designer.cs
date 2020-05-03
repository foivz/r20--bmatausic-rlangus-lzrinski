namespace Projekt_proba1
{
    partial class PregledFilmovaForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblPrijevljen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prijavljen kao:";
            // 
            // lblPrijevljen
            // 
            this.lblPrijevljen.AutoSize = true;
            this.lblPrijevljen.Location = new System.Drawing.Point(160, 49);
            this.lblPrijevljen.Name = "lblPrijevljen";
            this.lblPrijevljen.Size = new System.Drawing.Size(39, 17);
            this.lblPrijevljen.TabIndex = 1;
            this.lblPrijevljen.Text = "error";
            // 
            // PregledFilmovaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPrijevljen);
            this.Controls.Add(this.label1);
            this.Name = "PregledFilmovaForm";
            this.Text = "PregledFilmovaForm";
            this.Load += new System.EventHandler(this.PregledFilmovaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPrijevljen;
    }
}