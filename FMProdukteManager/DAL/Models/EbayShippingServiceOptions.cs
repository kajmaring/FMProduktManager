using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class EbayShippingServiceOptions
    {
        public int KShippingServiceOptions { get; set; }
        public int KItem { get; set; }
        public int ShippingServiceId { get; set; }
        public decimal ShippingServiceAdditionalCost { get; set; }
        public decimal ShippingServiceCost { get; set; }
        public byte? ShippingServicePriority { get; set; }
        public string ShippingService { get; set; }
    }
}
