using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_proba1
{
    public partial class FormObracun : Form
    {
        public FormObracun()
        {
            InitializeComponent();
        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            FormLogin frmLogin = new FormLogin();
            this.Close();
            this.Hide();
            frmLogin.ShowDialog();
            this.Show();
        }

        private void btnPrikaziGraf_Click(object sender, EventArgs e)
        {
            this.Close();
            FormIzvjesceGraf frmIzvjesceGraf = new FormIzvjesceGraf();
            this.Hide();
            frmIzvjesceGraf.ShowDialog();
            this.Show();
        }
    }
}
