using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class InvoicePositionDeliveryDetails
    {
        public int? InvoicePositionInternalId { get; set; }
        public decimal? Quantity { get; set; }
        public string BatchNumber { get; set; }
        public DateTime? BestBeforeDate { get; set; }
        public string SerialNumber { get; set; }
    }
}
