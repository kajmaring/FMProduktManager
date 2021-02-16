using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class LvLagerkosten
    {
        public int KArtikel { get; set; }
        public decimal Kubikmeter { get; set; }
        public string CArtNr { get; set; }
        public string CLiefArtNr { get; set; }
        public decimal FLagerBestand { get; set; }
        public DateTime Datum { get; set; }
        public decimal KubikmeterGesamt { get; set; }
        public decimal PreisProM3 { get; set; }
        public decimal LagergebührProTag { get; set; }
        public int Monat { get; set; }
        public int Jahr { get; set; }
        public string Firma { get; set; }
        public int KLieferant { get; set; }
    }
}
