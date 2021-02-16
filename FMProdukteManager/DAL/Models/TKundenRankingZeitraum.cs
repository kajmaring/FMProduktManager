﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TKundenRankingZeitraum
    {
        public int KKunde { get; set; }
        public byte NZeitraum { get; set; }
        public DateTime DVon { get; set; }
        public byte NType { get; set; }
        public int KShop { get; set; }
        public int NPlattform { get; set; }
        public int NRang { get; set; }
        public int? NRangMax { get; set; }
        public decimal NAnteilProzent { get; set; }
        public decimal NPauschal { get; set; }
        public DateTime? DStand { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
