using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_proba1.Iznimke
{
    class NeregistriraniKorisnikException : Exception
    {
        public string Poruka { get; set; }
        public NeregistriraniKorisnikException(string poruka)
        {
            Poruka = poruka;
        }
    }
}
