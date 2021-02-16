using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class PosBonPositionRueckgabe
    {
        public long KBonPositionRueckgabe { get; set; }
        public long KBonPosition { get; set; }
        public long? KBon { get; set; }
        public long? KBenutzer { get; set; }
        public DateTime? DDatum { get; set; }
        public string CGrund { get; set; }
        public float FAnzahl { get; set; }
        public long NRueckgabeAktion { get; set; }
        public long? KKunde { get; set; }
        public long? KBonRueckgabe { get; set; }
    }
}
