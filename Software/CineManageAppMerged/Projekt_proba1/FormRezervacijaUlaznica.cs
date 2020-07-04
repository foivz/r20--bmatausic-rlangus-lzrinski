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
        private Korisnik korisnik;
        private Film film;
        private Raspored_Prikazivanja vrijeme;
        private BindingList<Sjedalo> sjedala = new BindingList<Sjedalo>();
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
            PopuniCboxSjedala();
            RefreshDGV();
            RefreshDGVrezervacije();
        }

        private void RefreshDGVrezervacije()
        {
            using (var context = new CineManageEntities())
            {
                var query = from r in context.Rezervacijas.Include("Film").Include("Korisnik").Include("Raspored_Prikazivanja").Include("Sjedalo")
                            select r;
                dgvRezervacije.DataSource = query.ToList();
                dgvRezervacije.Columns["film_film_id"].Visible = false;
                dgvRezervacije.Columns["sjedala_sjedalo_id"].Visible = false;
                dgvRezervacije.Columns["korisnik_korisnik_id"].Visible = false;
                dgvRezervacije.Columns["raspored_prikazivanja_raspored_prikazivanja_id"].Visible = false;
            }
        }

        private void PopuniCboxSjedala()
        {
            using (var contex = new CineManageEntities())
            {
                var query = from z in contex.Zauzetost_Sjedala
                            where z.Prikazivanje.raspored_prikazivanja_idraspored_prikazivanja == vrijeme.raspored_prikazivanja_id && z.Prikazivanje.Film.film_id == film.film_id && z.zauzeto == 0
                            select z.Sjedalo;
                cboxOdabirSjedala.DataSource = query.ToList();
                int brUlaznica = cboxOdabirSjedala.Items.Count;
                List<int> ulaznice = new List<int>();
                for (int i = 1; i <= brUlaznica; i++)
                {
                    ulaznice.Add(i);
                }
                cboxBrojUlaznica.DataSource = ulaznice;
            }
        }

        private void PopuniInfo()
        {
            lblKorisnickoIme.Text = korisnik.korisnicko_ime;
            lblInfoFilm.Text = film.naslov;
            lblInfoDvoranaId.Text = film.dvorana_dvorana_id.ToString();
            lblInfoVrijemePrikaza.Text = vrijeme.vrijeme_prikazivanja.ToString();
            lblInfoCijena.Text = film.cijena.ToString() + " kn";
            lblInfoSuma.Text = "0 kn";
        }

        private void RefreshDGV()
        {
            dgvOdabranaSjedala.DataSource = null;
            dgvOdabranaSjedala.DataSource = sjedala;
            dgvOdabranaSjedala.Columns["Dvorana"].Visible = false;
            dgvOdabranaSjedala.Columns["Rezervacijas"].Visible = false;
            dgvOdabranaSjedala.Columns["Zauzetost_Sjedala"].Visible = false;

        }

        private void btnOdaberi_Click(object sender, EventArgs e)
        {
            int brUlaznica = cboxBrojUlaznica.SelectedIndex + 1;
            Sjedalo odabrano = cboxOdabirSjedala.SelectedItem as Sjedalo;
            if(sjedala.Count < brUlaznica && !sjedala.Contains(odabrano))
            {
                sjedala.Add(odabrano);
            }
            lblInfoSuma.Text = (film.cijena * sjedala.Count()).ToString() + " kn";
            RefreshDGV();
        }

        private void cboxBrojUlaznica_SelectedIndexChanged(object sender, EventArgs e)
        {
            sjedala = new BindingList<Sjedalo>();
            RefreshDGV();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if(dgvOdabranaSjedala.CurrentRow != null)
            {
                Sjedalo odabranoDGV = dgvOdabranaSjedala.CurrentRow.DataBoundItem as Sjedalo;
                sjedala.Remove(odabranoDGV);
                RefreshDGV();
            }
        }

        private void btnPotvrdaRezervacije_Click(object sender, EventArgs e)
        {
            foreach (Sjedalo s in sjedala)
            {
                using (var context = new CineManageEntities())
                {
                    var query = from z in context.Zauzetost_Sjedala
                                where z.sjedala_sjedalo_id == s.sjedalo_id && z.Prikazivanje.film_film_id == film.film_id && z.Prikazivanje.Raspored_Prikazivanja.raspored_prikazivanja_id == vrijeme.raspored_prikazivanja_id
                                select z;
                    Zauzetost_Sjedala zauzetost = query.Single();
                    zauzetost.zauzeto = 1;

                    context.Films.Attach(film);
                    context.Sjedaloes.Attach(s);
                    context.Korisniks.Attach(korisnik);
                    context.Raspored_Prikazivanja.Attach(vrijeme);
                    Rezervacija rezervacija = new Rezervacija
                    {
                        Film = film,
                        Sjedalo = s,
                        Korisnik = korisnik,
                        Raspored_Prikazivanja = vrijeme
                    };

                    context.Rezervacijas.Add(rezervacija);
                    context.SaveChanges();
                }
            }
            sjedala = new BindingList<Sjedalo>();
            RefreshDGV();
            RefreshDGVrezervacije();
            PopuniCboxSjedala();
        }
    }
}
