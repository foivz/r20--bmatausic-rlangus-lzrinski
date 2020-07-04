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
    public partial class FormIzvjesceGraf : Form
    {
        public FormIzvjesceGraf()
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
    }
}
