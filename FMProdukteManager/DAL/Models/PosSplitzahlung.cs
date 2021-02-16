using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class PosSplitzahlung
    {
        public long KSplitzahlung { get; set; }
        public long? KBon { get; set; }
        public float? FBetrag { get; set; }
        public string CZahlart { get; set; }
    }
}
