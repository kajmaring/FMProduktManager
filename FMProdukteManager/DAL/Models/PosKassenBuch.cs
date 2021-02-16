using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class PosKassenBuch
    {
        public long KKassenBuch { get; set; }
        public long KKasse { get; set; }
        public long? KBenutzer { get; set; }
        public DateTime DDatum { get; set; }
        public string CBelegNummer { get; set; }
        public string CBelegText { get; set; }
        public string CBelegTyp { get; set; }
        public long? NfEinnahme { get; set; }
        public long? NfAusgabe { get; set; }
        public long NfMwSt { get; set; }
        public double FSteuerSatz { get; set; }
        public long NfEndBestand { get; set; }
        public string CKonto { get; set; }
        public string CCheck { get; set; }
        public string CZahlart { get; set; }
        public string CNachricht { get; set; }
    }
}
