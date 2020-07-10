namespace Projekt_proba1
{
    partial class SviFilmoviReportForm
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.RezervacijaViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportSviFilmovi = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.RezervacijaViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportSviFilmovi
            // 
            this.reportSviFilmovi.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.RezervacijaViewBindingSource;
            this.reportSviFilmovi.LocalReport.DataSources.Add(reportDataSource1);
            this.reportSviFilmovi.LocalReport.ReportEmbeddedResource = "Projekt_proba1.rptSviFilmovi.rdlc";
            this.reportSviFilmovi.Location = new System.Drawing.Point(0, 0);
            this.reportSviFilmovi.Name = "reportSviFilmovi";
            this.reportSviFilmovi.ServerReport.BearerToken = null;
            this.reportSviFilmovi.Size = new System.Drawing.Size(800, 450);
            this.reportSviFilmovi.TabIndex = 0;
            // 
            // SviFilmoviReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportSviFilmovi);
            this.Name = "SviFilmoviReportForm";
            this.Text = "Izvještaj svih filmova";
            this.Load += new System.EventHandler(this.SviFilmoviReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RezervacijaViewBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource RezervacijaViewBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportSviFilmovi;
    }
}