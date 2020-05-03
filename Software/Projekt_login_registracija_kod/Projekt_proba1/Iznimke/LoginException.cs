using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_proba1.Iznimke
{
    class LoginException : Exception
    {
        public string Poruka { get; set; }

        public LoginException(string poruka)
        {
            Poruka = poruka;
        }
    }
}
