using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class InventoryDifferenceList
    {
        public decimal? TotalPurchasePriceNet { get; set; }
        public decimal? QuantityDifference { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
    }
}
