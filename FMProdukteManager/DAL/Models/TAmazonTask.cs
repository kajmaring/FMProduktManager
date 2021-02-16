using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TAmazonTask
    {
        public int KAmazonTask { get; set; }
        public string CSku { get; set; }
        public int NPlattform { get; set; }
        public int? KAmazonBuyBoxStrategy { get; set; }
        public int? KAmazonCompetitorAsinStrategy { get; set; }
        public byte NAktiveStrategie { get; set; }
        public byte NRepricingAktiv { get; set; }
        public bool NGeaendert { get; set; }
        public DateTime? DZuletztGesendet { get; set; }
        public int KUser { get; set; }
        public byte NDeaktiviertDurchBestand { get; set; }
        public int? KMargensteigerung { get; set; }
        public int? KAbverkauf { get; set; }

        public virtual TAmazonBuyBoxStrategy KAmazonBuyBoxStrategyNavigation { get; set; }
        public virtual TAmazonCompetitorAsinStrategy KAmazonCompetitorAsinStrategyNavigation { get; set; }
        public virtual PfUser KUserNavigation { get; set; }
    }
}
