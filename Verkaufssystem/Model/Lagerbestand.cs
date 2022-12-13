using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Lagerbestand
    {
        public Lagerbestand()
        {

        }
        public Lagerbestand(string schuhname, string beschreibung, double? preis, string farbe, string marke)
        {
            Schuhname = schuhname;
            Beschreibung = beschreibung;
            Preis = preis;
            Farbe = farbe;
            Marke = marke;
        }

        public string Schuhname { get; set; }
        public string Beschreibung { get; set; }
        public double? Preis { get; set; }
        public string Farbe { get; set; }
        public string Marke { get; set; }
    }
}
