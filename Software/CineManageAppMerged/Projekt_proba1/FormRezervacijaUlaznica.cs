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
            for (int i = 1; i <= 5; i++)
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

        private void cboxBrojUlaznica_TextChanged(object sender, EventArgs e)
        {
            int brojacUlaznica = Int32.Parse(cboxBrojUlaznica.Text);
            double cijenaSuma = film.cijena * Int32.Parse(cboxBrojUlaznica.Text);
            lblInfoSuma.Text = cijenaSuma.ToString() + " kn";
            /* implementacija više ulaznica
             * 
             * gboxSjedala.Controls.Clear();   

            for (int i = 0; i < brojacUlaznica-1; i++)
            {
                Label t1 = new Label();
                this.Controls.Add(t1);
                t1.Top = 470 + (i*25);
                t1.Left = 270;
                t1.Text = "Odaverite sjedalo: ${i} ";
                t1.BringToFront();


            }*/
        }
    }
}
