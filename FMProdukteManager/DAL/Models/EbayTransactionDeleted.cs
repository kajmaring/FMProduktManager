using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class EbayTransactionDeleted
    {
        public string ItemId { get; set; }
        public string TransactionId { get; set; }
        public DateTime DeletedAt { get; set; }
        public bool? NCheckout { get; set; }
    }
}
