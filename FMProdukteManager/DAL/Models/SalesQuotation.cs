using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class SalesQuotation
    {
        public int InternalId { get; set; }
        public string SalesQuotationNumber { get; set; }
        public string Comment { get; set; }
        public DateTime? PrintingDate { get; set; }
        public DateTime? MailingDate { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? ServiceDate { get; set; }
        public byte? TermOfPayment { get; set; }
        public string ShipFromCountryIso { get; set; }
        public string ShipFromCountryCurrencyIso { get; set; }
        public decimal ShipFromCountryCurrencyFactor { get; set; }
        public string CountryIso { get; set; }
        public string CurrencyIso { get; set; }
        public decimal CurrencyFactor { get; set; }
        public string TaxCountryIso { get; set; }
        public string TaxCountryCurrencyIso { get; set; }
        public decimal TaxCountryCurrencyFactor { get; set; }
        public string Status { get; set; }
        public string PaymentReference { get; set; }
        public decimal ExtraWeight { get; set; }
        public string PaymentInfo { get; set; }
        public string CustomerSalesQuotationNumber { get; set; }
        public int LanguageInternalId { get; set; }
        public string OperationId { get; set; }
        public bool? IsShippingMethodCod { get; set; }
        public string PaymentMethodName { get; set; }
        public string ExemptFromVat { get; set; }
        public string Platform { get; set; }
        public decimal? FinancingCosts { get; set; }
        public string CustomerNumber { get; set; }
        public bool? UseNetPrice { get; set; }
        public bool? DifferentAddresses { get; set; }
        public decimal? TotalGrossPrice { get; set; }
        public decimal? TotalNetPrice { get; set; }
        public string CustomerText { get; set; }
        public decimal? CashDiscountValue { get; set; }
        public decimal? CashDiscount { get; set; }
        public int? CashDiscountValidity { get; set; }
        public int CompanyInternalId { get; set; }
        public int? CustomerInternalId { get; set; }
        public string LanguageIso { get; set; }
        public int UserInternalId { get; set; }
        public string ValueAddedTaxId { get; set; }
    }
}
