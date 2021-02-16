using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class LvAbonnements
    {
        public int KKunde { get; set; }
        public int KBestellung { get; set; }
        public int KIntervall { get; set; }
        public string CBestellNr { get; set; }
        public byte? NZahlungsziel { get; set; }
        public decimal FWert { get; set; }
        public decimal FZahlung { get; set; }
        public decimal FGutschrift { get; set; }
        public decimal FGutschein { get; set; }
        public decimal FFaktor { get; set; }
        public string CWaehrung { get; set; }
        public short? AmMonatsende { get; set; }
        public DateTime? DStartdatum { get; set; }
        public DateTime? DEnddatum { get; set; }
        public short? NAlleXjahre { get; set; }
        public short? NAlleXmonate { get; set; }
        public short? NAlleXtage { get; set; }
        public string Zahlungsart { get; set; }
    }
}
