using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_proba1
{
    public partial class FormDodavanjeFilma : Form
    {
        private BindingList<Raspored_Prikazivanja> odabranaVremena = new BindingList<Raspored_Prikazivanja>();
        private Korisnik korisnik;
        public FormDodavanjeFilma(Korisnik user)
        {
            InitializeComponent();
            korisnik = user;
        }

        private void FormDodavanjeFilma_Load(object sender, EventArgs e)
        {
            lblKorisnickoIme.Text = korisnik.korisnicko_ime;
            FillCboxes();
            RefreshDGVvremena();
        }

        private void RefreshDGVvremena()
        {
            dgvVremena.DataSource = null;
            dgvVremena.DataSource = odabranaVremena;
            dgvVremena.Columns["Rezervacijas"].Visible = false;
            dgvVremena.Columns["Prikazivanjes"].Visible = false;
            dgvVremena.Columns["raspored_prikazivanja_id"].HeaderText = "Raspored ID";
            dgvVremena.Columns["vrijeme_prikazivanja"].HeaderText = "Vrijeme";
        }

        private void FillCboxes()
        {
            cboxDodajZanrFilma.DataSource = null;
            cboxDodajZanrFilma.DataSource = Funkcije.Dodavanje.FillCboxesZanr();
            cboxDodajDvoranu.DataSource = null;
            cboxDodajDvoranu.DataSource = Funkcije.Dodavanje.FillCboxesDvorana();
            cboxVrijemePrikazivanja.DataSource = null;
            cboxVrijemePrikazivanja.DataSource = Funkcije.Dodavanje.FillCboxesRaspored();
        }

        private void btnDodajVrijeme_Click(object sender, EventArgs e)
        {
            Raspored_Prikazivanja vrijeme = cboxVrijemePrikazivanja.SelectedItem as Raspored_Prikazivanja;
            if (!odabranaVremena.Contains(vrijeme))
            {
                odabranaVremena.Add(vrijeme);
            }
            RefreshDGVvremena();
        }

        private void btnCancelDodavanje_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDodajFilm_Click(object sender, EventArgs e)
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
                Funkcije.Dodavanje.DodajFilm(naslov, redatelj, opis, trajanje, cijena, kategorija, dvorana, odabranaVremena);
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
        private void btnObrisiVrijeme_Click(object sender, EventArgs e)
        {
            if(dgvVremena.CurrentRow != null)
            {
                Raspored_Prikazivanja brisanje = dgvVremena.CurrentRow.DataBoundItem as Raspored_Prikazivanja;
                odabranaVremena.Remove(brisanje);
            }
        }

        private void FormDodavanjeFilma_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            System.Windows.Forms.Help.ShowHelp(this, "CineManageHelp.chm", HelpNavigator.Topic, "Dodavanje.html");
        }
    }
}
