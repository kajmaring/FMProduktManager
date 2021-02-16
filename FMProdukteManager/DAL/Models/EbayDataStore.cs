using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class EbayDataStore
    {
        public int KStore { get; set; }
        public int? KEbayUser { get; set; }
        public string Name { get; set; }
        public string SubscriptionLevel { get; set; }
        public string Url { get; set; }
    }
}
