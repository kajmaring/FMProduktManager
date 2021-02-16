using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class PosBonRueckgabe
    {
        public long KBonRueckgabe { get; set; }
        public long? KBon { get; set; }
        public DateTime? DDatum { get; set; }
        public float? FGesamtMenge { get; set; }
        public float? FGesamtSumme { get; set; }
        public long? NRueckgabeAktion { get; set; }
        public long? KKunde { get; set; }
        public long? KBenutzer { get; set; }
        public long? KKasse { get; set; }
        public byte[] CData { get; set; }
        public string CBonRueckgabeNr { get; set; }
    }
}
