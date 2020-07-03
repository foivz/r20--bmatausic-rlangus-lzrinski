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
    public partial class FormRezervacijaUlaznica : Form
    {
        Korisnik korisnik;
        Film film;
        Raspored_Prikazivanja vrijeme;
        public FormRezervacijaUlaznica(Korisnik user, Film movie, Raspored_Prikazivanja time)
        {
            InitializeComponent();
            korisnik = user;
            film = movie;
            vrijeme = time;
        }

        private void FormRezervacijaUlaznica_Load(object sender, EventArgs e)
        {
            PopuniInfo();
            PopuniCboxBrojUlaznica();
            PopuniCboxSjedala();
        }

        private void PopuniCboxSjedala()
        {
            using (var contex = new CineManageEntities())
            {
                var query = from z in contex.Zauzetost_Sjedala
                            where z.Prikazivanje.raspored_prikazivanja_idraspored_prikazivanja == vrijeme.raspored_prikazivanja_id && z.Prikazivanje.Film.film_id == film.film_id && z.zauzeto == 0
                            select z.Sjedalo;
                cboxOdabirSjedala.DataSource = query.ToList();
            }
        }

        private void PopuniCboxBrojUlaznica()
        {
            List<int> ulaznice = new List<int>();
            for (int i = 1; i <= 20; i++)
            {
                ulaznice.Add(i);
            }
            cboxBrojUlaznica.DataSource = ulaznice;
        }

        private void PopuniInfo()
        {
            lblKorisnickoIme.Text = korisnik.korisnicko_ime;
            lblInfoFilm.Text = film.naslov;
            lblInfoDvoranaId.Text = film.dvorana_dvorana_id.ToString();
            lblInfoVrijemePrikaza.Text = vrijeme.vrijeme_prikazivanja.ToString();
            lblInfoCijena.Text = film.cijena.ToString() + " kn";
        }
    }
}
