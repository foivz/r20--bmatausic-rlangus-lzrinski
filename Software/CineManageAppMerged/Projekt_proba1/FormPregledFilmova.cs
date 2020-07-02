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
    public partial class FormPregledFilmova : Form
    {
        Korisnik korisnik;
        public FormPregledFilmova(Korisnik user)
        {
            InitializeComponent();
            korisnik = user;
        }
        public FormPregledFilmova()
        {
            InitializeComponent();
        }


        private void FormPregledFilmova_Load(object sender, EventArgs e)
        {
            RefreshFilmovi();
            FillCbox();
            if (korisnik == null)
            {
                lblKorisnickoIme.Text = "Guest";
            }
            else
            {
                lblKorisnickoIme.Text = korisnik.korisnicko_ime;
                if(korisnik.rola_id == 1)
                {
                    gboxUrediFilmove.Visible = true;
                    btnPrikazPosovanja.Visible = true;
                }
            }
        }

        private void FillCbox()
        {
            using (var context = new CineManageEntities())
            {
                var query = from k in context.Kategorijas
                            orderby k.kategorija_ime
                            select k;
                List<Kategorija> kategorije = query.ToList();
                List<string> naziviKategorija = new List<string>();
                foreach ( Kategorija k in kategorije)
                {
                    naziviKategorija.Add(k.kategorija_ime);
                }
                cboxKategorije.DataSource = naziviKategorija;
            }
        }

        private void RefreshFilmovi()
        {
            using (var context = new CineManageEntities())
            {
                var query = from f in context.Films
                            select new FilmView
                            {
                               film_id= f.film_id,
                               naslov = f.naslov,
                               redatelj = f.readtelj,
                               dvorana = f.Dvorana.ime_dvorane,
                               kategorija = f.Kategorija.kategorija_ime
                            }; 

                dgvFilmovi.DataSource = query.ToList();
            }
        }

        private void btnFilterDatum_Click(object sender, EventArgs e)
        {
            DateTime date = dtPickerDatum.Value;
            DohvatiFilmoveDatum(date);
        }

        private void DohvatiFilmoveDatum(DateTime date)
        {
            using (var context = new CineManageEntities())
            {
                var query = from p in context.Prikazivanjes
                            where p.Raspored_Prikazivanja.vrijeme_prikazivanja == date
                            select new FilmView
                            {
                                film_id = p.Film.film_id,
                                naslov = p.Film.naslov,
                                redatelj = p.Film.readtelj,
                                dvorana = p.Film.Dvorana.ime_dvorane,
                                kategorija = p.Film.Kategorija.kategorija_ime
                            }; ;
                dgvFilmovi.DataSource = query.ToList();
            }
        }

        private void btnPocetniPrikaz_Click(object sender, EventArgs e)
        {
            RefreshFilmovi();
            txtNazivFilter.Text = "";
            cboxKategorije.SelectedIndex = 0;
        }

        private void btnFilterNaziv_Click(object sender, EventArgs e)
        {
            string naziv = txtNazivFilter.Text;
            DohvatiFilmoveNaziv(naziv);
        }

        private void DohvatiFilmoveNaziv(string filter)
        {
            using (var context = new CineManageEntities())
            {
                var query = from p in context.Prikazivanjes
                            where p.Film.naslov.Contains(filter) || p.Film.readtelj.Contains(filter)
                            select new FilmView
                            {
                                film_id = p.Film.film_id,
                                naslov = p.Film.naslov,
                                redatelj = p.Film.readtelj,
                                dvorana = p.Film.Dvorana.ime_dvorane,
                                kategorija = p.Film.Kategorija.kategorija_ime
                            };
                dgvFilmovi.DataSource = query.Distinct().ToList();
            }
        }

        private void btnFilterKategorija_Click(object sender, EventArgs e)
        {
            string kategorija = cboxKategorije.SelectedItem as string;
            DohvatiFilmoveKategorija(kategorija);
        }

        private void DohvatiFilmoveKategorija(string kategorija)
        {
            using (var context = new CineManageEntities())
            {
                var query = from p in context.Prikazivanjes
                            where p.Film.Kategorija.kategorija_ime == kategorija
                            select new FilmView
                            {
                                film_id = p.Film.film_id,
                                naslov = p.Film.naslov,
                                redatelj = p.Film.readtelj,
                                dvorana = p.Film.Dvorana.ime_dvorane,
                                kategorija = p.Film.Kategorija.kategorija_ime
                            };
                dgvFilmovi.DataSource = query.Distinct().ToList();
            }
        }
    }
}
