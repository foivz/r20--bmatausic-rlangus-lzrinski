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
            using (var context = new CineManageEntities())
            {
                var queryKategorije = from k in context.Kategorijas
                                      select k;
                cboxDodajZanrFilma.DataSource = queryKategorije.ToList();

                var queryDvorane = from d in context.Dvoranas
                                   where d.popunjena_dvorana == 0
                                   select d;
                cboxDodajDvoranu.DataSource = queryDvorane.ToList();
                

                var queryVremena = from r in context.Raspored_Prikazivanja
                                   select r;
                cboxVrijemePrikazivanja.DataSource = queryVremena.ToList();
                                    
            }
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
            Dvorana dvorana = cboxDodajDvoranu.SelectedItem as Dvorana;
            Kategorija kategorija = cboxDodajZanrFilma.SelectedItem as Kategorija;
            using (var context = new CineManageEntities())
            {
                Film novi = new Film
                {
                    naslov = tboxDodajImeFilma.Text,
                    readtelj = tboxDodajRedateljFilma.Text,
                    opis = tboxDodajSadrzajFilma.Text,
                    trajanje = int.Parse(tboxDodajTrajanjeFilma.Text),
                    cijena = float.Parse(tboxDodajCijenuUlaznice.Text),
                    kategorija_kategorija_id = kategorija.kategorija_id,
                    dvorana_dvorana_id = dvorana.dvorana_id
                };
                context.Films.Add(novi);

                var queryDvorana = from d in context.Dvoranas
                                   where d.dvorana_id == dvorana.dvorana_id
                                   select d;
                Dvorana promjenjenaDvorana = queryDvorana.Single();
                promjenjenaDvorana.popunjena_dvorana = 1;

                foreach (Raspored_Prikazivanja r in odabranaVremena)
                {
                    Prikazivanje prikaz = new Prikazivanje
                    {
                        raspored_prikazivanja_idraspored_prikazivanja = r.raspored_prikazivanja_id,
                        film_film_id = novi.film_id
                    };
                    context.Prikazivanjes.Add(prikaz);
                    context.SaveChanges();
                }

                var querySjedala = from s in context.Sjedaloes
                                   where s.dvorana_dvorana_id == dvorana.dvorana_id
                                   select s;
                List<Sjedalo> sjedala = querySjedala.ToList();
                var queryPrikazivanja = from p in context.Prikazivanjes
                                        where p.film_film_id == novi.film_id
                                        select p;
                List<Prikazivanje> prikazivanja = queryPrikazivanja.ToList();
                foreach (Prikazivanje p in prikazivanja)
                {
                    foreach (Sjedalo s in sjedala)
                    {
                        Zauzetost_Sjedala zauzetost = new Zauzetost_Sjedala
                        {
                            zauzeto = 0,
                            prikazuje_se_prikazuje_se_id = p.prikazuje_se_id,
                            sjedala_sjedalo_id = s.sjedalo_id
                        };
                        context.Zauzetost_Sjedala.Add(zauzetost);
                    }

                }
                context.SaveChanges();
            }
            this.Close();
        }

        private void btnObrisiVrijeme_Click(object sender, EventArgs e)
        {
            if(dgvVremena.CurrentRow != null)
            {
                Raspored_Prikazivanja brisanje = dgvVremena.CurrentRow.DataBoundItem as Raspored_Prikazivanja;
                odabranaVremena.Remove(brisanje);
            }
        }
    }
}
