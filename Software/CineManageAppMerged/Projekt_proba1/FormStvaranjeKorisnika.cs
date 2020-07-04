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
                    DodajKorisnika(ime, prezime, kIme, lozinka, email);
                    MessageBox.Show("Korisnik " + kIme +" uspješno stvoren!");
                    Close();
                }
                else
                {
                    MessageBox.Show("Lozinka nije jednaka kao ponovljena lozinka!");
                }
            }
            catch (Iznimke.DodavanjeKorisnikaException ex)
            {
                MessageBox.Show(ex.Poruka);
            }
        }

        private void DodajKorisnika(string firstn, string lastn, string username, string pass, string mail)
        {
            bool provjera = ProvjeriPostojecegKorisnika(username);
            if (username == "")
            {
                throw new Iznimke.DodavanjeKorisnikaException("Korisnicko ime nesmije biti prazno polje");
            }
            else if (pass.Count() < 8)
            {
                throw new Iznimke.DodavanjeKorisnikaException("Lozinka mora imati najmanje 8 znakova");
            }
            else if (provjera == true)
            {
                throw new Iznimke.DodavanjeKorisnikaException("Korisnik već postoji!");
            }
            using (var context = new CineManageEntities())
            {
                var query = from r in context.Rolas
                            where r.ime_role == "Registrirani korisnik"
                            select r;
                Rola uloga = query.Single();

                Korisnik novi = new Korisnik
                {
                    ime = firstn,
                    prezime = lastn,
                    korisnicko_ime = username,
                    lozinka = pass,
                    email = mail,
                    Rola = uloga
                };
                context.Korisniks.Add(novi);
                context.SaveChanges();
            }
        }

        private bool ProvjeriPostojecegKorisnika(string kime)
        {
            using (var context = new CineManageEntities())
            {
                var query = from u in context.Korisniks
                            where u.korisnicko_ime == kime
                            select u;
                if (query.ToList().Count != 0)
                {
                    return true;
                }
                else
                    return false;
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
    }
}
