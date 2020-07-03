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
    public partial class FormInformacijeFilm : Form
    {
        private Film film;
        private Korisnik korisnik;

        public FormInformacijeFilm(Film odabrani, Korisnik user)
        {
            InitializeComponent();
            film = odabrani;
            korisnik = user;
        }
        public FormInformacijeFilm(Film odabrani)
        {
            InitializeComponent();
            film = odabrani;
        }

        private void FormInformacijeFilm_Load(object sender, EventArgs e)
        {
            if (korisnik != null) lblKorisnickoIme.Text = korisnik.korisnicko_ime;
            else lblKorisnickoIme.Text = "Guest";
            lblFilmIme.Text = film.naslov;
            lblRedateljFilma.Text = film.readtelj;
            lblSadrzajFilma.Text = film.opis;
            lblDvoranaId.Text = film.dvorana_dvorana_id.ToString();
        }
    }
}
