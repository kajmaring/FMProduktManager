using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class PosEinnahmeAusgabe
    {
        public int KEinnahmeAusgabe { get; set; }
        public DateTime DDatum { get; set; }
        public int KBenutzer { get; set; }
        public int KKasse { get; set; }
        public float FBetrag { get; set; }
        public float FMwSt { get; set; }
        public float FSteuerSatz { get; set; }
        public int? NKonto { get; set; }
        public string CText { get; set; }
        public string CEinnahmeAusgabeNr { get; set; }
    }
}
