using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_proba1
{
    public class Korisnik
    {
        public static List<Korisnik> _korisnik = new List<Korisnik>();
        public string KorisnickoIme { get; private set; }

        public string Lozinka { get; private set; }

        public string Email { get; set; }

        public int Ogranicenje { get; private set; }

        public Korisnik(string kIme, string lozinka, string email)
        {
            KorisnickoIme = kIme;
            Lozinka = lozinka;
            Email = email;
            Ogranicenje = 0;
        }
    }
}
