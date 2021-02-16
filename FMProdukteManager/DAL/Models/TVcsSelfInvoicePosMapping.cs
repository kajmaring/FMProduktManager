using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TVcsSelfInvoicePosMapping
    {
        public int KAmazonBestellungPos { get; set; }
        public int KBestellPos { get; set; }
        public int KVcsdata { get; set; }
        public decimal NQuantity { get; set; }
    }
}
