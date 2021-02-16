using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TVorlage1
    {
        public int KVorlage { get; set; }
        public string CName { get; set; }
        public int? KAmazonBuyBoxStrategy { get; set; }
        public int? KAmazonCompetitorAsinStrategy { get; set; }
        public int? KMargensteigerung { get; set; }
        public int? KAbverkauf { get; set; }

        public virtual TAbverkauf KAbverkaufNavigation { get; set; }
        public virtual TAmazonBuyBoxStrategy KAmazonBuyBoxStrategyNavigation { get; set; }
        public virtual TAmazonCompetitorAsinStrategy KAmazonCompetitorAsinStrategyNavigation { get; set; }
        public virtual TMargensteigerung KMargensteigerungNavigation { get; set; }
    }
}
