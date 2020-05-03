using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_proba1
{
    public partial class FormLogin : Form
    {
        FunkcijeLoginRegistracija funk = new FunkcijeLoginRegistracija();
        public FormLogin()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormStvaranjeKorisnika stvori = new FormStvaranjeKorisnika();
            stvori.ShowDialog();
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            string kIme = txtKorisnickoIme.Text;
            string lozinka = txtLozinka.Text;
            int provjera = funk.ProvjeriPodatke(kIme, lozinka);
            if(provjera == 0)
            {
                MessageBox.Show("Nepostojeći korisnik");
            }
            else if(provjera == 1)
            {
                MessageBox.Show("Pogrešna lozinka");
            }
            else
            {
                Korisnik loginKorisnik = funk.DohvatiKorisnika(kIme);
                PregledFilmovaForm pregled = new PregledFilmovaForm(loginKorisnik);
                pregled.ShowDialog();
                Hide();
            }
        }
    }
}
