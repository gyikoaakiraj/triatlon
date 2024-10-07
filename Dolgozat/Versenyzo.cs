using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Dolgozat
{

    internal class Versenyzo
    {
        public static List<Versenyzo> versenyzok = new List<Versenyzo>();

        public string Nev { get; set; }
        public DateTime SzulIdo { get; set; }
        public int Rajt { get; set; }
        public char Neme { get; set; }
        public int Kor { get; set; }
        public string Kategoria { get; set; }

        public DateTime UszasIdo { get; set; }
        public DateTime BicikliIdo { get; set; }
        public DateTime MasodikDepo { get; set; }
        public DateTime FutasIdo { get; set; }

        public Versenyzo(string nev, DateTime szulIdo, int rajt, char neme, int kor, string kategoria, DateTime uszasIdo, DateTime bicikliIdo, DateTime masodikDepo, DateTime futasIdo)
        {
            Nev = nev;
            SzulIdo = szulIdo;
            Rajt = rajt;
            Neme = neme;
            Kor = kor;
            Kategoria = kategoria;
            UszasIdo = uszasIdo;
            BicikliIdo = bicikliIdo;
            MasodikDepo = masodikDepo;
            FutasIdo = futasIdo;
            UszasIdo = uszasIdo;
            BicikliIdo = bicikliIdo;
            MasodikDepo = masodikDepo;
            FutasIdo = futasIdo;

            versenyzok.Add(this);
        }
    }
        public override string ToString()
        {
            return $"{Nev} ({Kor.ToString("yyyy")}) Idő: {Ido} | Kat.:{Kategoria} | Rajtsz.: {Rajt}";
        }
    }
}
