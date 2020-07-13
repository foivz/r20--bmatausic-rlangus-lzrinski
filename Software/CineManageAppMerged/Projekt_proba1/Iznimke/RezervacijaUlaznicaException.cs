using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_proba1.Iznimke
{
    public class RezervacijaUlaznicaException : Exception
    {
        public string Poruka { get; set; }

        public RezervacijaUlaznicaException(string poruka)
        {
            Poruka = poruka;
        }
    }
}
