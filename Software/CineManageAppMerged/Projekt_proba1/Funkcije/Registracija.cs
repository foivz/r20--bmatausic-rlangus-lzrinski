using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_proba1.Funkcije
{
    public static class Registracija
    {
        private static bool ProvjeriPostojecegKorisnika(string kime)
        {
            using (var context = new CineManageEntities())
            {
                var query = from u in context.Korisniks
                            where u.korisnicko_ime == kime
                            select u;
                if (query.ToList().Count != 0)
                {
                    return true;
                }
                else
                    return false;
            }
        }
        public static void DodajKorisnika(string firstn, string lastn, string username, string pass, string mail)
        {
            bool provjera = ProvjeriPostojecegKorisnika(username);
            if (username == "" || firstn == "" || lastn == "" || mail == "")
            {
                throw new Iznimke.DodavanjeKorisnikaException("Sva polja moraju biti popunjena!");
            }
            else if (pass.Count() < 8)
            {
                throw new Iznimke.DodavanjeKorisnikaException("Lozinka mora imati najmanje 8 znakova!");
            }
            else if (provjera == true)
            {
                throw new Iznimke.DodavanjeKorisnikaException("Korisnik već postoji!");
            }
            using (var context = new CineManageEntities())
            {
                var query = from r in context.Rolas
                            where r.ime_role == "Registrirani korisnik"
                            select r;
                Rola uloga = query.Single();

                Korisnik novi = new Korisnik
                {
                    ime = firstn,
                    prezime = lastn,
                    korisnicko_ime = username,
                    lozinka = pass,
                    email = mail,
                    Rola = uloga
                };
                context.Korisniks.Add(novi);
                context.SaveChanges();
            }
        }
    }
}
