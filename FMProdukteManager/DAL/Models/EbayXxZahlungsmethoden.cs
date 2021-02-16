using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class EbayXxZahlungsmethoden
    {
        public int SiteId { get; set; }
        public string PaymentOption { get; set; }
        public string DisplayText { get; set; }
    }
}
