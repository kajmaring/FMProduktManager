using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class VOffenerPostenEingangsrechnungZahlung
    {
        public int KZahlung { get; set; }
        public decimal FBetrag { get; set; }
        public DateTime? DDatum { get; set; }
        public int KEingangsrechnung { get; set; }
        public string CFremdbelegnummer { get; set; }
        public int? KLieferant { get; set; }
        public string CStandardWaehrungIso { get; set; }
        public byte NMatchingOptionen { get; set; }
    }
}
