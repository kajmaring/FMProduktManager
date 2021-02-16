using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class ReceiptOfPayment
    {
        public int InternalId { get; set; }
        public string SalesOrderNumber { get; set; }
        public string ExternalSalesOrderNumber { get; set; }
        public string Comment { get; set; }
        public DateTime? PrintingDate { get; set; }
        public DateTime? MailingDate { get; set; }
        public DateTime? CreationDate { get; set; }
        public byte? TermOfPayment { get; set; }
        public string CurrencyIso { get; set; }
        public string Status { get; set; }
        public string PaymentReference { get; set; }
        public decimal ExtraWeight { get; set; }
        public string ShipFromCountryCurrencyIso { get; set; }
        public decimal ShipFromCountryCurrencyFactor { get; set; }
        public string CustomerSalesOrderNumber { get; set; }
        public DateTime? PaymentNotificationDateByEmail { get; set; }
        public DateTime? PaymentDate { get; set; }
        public string PaymentMethodName { get; set; }
        public int LanguageInternalId { get; set; }
        public string ExemptFromVat { get; set; }
        public string Platform { get; set; }
        public int PlatformInternalId { get; set; }
        public bool? DifferentAddresses { get; set; }
        public decimal? TotalGrossPrice { get; set; }
        public decimal? TotalNetPrice { get; set; }
        public string CustomerText { get; set; }
        public decimal? CashDiscount { get; set; }
        public int? CashDiscountValidity { get; set; }
        public decimal? CashDiscountValue { get; set; }
        public int CompanyInternalId { get; set; }
        public bool? IsShippingMethodCod { get; set; }
        public bool? IsPaid { get; set; }
        public string ReasonForRetention { get; set; }
        public bool? IsCancelled { get; set; }
        public byte[] InvoiceAsPdfpath { get; set; }
        public byte[] DeliveryNoteAsPdfpath { get; set; }
        public string ShippingBox { get; set; }
    }
}
