using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class SalesOrder
    {
        public int InternalId { get; set; }
        public string SalesOrderNumber { get; set; }
        public string ExternalSalesOrderNumber { get; set; }
        public string Comment { get; set; }
        public DateTime? PrintingDate { get; set; }
        public DateTime? MailingDate { get; set; }
        public DateTime? CreationDate { get; set; }
        public byte? TermOfPayment { get; set; }
        public string Status { get; set; }
        public string PaymentReference { get; set; }
        public decimal ExtraWeight { get; set; }
        public string ShipFromCountryIso { get; set; }
        public string ShipFromCountryCurrencyIso { get; set; }
        public decimal ShipFromCountryCurrencyFactor { get; set; }
        public string CountryIso { get; set; }
        public string CurrencyIso { get; set; }
        public decimal CurrencyFactor { get; set; }
        public decimal? OpenGrossPrice { get; set; }
        public string TaxCountryIso { get; set; }
        public string TaxCountryCurrencyIso { get; set; }
        public decimal TaxCountryCurrencyFactor { get; set; }
        public string CustomerSalesOrderNumber { get; set; }
        public DateTime? PaymentNotificationDateByEmail { get; set; }
        public DateTime? PaymentDate { get; set; }
        public DateTime? ServiceDate { get; set; }
        public string OperationId { get; set; }
        public string PaymentMethodName { get; set; }
        public int LanguageInternalId { get; set; }
        public string ExemptFromVat { get; set; }
        public string Platform { get; set; }
        public int PlatformInternalId { get; set; }
        public bool? DifferentAddresses { get; set; }
        public decimal? TotalGrossPrice { get; set; }
        public decimal? TotalNetPrice { get; set; }
        public int? CustomerInternalId { get; set; }
        public string CustomerText { get; set; }
        public bool? UseNetPrice { get; set; }
        public decimal? CashDiscount { get; set; }
        public int? CashDiscountValidity { get; set; }
        public decimal? CashDiscountValue { get; set; }
        public int CompanyInternalId { get; set; }
        public bool? IsShippingMethodCod { get; set; }
        public bool? IsPaid { get; set; }
        public string ReasonForRetention { get; set; }
        public bool? IsCancelled { get; set; }
        public decimal? FinancingCosts { get; set; }
        public byte[] InvoiceAsPdfpath { get; set; }
        public byte[] DeliveryNoteAsPdfpath { get; set; }
        public string ShippingBox { get; set; }
        public bool IstExterneRechnung { get; set; }
        public int? ShippingMethodInternalId { get; set; }
        public string LanguageIso { get; set; }
        public string SalesOrderNote { get; set; }
        public int? Priority { get; set; }
        public int UserInternalId { get; set; }
        public string ValueAddedTaxId { get; set; }
        public bool? HasInvoiceAsPdf { get; set; }
        public bool? HasDeliveryNoteAsPdf { get; set; }
        public string OrderType { get; set; }
    }
}
