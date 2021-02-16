using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class PfAmazonRetourmeldungadjustment
    {
        public int? KAmazonRetourMeldung { get; set; }
        public string CItemPriceAdjustmentType { get; set; }
        public string CPromotionClaimCode { get; set; }
        public decimal? FAmount { get; set; }
        public string CCurrency { get; set; }
    }
}
