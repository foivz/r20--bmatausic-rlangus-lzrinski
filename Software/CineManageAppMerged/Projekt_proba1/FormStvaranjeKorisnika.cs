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
    public partial class FormStvaranjeKorisnika : Form
    {
        public FormStvaranjeKorisnika()
        {
            InitializeComponent();
        }

        private void btnStvori_Click(object sender, EventArgs e)
        {
            try
            {
                string ime = txtIme.Text;
                string prezime = txtPrezime.Text;
                string kIme = txtKorisnickoImeStvaranje.Text;
                string lozinka = txtLozinkaStvaranje.Text;
                string provjera_loz = txtPonoviLozinku.Text;
                string email = txtEmail.Text;
                if (provjera_loz == lozinka)
                {
                    Funkcije.Registracija.DodajKorisnika(ime, prezime, kIme, lozinka, email);
                    MessageBox.Show("Korisnik " + kIme +" uspješno stvoren!");
                    Close();
                }
                else
                {
                    throw new Iznimke.DodavanjeKorisnikaException("Lozinka nije jednaka kao ponovljena lozinka!");
                }
            }
            catch (Iznimke.DodavanjeKorisnikaException ex)
            {
                MessageBox.Show(ex.Poruka);
            }
        }
        private void txtLozinkaStvaranje_TextChanged(object sender, EventArgs e)
        {
            if (txtLozinkaStvaranje.Text.Count() < 8)
            {
                lblLozinka.Text = "Lozinka premala!";
                lblLozinka.ForeColor = Color.Red;
            }
            else
            {
                lblLozinka.Text = "Lozinka prihvatljiva!";
                lblLozinka.ForeColor = Color.Green;
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormStvaranjeKorisnika_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            System.Windows.Forms.Help.ShowHelp(this, "CineManageHelp.chm", HelpNavigator.Topic, "Registracija.html");
        }
    }
}
