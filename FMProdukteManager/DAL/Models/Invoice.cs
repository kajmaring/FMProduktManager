using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Invoice
    {
        public int InternalId { get; set; }
        public string InvoiceNumber { get; set; }
        public int? CompanyInternalId { get; set; }
        public DateTime? PrintingDate { get; set; }
        public DateTime? MailingDate { get; set; }
        public DateTime? CreationDate { get; set; }
        public string InvoicePrintingText { get; set; }
        public string MandateReference { get; set; }
        public int? CustomerInternalId { get; set; }
        public decimal? TotalGrossPrice { get; set; }
        public decimal? TotalNetPrice { get; set; }
        public decimal? OpenGrossPrice { get; set; }
        public string ShipFromCountryIso { get; set; }
        public string ShipFromCountryCurrencyIso { get; set; }
        public decimal? ShipFromCountryCurrencyFactor { get; set; }
        public string CountryIso { get; set; }
        public string CurrencyIso { get; set; }
        public decimal? CurrencyFactor { get; set; }
        public string TaxCountryIso { get; set; }
        public string TaxCountryCurrencyIso { get; set; }
        public decimal? TaxCountryCurrencyFactor { get; set; }
        public byte? TermOfPayment { get; set; }
        public string OperationId { get; set; }
        public decimal? CashDiscount { get; set; }
        public int? CashDiscountValidity { get; set; }
        public string PaymentMethodName { get; set; }
        public bool? IsExternalInvoice { get; set; }
        public int? ShippingMethodInternalId { get; set; }
        public string ExemptFromVat { get; set; }
        public decimal? FinancingCosts { get; set; }
        public DateTime? ServiceDate { get; set; }
        public int UserInternalId { get; set; }
        public string ValueAddedTaxId { get; set; }
        public string LanguageIso { get; set; }
        public DateTime? ValutaDate { get; set; }
        public string ShopName { get; set; }
        public bool? UseNetPrice { get; set; }
        public bool? HasInvoiceAsPdf { get; set; }
        public byte[] InvoiceData { get; set; }
        public string Comment { get; set; }
        public string InvoiceNote { get; set; }
    }
}
