using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class DeliveryNote
    {
        public int InternalId { get; set; }
        public int UserInternalId { get; set; }
        public string DeliveryNoteNumber { get; set; }
        public string Note { get; set; }
        public string Comment { get; set; }
        public string DeliveryNoteText { get; set; }
        public int CompanyInternalId { get; set; }
        public string SalesOrderNumber { get; set; }
        public int? CustomerInternalId { get; set; }
        public string OperationId { get; set; }
        public DateTime? MailingDate { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? PrintingDate { get; set; }
        public string CountryIso { get; set; }
        public string CurrencyIso { get; set; }
        public string LanguageIso { get; set; }
        public DateTime? ServiceDate { get; set; }
        public bool? HasDeliveryNoteAsPdf { get; set; }
        public byte[] DeliveryNoteData { get; set; }
        public string PaymentMethodType { get; set; }
        public string ValueAddedTaxId { get; set; }
        public decimal? TotalNetPrice { get; set; }
        public decimal? TotalShippingWeight { get; set; }
        public decimal ShippingCosts { get; set; }
        public int? ShippingMethodInternalId { get; set; }
    }
}
