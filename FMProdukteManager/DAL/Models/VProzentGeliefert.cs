using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class VProzentGeliefert
    {
        public int KBestellung { get; set; }
        public decimal? ProzGeliefert { get; set; }
        public decimal? ProzAufLieferschein { get; set; }
    }
}
