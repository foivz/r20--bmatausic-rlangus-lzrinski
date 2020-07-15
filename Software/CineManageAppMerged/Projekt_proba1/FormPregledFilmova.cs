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
                btnOdjava.Visible = false;
            }
            else
            {
                btnPrijava.Visible = false;
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
            cboxKategorije.DataSource = null;
            cboxKategorije.DataSource = Funkcije.PregledFilmova.DohvatiKategorije();
        }

        private void RefreshFilmovi()
        {
            dgvFilmovi.DataSource = null;
            dgvFilmovi.DataSource = Funkcije.PregledFilmova.DohvatiFilmove();
        }

        private void btnFilterDatum_Click(object sender, EventArgs e)
        {
            DateTime date = dtPickerDatum.Value;
            dgvFilmovi.DataSource = null;
            dgvFilmovi.DataSource = Funkcije.PregledFilmova.DohvatiFilmoveDatum(date);
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
            dgvFilmovi.DataSource = null;
            dgvFilmovi.DataSource = Funkcije.PregledFilmova.DohvatiFilmoveNaziv(naziv);
        }
        private void btnFilterKategorija_Click(object sender, EventArgs e)
        {
            string kategorija = cboxKategorije.SelectedItem as string;
            dgvFilmovi.DataSource = null;
            dgvFilmovi.DataSource = Funkcije.PregledFilmova.DohvatiFilmoveKategorija(kategorija);
        }
        private void btnOdaberiFilm_Click(object sender, EventArgs e)
        {
            FilmView odabrani = dgvFilmovi.CurrentRow.DataBoundItem as FilmView;
            Film odabraniFilm;
            using (var context = new CineManageEntities())
            {
                var query = from f in context.Films
                            where f.film_id == odabrani.film_id
                            select f;
                odabraniFilm = query.Single();
            }
            if (korisnik != null)
            {
                FormInformacijeFilm frm = new FormInformacijeFilm(odabraniFilm, korisnik);
                this.Hide();
                frm.ShowDialog();
                this.Show();
            }
            else
            {
                FormInformacijeFilm frm = new FormInformacijeFilm(odabraniFilm);
                this.Hide();
                frm.ShowDialog();
                this.Show();
            }
        }
        private void btnOdjava_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnPrijava_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnDodajNoviFilm_Click(object sender, EventArgs e)
        {
            using (var context = new CineManageEntities())
            {
                var queryDvorane = from d in context.Dvoranas
                                   where d.popunjena_dvorana == 0
                                   select d;
                List<Dvorana> dvorane = queryDvorane.ToList();

                //ako su sve dvorane popunjene nemoze se dodavati film
                if (dvorane.Count() != 0)
                {
                    FormDodavanjeFilma frmDodavanjeFilma = new FormDodavanjeFilma(korisnik);
                    this.Hide();
                    frmDodavanjeFilma.ShowDialog();
                    this.Show();
                    RefreshFilmovi();
                }
                else
                    MessageBox.Show("Nema slobodnih dvorana!");
            }
        }
        private void btnObrisi_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Potvrdite brisanje", "Jeste li sigurni da želite obrisati film?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                FilmView odabrani = dgvFilmovi.CurrentRow.DataBoundItem as FilmView;
                Funkcije.PregledFilmova.ObrisiFilm(odabrani.film_id);
                RefreshFilmovi();
            }
        }
        private void btnAzurirajFilm_Click(object sender, EventArgs e)
        {
            if (dgvFilmovi.CurrentRow != null)
            {
                FilmView odabraniFilm = dgvFilmovi.CurrentRow.DataBoundItem as FilmView;
                Film film;
                using (var context = new CineManageEntities())
                {
                    var query = from f in context.Films
                                where f.film_id == odabraniFilm.film_id
                                select f;
                    film = query.Single();
                }
                FormAzuriranjeFilma frmAzuriranjeFilma = new FormAzuriranjeFilma(film, korisnik);
                this.Hide();
                frmAzuriranjeFilma.ShowDialog();
                this.Show();
                RefreshFilmovi();
            }
            else
                MessageBox.Show("Odaberite film za ažuriranje!");
        }
        private void btnPrikazPosovanja_Click(object sender, EventArgs e)
        {
            FormObracun frmObracun = new FormObracun(korisnik);
            this.Hide();
            frmObracun.ShowDialog();
            this.Show();
        }
        private void FormPregledFilmova_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            System.Windows.Forms.Help.ShowHelp(this, "CineManageHelp.chm", HelpNavigator.Topic, "Pregled.html");
        }
    }
}
