using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_proba1.Funkcije
{
    public static class Login
    {
        public static Korisnik DohvatiKorisnika(string kime)
        {
            Korisnik user;
            Rola role;
            using (var context = new CineManageEntities())
            {
                var query = from u in context.Korisniks
                            where u.korisnicko_ime == kime
                            select u;
                if (query.ToList().Count != 0)
                {
                    user = query.Single();
                    role = user.Rola;
                }
                else
                    throw new Iznimke.LoginException("Nepostojeći korisnik!");
            }
            return user;
        }
    }
}
