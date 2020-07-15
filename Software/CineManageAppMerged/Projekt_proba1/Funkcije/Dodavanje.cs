using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_proba1.Funkcije
{
    public static class Dodavanje
    {
        public static List<Kategorija> FillCboxesZanr()
        {
            using (var context = new CineManageEntities())
            {
                var queryKategorije = from k in context.Kategorijas
                                      select k;
                List<Kategorija> kategorije = queryKategorije.ToList();
                return kategorije;
            }
        }
        public static List<Dvorana> FillCboxesDvorana()
        {
            using (var context = new CineManageEntities())
            {
                var queryDvorane = from d in context.Dvoranas
                                   where d.popunjena_dvorana == 0
                                   select d;
                List<Dvorana> dvorane = queryDvorane.ToList();
                return dvorane;
            }
        }
        public static List<Raspored_Prikazivanja> FillCboxesRaspored()
        {
            using (var context = new CineManageEntities())
            {
                var queryVremena = from r in context.Raspored_Prikazivanja
                                   select r;
                List<Raspored_Prikazivanja> raspored = queryVremena.ToList();
                return raspored;
            }
        }
        public static void DodajFilm(string nas, string red, string op, int traj, double cij, Kategorija kategorija, Dvorana dvorana, BindingList<Raspored_Prikazivanja> odabranaVremena)
        {
            using (var context = new CineManageEntities())
            {
                Film novi = new Film
                {
                    naslov = nas,
                    readtelj = red,
                    opis = op,
                    trajanje = traj,
                    cijena = cij,
                    kategorija_kategorija_id = kategorija.kategorija_id,
                    dvorana_dvorana_id = dvorana.dvorana_id
                };
                context.Films.Add(novi);

                var queryDvorana = from d in context.Dvoranas
                                   where d.dvorana_id == dvorana.dvorana_id
                                   select d;
                Dvorana promjenjenaDvorana = queryDvorana.Single();
                promjenjenaDvorana.popunjena_dvorana = 1;

                foreach (Raspored_Prikazivanja r in odabranaVremena)
                {
                    Prikazivanje prikaz = new Prikazivanje
                    {
                        raspored_prikazivanja_idraspored_prikazivanja = r.raspored_prikazivanja_id,
                        film_film_id = novi.film_id
                    };
                    context.Prikazivanjes.Add(prikaz);
                    context.SaveChanges();
                }

                var querySjedala = from s in context.Sjedaloes
                                   where s.dvorana_dvorana_id == dvorana.dvorana_id
                                   select s;
                List<Sjedalo> sjedala = querySjedala.ToList();
                var queryPrikazivanja = from p in context.Prikazivanjes
                                        where p.film_film_id == novi.film_id
                                        select p;
                List<Prikazivanje> prikazivanja = queryPrikazivanja.ToList();
                foreach (Prikazivanje p in prikazivanja)
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
                    }

                }
                context.SaveChanges();
            }
        }
    }
}
