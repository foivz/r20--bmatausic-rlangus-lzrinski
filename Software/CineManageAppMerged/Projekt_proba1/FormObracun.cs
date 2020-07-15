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
        private void FormObracun_Load(object sender, EventArgs e)
        {
            RefreshObracunZarada();
            FillCboxFilterFilm();
            UkupnaZaradaOdUlaznica();
            UkupnoProdanihUlaznica();
            lblKorisnickoIme.Text = korisnik.korisnicko_ime;
        }

        private void UkupnoProdanihUlaznica()
        {
            lblUkUlaznice.Text = Funkcije.Obracun.UkupnoProdanihUlaznica().ToString();
        }

        private void UkupnaZaradaOdUlaznica()
        {
            lblSumaUlaznice.Text = Funkcije.Obracun.UkupnaZaradaOdUlaznica().ToString();
        }

        private void RefreshObracunZarada()
        {
            dgvZaradaOdUlaznica.DataSource = Funkcije.Obracun.DohvatiRezervacijeSve();
            dgvZaradaOdUlaznica.Columns["ID_rezervacije"].HeaderText = "ID rezervacije";
            dgvZaradaOdUlaznica.Columns["Ime_Filma"].HeaderText = "Naslov filma";
            dgvZaradaOdUlaznica.Columns["Cijena_filma"].HeaderText = "Cijena";
            dgvZaradaOdUlaznica.Columns["Vrijeme_Prikazivanja"].HeaderText = "Datum i vrijeme prikazivanja";
        }
        private void FillCboxFilterFilm()
        {
            cboxFilterUlazniceFilm.DataSource = Funkcije.Obracun.DohvatiFilmove();
            cboxFilterZaradaFilm.DataSource = Funkcije.Obracun.DohvatiFilmove();
        }
        private void cboxFilterZaradaFilm_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Film nazivFilma = cboxFilterZaradaFilm.SelectedItem as Film;
            FilterImenaFilmova(nazivFilma.naslov);
            UkupnaZaradaOdUlaznicaFilter(nazivFilma.naslov);
        }
        
        private void FilterImenaFilmova(string nazivFilma)
        {
            dgvZaradaOdUlaznica.DataSource = Funkcije.Obracun.DohvatiRezervacijeFilm(nazivFilma);
            dgvZaradaOdUlaznica.Columns["ID_rezervacije"].HeaderText = "ID rezervacije";
            dgvZaradaOdUlaznica.Columns["Ime_Filma"].HeaderText = "Naslov filma";
            dgvZaradaOdUlaznica.Columns["Cijena_filma"].HeaderText = "Cijena";
            dgvZaradaOdUlaznica.Columns["Vrijeme_Prikazivanja"].HeaderText = "Datum i vrijeme prikazivanja";
        }

        private void UkupnaZaradaOdUlaznicaFilter(string nazivFilma)
        {
            List<RezervacijaView> rezervacijeFilm = Funkcije.Obracun.DohvatiRezervacijeFilm(nazivFilma);
            double ukupnaZarada = 0;
            foreach (RezervacijaView rez in rezervacijeFilm)
            {
                ukupnaZarada += rez.Cijena_filma;
            }
            lblSumaUlaznice.Text = ukupnaZarada.ToString();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void cboxFilterUlazniceFilm_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Film odabrani = cboxFilterUlazniceFilm.SelectedItem as Film;
            List<RezervacijaView> rezervacije = Funkcije.Obracun.DohvatiRezervacijeFilm(odabrani.naslov);
            lblUkUlaznice.Text = rezervacije.Count().ToString();
            lblNazivProdano.Text = odabrani.naslov;
        }

        private void btnIzradiIzvjestaj_Click(object sender, EventArgs e)
        {
            SviFilmoviReportForm form = new SviFilmoviReportForm();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void FormObracun_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            System.Windows.Forms.Help.ShowHelp(this, "CineManageHelp.chm", HelpNavigator.Topic, "Poslovanje.html");
        }

        private void btnBezFilteraZarada_Click(object sender, EventArgs e)
        {
            RefreshObracunZarada();
            UkupnaZaradaOdUlaznica();
        }

        private void btnBezFilteraProdaja_Click(object sender, EventArgs e)
        {
            lblNazivProdano.Text = "Ukupno prodanih ulaznica: ";
            UkupnoProdanihUlaznica();
        }
    }
}
