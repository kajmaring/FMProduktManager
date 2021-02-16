using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TVersand
    {
        public TVersand()
        {
            TMerchantVersandRef = new HashSet<TMerchantVersandRef>();
            TPackage = new HashSet<TPackage>();
        }

        public int KVersand { get; set; }
        public int KLieferschein { get; set; }
        public int KBenutzer { get; set; }
        public int? KLogistik { get; set; }
        public string CIdentCode { get; set; }
        public DateTime? DErstellt { get; set; }
        public string CHinweis { get; set; }
        public decimal FGewicht { get; set; }
        public int? KVersandArt { get; set; }
        public string CLogistiker { get; set; }
        public string CFulfillmentCenter { get; set; }
        public DateTime? DAnkunftszeit { get; set; }
        public int? NVerpackZeitSek { get; set; }
        public DateTime? DVersendet { get; set; }
        public byte NStatus { get; set; }
        public string CShipmentId { get; set; }
        public string CReference { get; set; }
        public string CShipmentOrderId { get; set; }
        public byte[] BRowversion { get; set; }
        public string CEnclosedReturnIdentCode { get; set; }
        public int NViaAmazonMws { get; set; }

        public virtual ICollection<TMerchantVersandRef> TMerchantVersandRef { get; set; }
        public virtual ICollection<TPackage> TPackage { get; set; }
    }
}
