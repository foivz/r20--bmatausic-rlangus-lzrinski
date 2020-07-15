using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_proba1.Funkcije
{
    public static class PregledFilmova
    {
        public static List<string> DohvatiKategorije()
        {
            using (var context = new CineManageEntities())
            {
                var query = from k in context.Kategorijas
                            orderby k.kategorija_ime
                            select k;
                List<Kategorija> kategorije = query.ToList();
                List<string> naziviKategorija = new List<string>();
                foreach (Kategorija k in kategorije)
                {
                    naziviKategorija.Add(k.kategorija_ime);
                }
                return naziviKategorija;
            }
        }
        public static List<FilmView> DohvatiFilmove()
        {
            using (var context = new CineManageEntities())
            {
                var query = from f in context.Films
                            select new FilmView
                            {
                                film_id = f.film_id,
                                naslov = f.naslov,
                                redatelj = f.readtelj,
                                dvorana = f.Dvorana.ime_dvorane,
                                kategorija = f.Kategorija.kategorija_ime
                            };
                List<FilmView> filmovi = query.ToList();
                return filmovi;
            }
        }
        public static List<FilmView> DohvatiFilmoveDatum(DateTime date)
        {
            using (var context = new CineManageEntities())
            {
                var query = from p in context.Prikazivanjes
                            where p.Raspored_Prikazivanja.vrijeme_prikazivanja == date
                            select new FilmView
                            {
                                film_id = p.Film.film_id,
                                naslov = p.Film.naslov,
                                redatelj = p.Film.readtelj,
                                dvorana = p.Film.Dvorana.ime_dvorane,
                                kategorija = p.Film.Kategorija.kategorija_ime
                            };
                List<FilmView> filmovi = query.ToList();
                return filmovi;
            }
        }
        public static List<FilmView> DohvatiFilmoveNaziv(string filter)
        {
            using (var context = new CineManageEntities())
            {
                var query = from p in context.Prikazivanjes
                            where p.Film.naslov.Contains(filter) || p.Film.readtelj.Contains(filter)
                            select new FilmView
                            {
                                film_id = p.Film.film_id,
                                naslov = p.Film.naslov,
                                redatelj = p.Film.readtelj,
                                dvorana = p.Film.Dvorana.ime_dvorane,
                                kategorija = p.Film.Kategorija.kategorija_ime
                            };
                List<FilmView> filmovi = query.Distinct().ToList();
                return filmovi;
            }
        }
        public static List<FilmView> DohvatiFilmoveKategorija(string kategorija)
        {
            using (var context = new CineManageEntities())
            {
                var query = from p in context.Prikazivanjes
                            where p.Film.Kategorija.kategorija_ime == kategorija
                            select new FilmView
                            {
                                film_id = p.Film.film_id,
                                naslov = p.Film.naslov,
                                redatelj = p.Film.readtelj,
                                dvorana = p.Film.Dvorana.ime_dvorane,
                                kategorija = p.Film.Kategorija.kategorija_ime
                            };
                List<FilmView> filmovi = query.Distinct().ToList();
                return filmovi;
            }
        }
        public static void ObrisiFilm(int odabrani)
        {
            using (var context = new CineManageEntities())
            {
                var query = from f in context.Films
                            where f.film_id == odabrani
                            select f;
                Film odabraniFilm = query.Single();

                //brisanje rezervacije izbrisanog odabranog filma
                var queryRezervacije = from r in context.Rezervacijas
                                       where r.film_film_id == odabraniFilm.film_id
                                       select r;
                List<Rezervacija> rezervacije = queryRezervacije.ToList();
                foreach (Rezervacija r in rezervacije)
                {
                    context.Rezervacijas.Remove(r);
                    context.SaveChanges();
                }
                //brisanje zauzetosti sjedala odabranog filma
                var queryZauzetosti = from z in context.Zauzetost_Sjedala
                                      where z.Prikazivanje.film_film_id == odabraniFilm.film_id
                                      select z;
                List<Zauzetost_Sjedala> zauzetosti = queryZauzetosti.ToList();
                foreach (Zauzetost_Sjedala z in zauzetosti)
                {
                    context.Zauzetost_Sjedala.Remove(z);
                    context.SaveChanges();
                }
                //brisanje svih prikazivanja odabranog filma
                var queryPrikazivanja = from p in context.Prikazivanjes
                                        where p.film_film_id == odabraniFilm.film_id
                                        select p;
                List<Prikazivanje> prikazivanja = queryPrikazivanja.ToList();
                foreach (Prikazivanje p in prikazivanja)
                {
                    context.Prikazivanjes.Remove(p);
                    context.SaveChanges();
                }
                //mjenjanje zauzetosti dvorane
                var queryDvorana = from f in context.Films
                                   where f.Dvorana.dvorana_id == odabraniFilm.Dvorana.dvorana_id
                                   select f.Dvorana;
                Dvorana dvorana = queryDvorana.Single();
                dvorana.popunjena_dvorana = 0;
                context.SaveChanges();
                //brisanje filma
                context.Films.Remove(odabraniFilm);
                context.SaveChanges();
            }
        }
    }
}
