using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class LvLagerUebersicht
    {
        public DateTime Datum { get; set; }
        public int KLieferant { get; set; }
        public int Monat { get; set; }
        public int Jahr { get; set; }
        public decimal? Bestand { get; set; }
        public decimal? BelegterPlatz { get; set; }
        public decimal? Kosten { get; set; }
    }
}
