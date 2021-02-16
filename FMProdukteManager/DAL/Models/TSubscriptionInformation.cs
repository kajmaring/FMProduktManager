using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TSubscriptionInformation
    {
        public int NShippingProduct { get; set; }
        public byte NValid { get; set; }
        public string CSubscription { get; set; }
        public DateTime DNextUpdate { get; set; }
    }
}
