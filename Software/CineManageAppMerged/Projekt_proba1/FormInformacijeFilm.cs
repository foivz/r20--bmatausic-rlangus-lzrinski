using Projekt_proba1.Iznimke;
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
    public partial class FormInformacijeFilm : Form
    {
        private Film film;
        private Korisnik korisnik;

        public FormInformacijeFilm(Film odabrani, Korisnik user)
        {
            InitializeComponent();
            film = odabrani;
            korisnik = user;
        }
        public FormInformacijeFilm(Film odabrani)
        {
            InitializeComponent();
            film = odabrani;
        }

        private void FormInformacijeFilm_Load(object sender, EventArgs e)
        {
            if (korisnik != null)
            {
                lblKorisnickoIme.Text = korisnik.korisnicko_ime;
            }
            else
            {
                lblKorisnickoIme.Text = "Guest";
            }
            lblFilmIme.Text = film.naslov;
            lblRedateljFilma.Text = film.readtelj;
            txtSadrzaj.Text = film.opis;
            lblDvoranaId.Text = film.dvorana_dvorana_id.ToString();
            FillcboxVrijeme();
        }

        private void FillcboxVrijeme()
        {
            using (var context = new CineManageEntities())
            {
                var query = from p in context.Prikazivanjes
                            where film.film_id == p.film_film_id
                            select p.Raspored_Prikazivanja;
                cboxVrijeme.DataSource = query.ToList();
            }
        }

        private void btnRezervirajKartu_Click(object sender, EventArgs e)
        {
            try
            {
                Raspored_Prikazivanja vrijeme = cboxVrijeme.SelectedItem as Raspored_Prikazivanja;
                if(korisnik == null)
                {
                    throw new NeregistriraniKorisnikException("Kako biste mogli koristiti ovu funkcionalnost, morate se ulogirati!");
                }
                FormRezervacijaUlaznica form = new FormRezervacijaUlaznica(korisnik, film, vrijeme);
                this.Hide();
                form.ShowDialog();
                this.Show();
            }
            catch (Iznimke.NeregistriraniKorisnikException ex)
            {
                MessageBox.Show(ex.Poruka);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
