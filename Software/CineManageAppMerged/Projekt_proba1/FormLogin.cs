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
        public FormLogin()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormStvaranjeKorisnika form = new FormStvaranjeKorisnika();
            form.ShowDialog();
            RefreshDGV();
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            try
            {
                string kime = txtKorisnickoIme.Text;
                string lozinka = txtLozinka.Text;
                Korisnik korisnik = DohvatiKorisnika(kime);
                txtKorisnickoIme.Text = "";
                txtLozinka.Text = "";
                if (korisnik != null)
                {
                    if (korisnik.lozinka == lozinka)
                    {
                        FormPregledFilmova frm = new FormPregledFilmova(korisnik);
                        this.Hide();
                        frm.ShowDialog();
                        this.Show();
                    }
                    else
                        MessageBox.Show("Kriva lozinka!");
                }
            }
            catch(Iznimke.LoginException ex)
            {
                MessageBox.Show(ex.Poruka);
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            RefreshDGV();
        }

        private void RefreshDGV()
        {
            using (var context = new CineManageEntities())
            {
                var query = from p in context.Korisniks.Include("Rola")
                            select p;
                dgvLista.DataSource = query.ToList();
                dgvLista.Columns["Rezervacijas"].Visible = false;
            }
        }

        private Korisnik DohvatiKorisnika(string kime)
        {
            Korisnik user;
            Rola role;
            using (var context = new CineManageEntities())
            {
                var query = from u in context.Korisniks
                            where u.korisnicko_ime == kime
                            select u;
                if (query.ToList().Count != 0)
                {
                    user = query.Single();
                    role = user.Rola;
                }
                else
                    throw new Iznimke.LoginException("Nepostojeći korisnik!");
            }
            return user;
        }

        private void btnNeregistrirani_Click(object sender, EventArgs e)
        {
            FormPregledFilmova frm = new FormPregledFilmova();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void btnSofty_Click(object sender, EventArgs e)
        {
            txtKorisnickoIme.Text = "softypaw";
            txtLozinka.Text = "lozinka1";
        }
    }
}
