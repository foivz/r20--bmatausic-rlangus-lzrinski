using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projekt_proba1.Iznimke;
using RestSharp;
using RestSharp.Authenticators;

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
            dgvOdabranaSjedala.Columns["sjedalo_id"].Visible = false;
            dgvOdabranaSjedala.Columns["mjesto"].HeaderText = "Broj sjedala";
            dgvOdabranaSjedala.Columns["red"].HeaderText = "Red sjedala";
            dgvOdabranaSjedala.Columns["dvorana_dvorana_id"].Visible = false;

        }

        private void btnOdaberi_Click(object sender, EventArgs e)
        {
            int brUlaznica = cboxBrojUlaznica.SelectedIndex + 1;
            Sjedalo odabrano = cboxOdabirSjedala.SelectedItem as Sjedalo;
            if(sjedala.Count < brUlaznica && !sjedala.Contains(odabrano))
            {
                sjedala.Add(odabrano);
            }
            RefreshDGV();
        }

        private void cboxBrojUlaznica_SelectedIndexChanged(object sender, EventArgs e)
        {
            sjedala = new BindingList<Sjedalo>();
            lblInfoSuma.Text = (film.cijena * (cboxBrojUlaznica.SelectedIndex+1)).ToString() + " kn";
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
            try
            {
                if (sjedala.Count != cboxBrojUlaznica.SelectedIndex+1)
                {
                    throw new Iznimke.RezervacijaUlaznicaException("Broj odabranih sjedala i broj ulaznica se ne podudara!");
                }
                Podaci_o_rezervaciji podatak = new Podaci_o_rezervaciji
                {
                    ImeKorisnika = korisnik.ime + " " + korisnik.prezime,
                    BrojSjedala = sjedala.Count,
                    EmailKorisnika = korisnik.email,
                    NazivFilma = film.naslov,
                    CijenaFilma = film.cijena * sjedala.Count,
                    VrijemePrikazivanja = vrijeme.vrijeme_prikazivanja
                };

                Vrsta_Transakcije vrsta;
                foreach (Sjedalo s in sjedala)
                {
                    using (var context = new CineManageEntities())
                    {
                        var query = from z in context.Zauzetost_Sjedala
                                    where z.sjedala_sjedalo_id == s.sjedalo_id && z.Prikazivanje.film_film_id == film.film_id && z.Prikazivanje.Raspored_Prikazivanja.raspored_prikazivanja_id == vrijeme.raspored_prikazivanja_id
                                    select z;
                        Zauzetost_Sjedala zauzetost = query.Single();
                        zauzetost.zauzeto = 1;

                        if (rbtnKupnja.Checked == true)
                        {
                            var queryVrsta1 = from v in context.Vrsta_Transakcije
                                              where v.naziv_transakcije == "Kupnja"
                                              select v;
                            vrsta = queryVrsta1.Single();
                        }
                        else
                        {
                            var queryVrsta2 = from v in context.Vrsta_Transakcije
                                              where v.naziv_transakcije == "Rezervacija"
                                              select v;
                            vrsta = queryVrsta2.Single();
                        }
                        Rezervacija rezervacija = new Rezervacija
                        {
                            film_film_id = film.film_id,
                            sjedala_sjedalo_id = s.sjedalo_id,
                            korisnik_korisnik_id = korisnik.korisnik_id,
                            raspored_prikazivanja_raspored_prikazivanja_id = vrijeme.raspored_prikazivanja_id,
                            vrsta_transakcije_id = vrsta.vrsta_transakcije_id
                        };

                        context.Rezervacijas.Add(rezervacija);
                        context.SaveChanges();
                    }
                }
                sjedala = new BindingList<Sjedalo>();
                RefreshDGV();
                PopuniCboxSjedala();

                var klijent = new RestSharp.RestClient("https://api.mailgun.net/v3");
                klijent.Authenticator = new HttpBasicAuthenticator("api", "21ca885a2a4a526a6596df5a98c4091a-87c34c41-4021b56b");

                RestSharp.IRestRequest request = new RestSharp.RestRequest("/sandbox1e672fbeb4cc407fb2cbd1b04a75808d.mailgun.org/messages", RestSharp.Method.POST);

                string mailText = $"<html><head><link rel='stylesheet' type='text/css' href='https://develooper.codes/bootstrap.min2.css'></head><body><div class='container'><div class='jumbotron' style='margin-top:100px;background-color:#f7f7f7'><div style='background-color:#313131;border-radius:10px;margin-bottom:20px'><img class='img-fluid' src='https://develooper.codes/cinemanage%20logo.jpg' width='400' style='margin-left:auto;margin-right:auto;display:block'></div><h2 class='display-5' style='color:#313131;text-align:center;vertical-align:middle'>Pozdrav, {podatak.ImeKorisnika}</h2><p class='lead' style='color:#313131;text-align:center;vertical-align:middle'>Dobrodošao u svijet Cine Manage rezervacija!</p><hr class='my-4'><p style='color:#313131;text-align:center;vertical-align:middle'>Ovim putem podsjećamo te na tvoje rezervacije!</p><p style='color:#313131;text-align:center;vertical-align:middle; margin-bottom:50px;'><b>Film: {podatak.NazivFilma}</b><br><b>Datum: {podatak.VrijemePrikazivanja}</b><br><b>Sjedala: {podatak.BrojSjedala}</b><br><b>Ukupno plaćeno: {podatak.CijenaFilma} kn</b></p></div></div></body></html>";

                request.AddParameter("from", "Cine Manage <podsjetnik@cinemanage.com>");
                request.AddParameter("h:Reply-To", podatak.EmailKorisnika);
                request.AddParameter("to", podatak.EmailKorisnika);
                request.AddParameter("subject", "Podsjetnik za rezervaciju");
                request.AddParameter("html", mailText);

                RestSharp.IRestResponse response = klijent.Execute(request);
                MessageBox.Show("Uspješno ste rezervirali ulaznice!");
                this.Close();
            }
            catch (Iznimke.RezervacijaUlaznicaException ex)
            {
                MessageBox.Show(ex.Poruka);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
