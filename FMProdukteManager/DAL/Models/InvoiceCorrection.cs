using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class InvoiceCorrection
    {
        public int InternalId { get; set; }
        public int? InvoiceInternalId { get; set; }
        public int? CustomerInternalId { get; set; }
        public string InvoiceCorrectionNumber { get; set; }
        public DateTime? PrintingDate { get; set; }
        public DateTime? MailingDate { get; set; }
        public string ShortText { get; set; }
        public string Text { get; set; }
        public decimal Price { get; set; }
        public decimal? TotalGrossPrice { get; set; }
        public decimal? TotalNetPrice { get; set; }
        public string CurrencyIso { get; set; }
        public decimal CurrencyFactor { get; set; }
        public int? CompanyInternalId { get; set; }
        public int? LanguageInternalId { get; set; }
        public int? UserInternalId { get; set; }
        public string Status { get; set; }
        public int? PlatformInternalId { get; set; }
        public string ShipFromCountryCurrencyIso { get; set; }
        public decimal ShipFromCountryCurrencyFactor { get; set; }
        public string InvoiceNumber { get; set; }
        public DateTime? CreationDate { get; set; }
        public string InvoiceCorrectionText { get; set; }
        public string OperationId { get; set; }
        public string LanguageIso { get; set; }
        public string ExemptFromVat { get; set; }
        public string ShipFromCountryIso { get; set; }
        public string TaxCountryCurrencyIso { get; set; }
        public decimal TaxCountryCurrencyFactor { get; set; }
        public string TaxCountryIso { get; set; }
        public string CountryIso { get; set; }
        public bool? UseNetPrice { get; set; }
        public string ValueAddedTaxId { get; set; }
    }
}
