using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class PfAmazonBestellungVersand
    {
        public int KAmazonBestellungVersand { get; set; }
        public int? KAmazonBestellungPos { get; set; }
        public int? KLieferschein { get; set; }
        public int? NQuantity { get; set; }
        public int? KBenutzer { get; set; }
        public string CCarrierCode { get; set; }
        public string CCarrierName { get; set; }
        public string CTrackingNumber { get; set; }
        public string CShipMethod { get; set; }
        public DateTime? DShipDate { get; set; }
        public DateTime? DBearbeitet { get; set; }
    }
}
