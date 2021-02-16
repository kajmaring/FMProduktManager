using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class EbayXxVersandlaender
    {
        public int SiteId { get; set; }
        public string ShippingLocation { get; set; }
        public string CDescription { get; set; }
    }
}
