using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class PosBonIc
    {
        public long KBonIc { get; set; }
        public int? KBon { get; set; }
        public int? KArtikel { get; set; }
        public int? KEigenschaftwert { get; set; }
        public int? KLagerArtikel { get; set; }
        public float? FAnzahl { get; set; }
        public string CStorno { get; set; }
    }
}
