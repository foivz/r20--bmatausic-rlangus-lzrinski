using Microsoft.Reporting.WinForms;
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
    public partial class OdabraniFilmReportForm : Form
    {
        int film;
        public OdabraniFilmReportForm(int odabrani)
        {
            InitializeComponent();
            film = odabrani;
        }

        private void OdabraniFilmReportForm_Load(object sender, EventArgs e)
        {
            using (var context = new CineManageEntities())
            {
                var queryFilm = from f in context.Films
                                where f.film_id == film
                                select f;
                Film reportFilm = queryFilm.Single();
                
                var queryRezervacije = from r in context.Rezervacijas
                                       where r.film_film_id == film
                                       select new RezervacijaView
                                       {
                                           ID_rezervacije = r.rezervacija_id,
                                           Ime_Filma = r.Film.naslov,
                                           Cijena_filma = r.Film.cijena,
                                           Vrijeme_Prikazivanja = r.Raspored_Prikazivanja.vrijeme_prikazivanja
                                       };
                List<RezervacijaView> reportRezervacije = queryRezervacije.ToList();
            }
        }
    }
}
