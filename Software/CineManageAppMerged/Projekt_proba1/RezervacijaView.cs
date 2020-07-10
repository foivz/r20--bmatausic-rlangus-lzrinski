using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_proba1
{
    public class RezervacijaView
    {
        public int ID_rezervacije { get; set; }
        public string Ime_Filma { get; set; }
        public double Cijena_filma { get; set; }
        public DateTime Vrijeme_Prikazivanja { get; set; }
    }
}
