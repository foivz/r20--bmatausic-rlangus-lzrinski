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
    public partial class FormObracun : Form
    {
        Korisnik korisnik;
        public FormObracun(Korisnik user)
        {
            InitializeComponent();
            korisnik = user;
        }
        public FormObracun()
        {
            InitializeComponent();
        }
        private void FormObracun_Load(object sender, EventArgs e)
        {
            RefreshObracunZarada();
            FillCboxFilterFilm();
            UkupnaZaradaOdUlaznica();
            UkupnoProdanihUlaznica();

            if (korisnik == null)
            {
                lblKorisnickoIme.Text = "Guest";
            }
            else
            {
                lblKorisnickoIme.Text = korisnik.korisnicko_ime;
            }
        }

        private void UkupnoProdanihUlaznica()
        {
            using (var context = new CineManageEntities())
            {
                var query = from r in context.Rezervacijas
                            select r.rezervacija_id;
                int ukupnoProdanihUlaznica = query.Count();
                lblUkUlaznice.Text = ukupnoProdanihUlaznica.ToString();

            }
        }

        private void UkupnaZaradaOdUlaznica()
        {
            using (var context = new CineManageEntities())
            {
                var query = from r in context.Rezervacijas.Include("Film").Include("Raspored_Prikazivanja")
                            select r.Film.cijena;
                double ukupnaZarada = query.Sum();
                lblSumaUlaznice.Text = ukupnaZarada.ToString();

            }
        }

        private void RefreshObracunZarada()
        {
            using (var context = new CineManageEntities())
            {
                var query = from r in context.Rezervacijas.Include("Film").Include("Raspored_Prikazivanja")
                            select new RezervacijaView
                            {
                                ID_rezervacije = r.rezervacija_id,
                                Ime_Filma = r.Film.naslov,
                                Cijena_filma = r.Film.cijena,
                                Vrijeme_Prikazivanja = r.Raspored_Prikazivanja.vrijeme_prikazivanja
                            };

                dgvZaradaOdUlaznica.DataSource = query.ToList();
                dgvZaradaOdUlaznica.Columns["ID_rezervacije"].HeaderText = "ID rezervacije";
                dgvZaradaOdUlaznica.Columns["Ime_Filma"].HeaderText = "Naslov filma";
                dgvZaradaOdUlaznica.Columns["Cijena_filma"].HeaderText = "Cijena";
                dgvZaradaOdUlaznica.Columns["Vrijeme_Prikazivanja"].HeaderText = "Datum i vrijeme prikazivanja";
            }
        }
        private void FillCboxFilterFilm()
        {
            using (var context = new CineManageEntities())
            {
                var query = from f in context.Films
                            orderby f.naslov
                            select f;
                cboxFilterZaradaFilm.DataSource = query.ToList(); ;
                cboxFilterUlazniceFilm.DataSource = query.ToList();
                cboxFilmIzvjestaj.DataSource = query.ToList();
            }
        }
        private void cboxFilterZaradaFilm_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Film nazivFilma = cboxFilterZaradaFilm.SelectedItem as Film;
            FilterImenaFilmova(nazivFilma.naslov);
            UkupnaZaradaOdUlaznicaFilter(nazivFilma.naslov);
        }
        
        private void FilterImenaFilmova(string nazivFilma)
        {
            using (var context = new CineManageEntities())
            {
                var query = from r in context.Rezervacijas
                            where r.Film.naslov == nazivFilma
                            select new RezervacijaView
                            {
                                ID_rezervacije = r.rezervacija_id,
                                Ime_Filma = r.Film.naslov,
                                Cijena_filma = r.Film.cijena,
                                Vrijeme_Prikazivanja = r.Raspored_Prikazivanja.vrijeme_prikazivanja
                            };
                dgvZaradaOdUlaznica.DataSource = query.ToList();
                dgvZaradaOdUlaznica.Columns["ID_rezervacije"].HeaderText = "ID rezervacije";
                dgvZaradaOdUlaznica.Columns["Ime_Filma"].HeaderText = "Naslov filma";
                dgvZaradaOdUlaznica.Columns["Cijena_filma"].HeaderText = "Cijena";
                dgvZaradaOdUlaznica.Columns["Vrijeme_Prikazivanja"].HeaderText = "Datum i vrijeme prikazivanja";
            }
        }

        private void UkupnaZaradaOdUlaznicaFilter(string nazivFilma)
        {
            using (var context = new CineManageEntities())
            {
                var query = from r in context.Rezervacijas
                            where r.Film.naslov == nazivFilma
                            select r.Film.cijena;
                double ukupnaZarada = query.Sum();
                lblSumaUlaznice.Text = ukupnaZarada.ToString();

            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void cboxFilterUlazniceFilm_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Film odabrani = cboxFilterUlazniceFilm.SelectedItem as Film;
            using (var context = new CineManageEntities())
            {
                var query = from r in context.Rezervacijas
                            where r.Film.film_id == odabrani.film_id
                            select r;
                List<Rezervacija> rezervacijaFilm = query.ToList();
                lblUkUlaznice.Text = rezervacijaFilm.Count().ToString();
                lblNazivProdano.Text = odabrani.naslov;
            }
        }

        private void btnIzradiIzvjestaj_Click(object sender, EventArgs e)
        {
            SviFilmoviReportForm form = new SviFilmoviReportForm();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void btnIzradiIzvjestajFilm_Click(object sender, EventArgs e)
        {
            Film odabrani = cboxFilmIzvjestaj.SelectedItem as Film;
            OdabraniFilmReportForm form = new OdabraniFilmReportForm(odabrani.film_id);
            this.Hide();
            form.ShowDialog();
            this.Show();
        }
    }
}
