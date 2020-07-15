using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_proba1.Funkcije
{
    public static class Obracun
    {
        public static int UkupnoProdanihUlaznica()
        {
            using (var context = new CineManageEntities())
            {
                var query = from r in context.Rezervacijas
                            select r.rezervacija_id;
                int ukupnoProdanihUlaznica = query.Count();
                return ukupnoProdanihUlaznica;
            }
        }
        public static double UkupnaZaradaOdUlaznica()
        {
            using (var context = new CineManageEntities())
            {
                var query = from r in context.Rezervacijas.Include("Film").Include("Raspored_Prikazivanja")
                            select r.Film.cijena;
                double ukupnaZarada = query.Sum();
                return ukupnaZarada;
            }
        }

        public static List<RezervacijaView> DohvatiRezervacijeSve()
        {
            using (var context = new CineManageEntities())
            {
                var query = from r in context.Rezervacijas.Include("Film").Include("Raspored_Prikazivanja")
                            select new RezervacijaView
                            {
                                ID_rezervacije = r.rezervacija_id,
                                Ime_Filma = r.Film.naslov,
                                Cijena_filma = r.Film.cijena,
                                Vrijeme_Prikazivanja = r.Raspored_Prikazivanja.vrijeme_prikazivanja
                            };

                List<RezervacijaView> rezervacije = query.ToList();
                return rezervacije;
            }
        }
        public static List<Film> DohvatiFilmove()
        {
            using (var context = new CineManageEntities())
            {
                var query = from f in context.Films
                            orderby f.naslov
                            select f;
                List<Film> filmovi = query.ToList();
                return filmovi;
            }
        }
        public static List<RezervacijaView> DohvatiRezervacijeFilm(string nazivFilma)
        {
            using (var context = new CineManageEntities())
            {
                var query = from r in context.Rezervacijas
                            where r.Film.naslov == nazivFilma
                            select new RezervacijaView
                            {
                                ID_rezervacije = r.rezervacija_id,
                                Ime_Filma = r.Film.naslov,
                                Cijena_filma = r.Film.cijena,
                                Vrijeme_Prikazivanja = r.Raspored_Prikazivanja.vrijeme_prikazivanja
                            };
                List<RezervacijaView> rezervacije = query.ToList();
                return rezervacije;
            }
        }
    }
}
