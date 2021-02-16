using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class PosGutscheine
    {
        public long KGutschein { get; set; }
        public string CAktiv { get; set; }
        public long? KBonAusgabe { get; set; }
        public long? KBonEinloesung { get; set; }
        public long? KKasse { get; set; }
        public string CNummer { get; set; }
        public double? FBetrag { get; set; }
        public DateTime? DErstellung { get; set; }
        public DateTime? DEinloesung { get; set; }
        public long? KBenutzerVerkaufen { get; set; }
        public string CBenutzerVerkaufen { get; set; }
        public long? KKundeKaufen { get; set; }
        public string CKundeKaufen { get; set; }
        public long? KBenutzerEinloesen { get; set; }
        public string CBenutzerEinloesen { get; set; }
        public long? KKundeEinloesen { get; set; }
        public string CKundeEinloesen { get; set; }
        public long? KKasseAusgabe { get; set; }
        public long? KKasseEinloesung { get; set; }
    }
}
