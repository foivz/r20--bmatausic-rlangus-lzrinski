using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_proba1
{
    public class FunkcijeLoginRegistracija
    {

        public FunkcijeLoginRegistracija()
        {
        }

        public void DodajKorisnika(string korisnickoIme, string lozinka, string email)
        {
            bool provjera = ProvjeriPostojecegKorisnika(korisnickoIme);
            if (korisnickoIme == "")
            {
                throw new Iznimke.DodavanjeKorisnikaException("Korisnicko ime nesmije biti prazno polje");
            }
            else if (lozinka.Count() < 8)
            {
                throw new Iznimke.DodavanjeKorisnikaException("Lozinka mora imati najmanje 8 znakova");
            }
            else if (provjera == true)
            {
                throw new Iznimke.DodavanjeKorisnikaException("Korisnik već postoji!");
            }
            Korisnik._korisnik.Add(new Korisnik(korisnickoIme, lozinka, email));
        }

        public int ProvjeriPodatke(string kIme, string lozinka)
        {
            Korisnik trazeni = DohvatiKorisnika(kIme);
            if (trazeni == null) return 0;
            else if(trazeni != null && lozinka != trazeni.Lozinka)
            {
                return 1;
            }
            else
            {
                return 2;
            }

        }

        public Korisnik DohvatiKorisnika(string kIme)
        {
            return Korisnik._korisnik.Find(k => k.KorisnickoIme == kIme);
        }

        public bool ProvjeriPostojecegKorisnika(string korisnik)
        {
            bool postoji = false;
            foreach  (Korisnik kor in Korisnik._korisnik)
            {
                if(korisnik == kor.KorisnickoIme)
                {
                    postoji = true;
                }
            }

            return postoji;
        }


    }
}
