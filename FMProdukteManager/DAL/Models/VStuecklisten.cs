using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class VStuecklisten
    {
        public string CArtNr { get; set; }
        public string Einkaufspreis { get; set; }
        public string Artikelgewicht { get; set; }
        public string Versandgewicht { get; set; }
        public string Lagerführung { get; set; }
        public string Überverkäufe { get; set; }
        public string Teilbarkeit { get; set; }
        public string Lieferzeitberechnung { get; set; }
        public string Bearbeitungszeit { get; set; }
        public int KArtikel { get; set; }
    }
}
