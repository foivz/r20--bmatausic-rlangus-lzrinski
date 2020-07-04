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

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            FormLogin frmLogin = new FormLogin();
            this.Close();
            this.Hide();
            frmLogin.ShowDialog();
            this.Show();
        }

        private void btnPrikaziGraf_Click(object sender, EventArgs e)
        {
            this.Close();
            FormIzvjesceGraf frmIzvjesceGraf = new FormIzvjesceGraf();
            this.Hide();
            frmIzvjesceGraf.ShowDialog();
            this.Show();
        }

        private void FormObracun_Load(object sender, EventArgs e)
        {
            RefreshObracunZarada();
            RefreshObracunUlaznice();
            FillCboxFilter();
            FillCboxFilterUlaznice();
            UkupnaZaradaOdUlaznica();
            UkupnoProdanihUlaznica();

            //todo set korisnik 
            if (korisnik == null)
            {
                lblKorisnickoIme.Text = "Guest";
                btnOdjava.Visible = false;
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
                            select new { r.rezervacija_id, r.Film.naslov, r.Film.cijena, r.Raspored_Prikazivanja.vrijeme_prikazivanja };
                dgvZaradaOdUlaznica.DataSource = query.ToList();
                dgvZaradaOdUlaznica.Columns[0].HeaderText = "ID";
                dgvZaradaOdUlaznica.Columns[1].HeaderText = "Ime filma";
                dgvZaradaOdUlaznica.Columns[2].HeaderText = "Cijena ulaznice";
                dgvZaradaOdUlaznica.Columns[3].HeaderText = "Vrijeme";

            }
        }

        private void RefreshObracunUlaznice()
        {
            //todo count all uniqe and display
        }

        private void FillCboxFilter()
        {
            using (var context = new CineManageEntities())
            {
                var query = from f in context.Films
                            orderby f.naslov
                            select f;
                List<Film> filmovi = query.ToList();
                List<string> naziviFilmova = new List<string>();
                foreach (Film f in filmovi)
                {
                    naziviFilmova.Add(f.naslov);
                }
                cboxFilterZaradaFilm.DataSource = naziviFilmova;
                cboxFilterUlazniceFilm.DataSource = naziviFilmova;
            }
        }

        private void FillCboxFilterUlaznice()
        {
            using (var context = new CineManageEntities())
            {
                var query = from f in context.Films
                            orderby f.naslov
                            select f;
                List<Film> filmovi = query.ToList();
                List<string> naziviFilmova = new List<string>();
                foreach (Film f in filmovi)
                {
                    naziviFilmova.Add(f.naslov);
                }
                cboxFilterUlazniceFilm.DataSource = naziviFilmova;
            }
        }
        private void cboxFilterZaradaFilm_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string nazivFilma = cboxFilterZaradaFilm.SelectedItem as string;
            FilterImenaFilmova(nazivFilma);
            UkupnaZaradaOdUlaznicaFilter(nazivFilma);
        }
        
        private void FilterImenaFilmova(string nazivFilma)
        {
            using (var context = new CineManageEntities())
            {
                var query = from r in context.Rezervacijas
                            where r.Film.naslov == nazivFilma
                            select new { r.rezervacija_id, r.Film.naslov, r.Film.cijena, r.Raspored_Prikazivanja.vrijeme_prikazivanja };
                dgvZaradaOdUlaznica.DataSource = query.ToList();
                dgvZaradaOdUlaznica.Columns[0].HeaderText = "ID";
                dgvZaradaOdUlaznica.Columns[1].HeaderText = "Ime filma";
                dgvZaradaOdUlaznica.Columns[2].HeaderText = "Cijena ulaznice";
                dgvZaradaOdUlaznica.Columns[3].HeaderText = "Razdoblje";
            }
        }

        private void UkupnaZaradaOdUlaznicaFilter(string nazivFilma)
        {
            using (var context = new CineManageEntities())
            {
                var query = from r in context.Rezervacijas.Include("Film")
                            where r.Film.naslov == nazivFilma
                            select r.Film.cijena;
                double ukupnaZarada = query.Sum();
                lblSumaUlaznice.Text = ukupnaZarada.ToString();

            }
        }


        private void cboxFilterUlazniceFilm_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string nazivFilma = cboxFilterUlazniceFilm.SelectedItem as string;
            FilterImenaFilmovaUlaznice(nazivFilma);
            
        }

        private void FilterImenaFilmovaUlaznice(string nazivFilma)
        {
            if (dgvBrojProdanihUlaznica.Rows.Count > 0)
            {
                DataGridViewRow dgvDel = dgvBrojProdanihUlaznica.Rows[0];
                dgvBrojProdanihUlaznica.Rows.Remove(dgvDel);

            }
            using (var context = new CineManageEntities())
            {   
                var query = from r in context.Rezervacijas
                            where r.Film.naslov == nazivFilma
                            select new { r.Film.naslov };

                string count = query.Count().ToString();
                string imeFilma = nazivFilma;

                dgvBrojProdanihUlaznica.ColumnCount = 2;
                dgvBrojProdanihUlaznica.Columns[0].HeaderText = "Ime filma";
                dgvBrojProdanihUlaznica.Columns[1].HeaderText = "Broj prodanih ulaznica";
                string[] red = new string[] { imeFilma, count };
                dgvBrojProdanihUlaznica.Rows.Add(red);
                lblUkUlaznice.Text = count;
            }
        }
        //todo filter po danu za prodane ulaznice
        private void rbtnFilterZaradaDan_CheckedChanged(object sender, EventArgs e)
        {
            FilterZaradePoDanu();
        }

        private void FilterZaradePoDanu()
        {   /*
            using (var context = new CineManageEntities())
            {

                var query = from r in context.Rezervacijas.Include("Raspored_Prikazivanja").Include("Film")
                            orderby r.Raspored_Prikazivanja.vrijeme_prikazivanja
                            group context.Rezervacijas.Include("Raspored_Prikazivanja").Include("Film") by r.Raspored_Prikazivanja.vrijeme_prikazivanja into grp
                            var sum = context.Rezervacijas.Include("Raspored_Prikazivanja").Include("Film").Where(x => x.Raspored_Prikazivanja.vrijeme_prikazivanja  == grp.Key).Sum(x => x.Film.cijena)
                            select new
                            {
                                Date = grp.Key,
                                Sum =  sum
                            };

                dgvZaradaOdUlaznica.DataSource = query.ToList();*/


        }
        }
    }
}
