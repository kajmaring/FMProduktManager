using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class DunningInvoicePayments
    {
        public int InternalId { get; set; }
        public int? InvoiceInternalId { get; set; }
        public string ExternalTransactionId { get; set; }
        public string Note { get; set; }
        public string Name { get; set; }
        public decimal Value { get; set; }
        public DateTime? PaymentDate { get; set; }
        public string PaymentType { get; set; }
        public string PaymentMethod { get; set; }
        public string StandardChartOfAccountsManual { get; set; }
    }
}
