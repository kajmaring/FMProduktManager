using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class EbayCheckoutpos
    {
        public int KEbayCheckoutPos { get; set; }
        public int? KEbayCheckout { get; set; }
        public string ItemId { get; set; }
        public string TransactionId { get; set; }
        public int? KXcheckoutPos { get; set; }
        public decimal FAnzahl { get; set; }
        public decimal FPreis { get; set; }
        public int? KArtikel { get; set; }
    }
}
