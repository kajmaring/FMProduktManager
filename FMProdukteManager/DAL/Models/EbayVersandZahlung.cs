using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class EbayVersandZahlung
    {
        public int KEbayVersandZahlung { get; set; }
        public int KEbayUser { get; set; }
        public string COrderId { get; set; }
        public string CItemId { get; set; }
        public string CTransactionId { get; set; }
        public int NPaymentSuccessful { get; set; }
        public int NShippingSuccessful { get; set; }
        public string CPaymentErrorMessage { get; set; }
        public string CShippingErrorMessage { get; set; }
        public DateTime DUpdatedAt { get; set; }
        public DateTime DCreatedAt { get; set; }
    }
}
