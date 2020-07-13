using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_proba1.Iznimke
{
    public class InformacijeFilmaException : Exception
    {
        public string Poruka { get; set; }

        public InformacijeFilmaException(string poruka)
        {
            Poruka = poruka;
        }
    }
}
