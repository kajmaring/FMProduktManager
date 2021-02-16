using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class EbayShippingprofiles
    {
        public int KEbayBenutzer { get; set; }
        public string CProfilType { get; set; }
        public string DiscountProfileId { get; set; }
        public string DiscountProfileName { get; set; }
        public int SiteId { get; set; }
    }
}
