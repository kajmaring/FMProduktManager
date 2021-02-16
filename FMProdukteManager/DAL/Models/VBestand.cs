using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class VBestand
    {
        public int KBestellPos { get; set; }
        public int KBestellung { get; set; }
        public int KWarenLager { get; set; }
        public int KLieferant { get; set; }
        public decimal? FLagerbestand { get; set; }
    }
}
