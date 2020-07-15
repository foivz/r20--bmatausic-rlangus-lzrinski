using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_proba1
{
    public partial class FormAzuriranjeFilma : Form
    {
        private Film film;
        private Korisnik korisnik;
        private BindingList<Raspored_Prikazivanja> odabranaVremena = new BindingList<Raspored_Prikazivanja>();
        private List<Raspored_Prikazivanja> odabranaVremenaBaza = new List<Raspored_Prikazivanja>();
        public FormAzuriranjeFilma(Film odabrani, Korisnik user)
        {
            InitializeComponent();
            film = odabrani;
            korisnik = user;
        }
        private void FormAzuriranjeFilma_Load(object sender, EventArgs e)
        {
            FillCboxes();
            DohvatiVremena();
            RefreshVremena();
            FillFilmInfo();
        }

        private void DohvatiVremena()
        {
            using (var context = new CineManageEntities())
            {
                var query = from p in context.Prikazivanjes
                            where p.film_film_id == film.film_id
                            select p.Raspored_Prikazivanja;
                odabranaVremenaBaza = query.ToList();
                foreach (Raspored_Prikazivanja r in odabranaVremenaBaza)
                {
                    odabranaVremena.Add(r);
                }
            }
        }

        private void RefreshVremena()
        {
            dgvVremena.DataSource = odabranaVremena;
            dgvVremena.Columns["Prikazivanjes"].Visible = false;
            dgvVremena.Columns["Rezervacijas"].Visible = false;
        }

        private void FillCboxes()
        {
            using (var context = new CineManageEntities())
            {
                context.Films.Attach(film);
                var queryKategorije = from k in context.Kategorijas
                                      select k;
                cboxDodajZanrFilma.DataSource = queryKategorije.ToList();
                cboxDodajZanrFilma.SelectedItem = film.Kategorija;


                var queryDvorane = from d in context.Dvoranas
                                   where d.popunjena_dvorana == 0 || d.dvorana_id == film.dvorana_dvorana_id
                                   select d;
                cboxDodajDvoranu.DataSource = queryDvorane.ToList();
                cboxDodajDvoranu.SelectedItem = film.Dvorana;

                var querySvaVremena = from r in context.Raspored_Prikazivanja
                                      select r;
                cboxVrijemePrikazivanja.DataSource = querySvaVremena.ToList();
            }
        }

        private void FillFilmInfo()
        {
            lblKorisnickoIme.Text = korisnik.korisnicko_ime;
            tboxDodajImeFilma.Text = film.naslov;
            tboxDodajRedateljFilma.Text = film.readtelj;
            tboxDodajSadrzajFilma.Text = film.opis;
            tboxDodajTrajanjeFilma.Text = film.trajanje.ToString();
            tboxDodajCijenuUlaznice.Text = film.cijena.ToString();
        }

        private void btnDodajVrijeme_Click(object sender, EventArgs e)
        {
            Raspored_Prikazivanja vrijeme = cboxVrijemePrikazivanja.SelectedItem as Raspored_Prikazivanja;
            bool postoji = false;
            foreach (Raspored_Prikazivanja ras in odabranaVremena)
            {
                if(ras.raspored_prikazivanja_id == vrijeme.raspored_prikazivanja_id)
                {
                    postoji = true;
                }
            }
            if(postoji == false)
            {
                odabranaVremena.Add(vrijeme);
            }
            RefreshVremena();
        }

        private void btnAzurirajjFilm_Click(object sender, EventArgs e)
        {
            try
            {
                Dvorana dvorana = cboxDodajDvoranu.SelectedItem as Dvorana;
                Kategorija kategorija = cboxDodajZanrFilma.SelectedItem as Kategorija;
                string naslov = tboxDodajImeFilma.Text;
                string redatelj = tboxDodajRedateljFilma.Text;
                string opis = tboxDodajSadrzajFilma.Text;
                int trajanje = int.Parse(tboxDodajTrajanjeFilma.Text);
                double cijena = float.Parse(tboxDodajCijenuUlaznice.Text);
                if (tboxDodajImeFilma.Text == "" || tboxDodajRedateljFilma.Text == "" || tboxDodajSadrzajFilma.Text == "" || tboxDodajTrajanjeFilma.Text == "" || tboxDodajCijenuUlaznice.Text == "" || odabranaVremena.Count == 0)
                {
                    throw new Iznimke.InformacijeFilmaException("Nisu popunjene sve vrijednosti!");
                }
                Funkcije.AzuriranjeFunk.AzurirajFilm(film, dvorana, kategorija, naslov, redatelj, opis, trajanje, cijena, odabranaVremena, odabranaVremenaBaza);
                this.Close();
            }
            catch (Iznimke.InformacijeFilmaException ex)
            {
                MessageBox.Show(ex.Poruka);
            }
            catch (FormatException)
            {
                MessageBox.Show("Pogrešni format unosa kod trajanja filma ili cijene ulaznice!");
            }
        }

        private void btnCancelDodavanje_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormAzuriranjeFilma_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            System.Windows.Forms.Help.ShowHelp(this, "CineManageHelp.chm", HelpNavigator.Topic, "Azuriranje.html");
        }
    }
}
