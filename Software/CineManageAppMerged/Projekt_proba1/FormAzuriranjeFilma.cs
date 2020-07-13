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
                dgvVremena.DataSource = odabranaVremena;
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
            if (!odabranaVremena.Contains(vrijeme))
            {
                odabranaVremena.Add(vrijeme);
            }
            RefreshVremena();
        }

        private void btnAzurirajjFilm_Click(object sender, EventArgs e)
        {
            Dvorana dvorana = cboxDodajDvoranu.SelectedItem as Dvorana;
            Kategorija kategorija = cboxDodajZanrFilma.SelectedItem as Kategorija;
            try
            {
                using (var context = new CineManageEntities())
                {
                    if (tboxDodajImeFilma.Text == "" || tboxDodajRedateljFilma.Text == "" || tboxDodajSadrzajFilma.Text == "" || tboxDodajTrajanjeFilma.Text == "" || tboxDodajCijenuUlaznice.Text == "" || odabranaVremena.Count == 0)
                    {
                        throw new Iznimke.InformacijeFilmaException("Nisu popunjene sve vrijednosti!");
                    }
                    context.Films.Attach(film);
                    //ako je odabrana dvorana različita od dvorane filma u bazi, postavi dvoranu filma u bazi da je nepopunjena
                    if (film.Dvorana.dvorana_id != dvorana.dvorana_id)
                    {
                        film.Dvorana.popunjena_dvorana = 0;
                        context.SaveChanges();
                    }
                    //popuni podatke filma u bazi i popuni dvoranu u kojoj se prikazuej film
                    film.naslov = tboxDodajImeFilma.Text;
                    film.readtelj = tboxDodajRedateljFilma.Text;
                    film.opis = tboxDodajSadrzajFilma.Text;
                    film.trajanje = int.Parse(tboxDodajTrajanjeFilma.Text);
                    film.cijena = double.Parse(tboxDodajCijenuUlaznice.Text);
                    context.Dvoranas.Attach(dvorana);
                    film.Dvorana = dvorana;
                    context.Kategorijas.Attach(kategorija);
                    film.Kategorija = kategorija;
                    film.Dvorana.popunjena_dvorana = 1;

                    var queryRasporedi = from p in context.Prikazivanjes
                                         where p.film_film_id == film.film_id
                                         select p.Raspored_Prikazivanja;
                    List<Raspored_Prikazivanja> rasporediFilma = queryRasporedi.ToList();
                    foreach (Raspored_Prikazivanja r in odabranaVremena)
                    {
                        if (!odabranaVremenaBaza.Contains(r))
                        {
                            Prikazivanje novo = new Prikazivanje
                            {
                                raspored_prikazivanja_idraspored_prikazivanja = r.raspored_prikazivanja_id,
                                film_film_id = film.film_id
                            };
                            context.Prikazivanjes.Add(novo);
                            context.SaveChanges();
                        }
                    }
                    var queryPrikazivanjaTablica = from p in context.Prikazivanjes
                                                   where p.film_film_id == film.film_id
                                                   select p;
                    List<Prikazivanje> prikazivanjaTablica = queryPrikazivanjaTablica.ToList();
                    var queryPrikazivanjeBaza = from z in context.Zauzetost_Sjedala
                                                where z.Prikazivanje.film_film_id == film.film_id
                                                select z.Prikazivanje;
                    List<Prikazivanje> prikazivanjaBaza = queryPrikazivanjeBaza.ToList();
                    var querySjedala = from s in context.Sjedaloes
                                       where s.dvorana_dvorana_id == dvorana.dvorana_id
                                       select s;
                    List<Sjedalo> sjedala = querySjedala.ToList();
                    foreach (Prikazivanje p in prikazivanjaTablica)
                    {
                        if (!prikazivanjaBaza.Contains(p))
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
                                context.SaveChanges();
                            }
                        }
                    }
                }
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
    }
}
