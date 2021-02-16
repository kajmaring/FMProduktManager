using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class LvLieferschwellen
    {
        public string Land { get; set; }
        public decimal? Lieferschwelle { get; set; }
        public int Firma { get; set; }
        public decimal? NLetztesJahrEur { get; set; }
        public decimal? NAktuellEur { get; set; }
        public decimal? NAktuellPer { get; set; }
        public decimal? NLetztesJahrPer { get; set; }
        public string RowColor { get; set; }
    }
}
