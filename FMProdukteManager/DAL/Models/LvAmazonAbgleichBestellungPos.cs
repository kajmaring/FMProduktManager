using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class LvAmazonAbgleichBestellungPos
    {
        public int KAmazonBestellung { get; set; }
        public int KAmazonBestellungPos { get; set; }
        public string CArtNr { get; set; }
        public string CArtikelname { get; set; }
        public decimal FItemPrice { get; set; }
        public int NQuantityPurchased { get; set; }
        public DateTime? DShipdate { get; set; }
    }
}
