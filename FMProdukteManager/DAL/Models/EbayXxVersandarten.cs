using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class EbayXxVersandarten
    {
        public int SiteId { get; set; }
        public string CDescription { get; set; }
        public byte? ExpeditedService { get; set; }
        public byte? InternationalService { get; set; }
        public string ShippingService { get; set; }
        public int ShippingServiceId { get; set; }
        public byte ShippingTimeMin { get; set; }
        public byte ShippingTimeMax { get; set; }
        public int MappedToShippingServiceId { get; set; }
    }
}
