using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Dunning
    {
        public int InternalId { get; set; }
        public int InvoiceInternalId { get; set; }
        public int CompanyInternalId { get; set; }
        public int CustomerGroupInternalId { get; set; }
        public DateTime? PaymentTermDate { get; set; }
        public DateTime? CompletionDate { get; set; }
        public int? PaymentTerm { get; set; }
        public DateTime? DunningDate { get; set; }
        public decimal DunningFee { get; set; }
        public decimal FlatRateDunningFee { get; set; }
        public decimal FeeInterestRate { get; set; }
        public decimal? GrossValue { get; set; }
        public int? UserInternalId { get; set; }
        public string CurrencyIso { get; set; }
        public string DunningLevelName { get; set; }
        public byte NumberDunningRepitions { get; set; }
        public int? GracePeriod { get; set; }
        public string OperationId { get; set; }
        public DateTime? CreationDate { get; set; }
        public string ValueAddedTaxId { get; set; }
        public string CountryIso { get; set; }
        public string LanguageIso { get; set; }
    }
}
