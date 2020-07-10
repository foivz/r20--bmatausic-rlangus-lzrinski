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
    public partial class SviFilmoviReportForm : Form
    {
        public SviFilmoviReportForm()
        {
            InitializeComponent();
        }

        private void SviFilmoviReportForm_Load(object sender, EventArgs e)
        {
            using (var context = new CineManageEntities())
            {
                var query = from r in context.Rezervacijas
                            select new RezervacijaView
                            {
                                ID_rezervacije = r.rezervacija_id,
                                Ime_Filma = r.Film.naslov,
                                Cijena_filma = r.Film.cijena,
                                Vrijeme_Prikazivanja = r.Raspored_Prikazivanja.vrijeme_prikazivanja
                            };
                List<RezervacijaView> sveRezervacije = query.ToList();
                foreach (RezervacijaView rez in sveRezervacije)
                {
                    rez.Vrijeme_Prikazivanja = rez.Vrijeme_Prikazivanja.Date;
                }
                RezervacijaViewBindingSource.DataSource = sveRezervacije;
            }
            this.reportSviFilmovi.RefreshReport();
        }
    }
}
