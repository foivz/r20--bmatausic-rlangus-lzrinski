using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_proba1.Funkcije
{
    public static class AzuriranjeFunk
    {
        public static void AzurirajFilm(Film film, Dvorana dvorana, Kategorija kategorija, string nas, string red, string op, int traj, double cij, BindingList<Raspored_Prikazivanja> odabranaVremena, List<Raspored_Prikazivanja> odabranaVremenaBaza)
        {
            using (var context = new CineManageEntities())
            {
                context.Films.Attach(film);
                //ako je odabrana dvorana različita od dvorane filma u bazi, postavi dvoranu filma u bazi da je nepopunjena
                if (film.Dvorana.dvorana_id != dvorana.dvorana_id)
                {
                    film.Dvorana.popunjena_dvorana = 0;
                    context.SaveChanges();
                }
                //popuni podatke filma u bazi i popuni dvoranu u kojoj se prikazuej film
                film.naslov = nas;
                film.readtelj = red;
                film.opis = op;
                film.trajanje = traj;
                film.cijena = cij;
                context.Dvoranas.Attach(dvorana);
                film.Dvorana = dvorana;
                context.Kategorijas.Attach(kategorija);
                film.Kategorija = kategorija;
                film.Dvorana.popunjena_dvorana = 1;

                context.SaveChanges();

                var queryRasporedi = from p in context.Prikazivanjes
                                     where p.film_film_id == film.film_id
                                     select p.Raspored_Prikazivanja;
                List<Raspored_Prikazivanja> rasporediFilma = queryRasporedi.ToList();
                foreach (Raspored_Prikazivanja r in odabranaVremena)
                {
                    if (!odabranaVremenaBaza.Contains(r))
                    {
                        Prikazivanje novo = new Prikazivanje
                        {
                            raspored_prikazivanja_idraspored_prikazivanja = r.raspored_prikazivanja_id,
                            film_film_id = film.film_id
                        };
                        context.Prikazivanjes.Add(novo);
                        context.SaveChanges();
                    }
                }
                var queryPrikazivanjaTablica = from p in context.Prikazivanjes
                                               where p.film_film_id == film.film_id
                                               select p;
                List<Prikazivanje> prikazivanjaTablica = queryPrikazivanjaTablica.ToList();
                var queryPrikazivanjeBaza = from z in context.Zauzetost_Sjedala
                                            where z.Prikazivanje.film_film_id == film.film_id
                                            select z.Prikazivanje;
                List<Prikazivanje> prikazivanjaBaza = queryPrikazivanjeBaza.ToList();
                var querySjedala = from s in context.Sjedaloes
                                   where s.dvorana_dvorana_id == dvorana.dvorana_id
                                   select s;
                List<Sjedalo> sjedala = querySjedala.ToList();
                foreach (Prikazivanje p in prikazivanjaTablica)
                {
                    if (!prikazivanjaBaza.Contains(p))
                    {
                        foreach (Sjedalo s in sjedala)
                        {
                            Zauzetost_Sjedala zauzetost = new Zauzetost_Sjedala
                            {
                                zauzeto = 0,
                                prikazuje_se_prikazuje_se_id = p.prikazuje_se_id,
                                sjedala_sjedalo_id = s.sjedalo_id
                            };
                            context.Zauzetost_Sjedala.Add(zauzetost);
                            context.SaveChanges();
                        }
                    }
                }
            }
        }
    }
}
