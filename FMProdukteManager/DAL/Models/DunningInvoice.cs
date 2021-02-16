using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class DunningInvoice
    {
        public int InternalId { get; set; }
        public string InvoiceNumber { get; set; }
        public DateTime? PrintingDate { get; set; }
        public DateTime? MailingDate { get; set; }
        public DateTime? CreationDate { get; set; }
        public decimal? TotalGrossPrice { get; set; }
        public decimal? OpenGrossPrice { get; set; }
        public string CurrencyIso { get; set; }
    }
}
