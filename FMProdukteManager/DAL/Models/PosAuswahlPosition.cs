using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class PosAuswahlPosition
    {
        public long KAuswahlPosition { get; set; }
        public long KAuswahl { get; set; }
        public long? KKunde { get; set; }
        public long? KBenutzerAusgabe { get; set; }
        public long? KBenutzerRueckgabe { get; set; }
        public DateTime? DDatumAusgabe { get; set; }
        public DateTime? DDatumRueckgabe { get; set; }
        public float? FMenge { get; set; }
        public long? KArtikel { get; set; }
        public byte[] BBonPosition { get; set; }
        public string CArtNr { get; set; }
        public string CName { get; set; }
        public string CVariationen { get; set; }
        public string CSerienNr { get; set; }
        public double? FVkpreis { get; set; }
    }
}
