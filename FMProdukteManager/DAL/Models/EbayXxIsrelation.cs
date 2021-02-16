using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class EbayXxIsrelation
    {
        public int SiteId { get; set; }
        public int CategoryId { get; set; }
        public int KName { get; set; }
        public int KValue { get; set; }
        public int KNameParent { get; set; }
        public int KValueParent { get; set; }
    }
}
