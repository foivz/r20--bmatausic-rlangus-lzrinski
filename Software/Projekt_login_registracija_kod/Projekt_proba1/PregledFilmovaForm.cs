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
    public partial class PregledFilmovaForm : Form
    {
        Korisnik ulogirani = null;
        public PregledFilmovaForm(Korisnik korisnik)
        {
            InitializeComponent();
            ulogirani = korisnik;
        }

        private void PregledFilmovaForm_Load(object sender, EventArgs e)
        {
            lblPrijevljen.Text = ulogirani.KorisnickoIme;
        }
    }
}
