using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public class Filmovi
    {
        public static List<Filmovi> lista;
        public int ID { get; set; }
        public string Naziv { get; set; }
        public DateTime Datum { get; set; }
        public string Cijena { get; set; }
        public string Dvorana { get; set; }

        public Filmovi(int id, string naziv, DateTime datum, string cijena, string dvorana)
        {
            ID = id;
            Naziv = naziv;
            Datum = datum;
            Cijena = cijena;
            Dvorana = dvorana;
        }

        public static void LoadList()
        {
            lista = new List<Filmovi>();
            lista.Add(new Filmovi(0, "Brzi i žestoki 1", new DateTime(2020, 1, 25), " 25 kn ", " Dvorana 1 "));
            lista.Add(new Filmovi(1, "Brzi i žestoki 2", new DateTime(2020, 2, 13), " 25 kn ", " Dvorana 5 "));
            lista.Add(new Filmovi(2, "Brzi i žestoki 3", new DateTime(2020, 2, 17), " 30 kn ", " Dvorana 4 "));
            lista.Add(new Filmovi(3, "Brzi i žestoki 4", new DateTime(2020, 2, 17), " 27 kn ", " Dvorana 3 "));
            lista.Add(new Filmovi(4, "Brzi i žestoki 5", new DateTime(2020, 1, 13), " 25 kn ", " Dvorana 5 "));
            lista.Add(new Filmovi(5, "Robin Hood", new DateTime(2020, 2, 13), " 35 kn ", " Dvorana 2 "));
        }
    }
}
