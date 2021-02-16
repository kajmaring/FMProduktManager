using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Customer
    {
        public int InternalId { get; set; }
        public string CustomerNumber { get; set; }
        public decimal Discount { get; set; }
        public int? AccountsReceivableNumber { get; set; }
        public string CompanyRegistrationNumber { get; set; }
        public string WebsiteUrl { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsLocked { get; set; }
        public bool? IsCashPayer { get; set; }
        public bool? IsRepresentative { get; set; }
        public int? CreditLimit { get; set; }
        public string FederalTaxId { get; set; }
        public int? TermOfPayment { get; set; }
        public string LanguageIso { get; set; }
        public string Source { get; set; }
        public decimal? Credit { get; set; }
        public int? CustomerGroupInternalId { get; set; }
        public string DateOfBirth { get; set; }
        public DateTime? CreationDate { get; set; }
        public string OperationId { get; set; }
        public int? PaymentMethodInternalId { get; set; }
        public int? LanguageInternalId { get; set; }
    }
}
