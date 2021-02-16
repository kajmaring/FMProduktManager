using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class PfAmazonVcsHistory
    {
        public int KMessageId { get; set; }
        public int KUser { get; set; }
        public string MarketplaceId { get; set; }
        public string MerchantId { get; set; }
        public DateTime? OrderDate { get; set; }
        public string TransactionType { get; set; }
        public string OrderId { get; set; }
        public DateTime? ShipmentDate { get; set; }
        public string ShipmentId { get; set; }
        public string TransactionId { get; set; }
        public string Asin { get; set; }
        public string Sku { get; set; }
        public int? Quantity { get; set; }
        public DateTime? TaxCalculationDate { get; set; }
        public decimal? TaxRate { get; set; }
        public string ProductTaxCode { get; set; }
        public string Currency { get; set; }
        public string TaxType { get; set; }
        public string TaxCalculationReasonCode { get; set; }
        public string TaxAddressRole { get; set; }
        public string JurisdictionLevel { get; set; }
        public string JurisdictionName { get; set; }
        public decimal? OurPricetaxInclusiveSellingPrice { get; set; }
        public decimal? OurPricetaxAmount { get; set; }
        public decimal? OurPricetaxExclusiveSellingPrice { get; set; }
        public decimal? OurPricetaxInclusivePromoAmount { get; set; }
        public decimal? OurPricetaxAmountPromo { get; set; }
        public decimal? OurPricetaxExclusivePromoAmount { get; set; }
        public decimal? ShippingtaxInclusiveSellingPrice { get; set; }
        public decimal? ShippingtaxAmount { get; set; }
        public decimal? ShippingtaxExclusiveSellingPrice { get; set; }
        public decimal? ShippingtaxInclusivePromoAmount { get; set; }
        public decimal? ShippingtaxAmountPromo { get; set; }
        public decimal? ShippingtaxExclusivePromoAmount { get; set; }
        public decimal? GiftwraptaxInclusiveSellingPrice { get; set; }
        public decimal? GiftwraptaxAmount { get; set; }
        public decimal? GiftwraptaxExclusiveSellingPrice { get; set; }
        public decimal? GiftwraptaxInclusivePromoAmount { get; set; }
        public decimal? GiftwraptaxAmountPromo { get; set; }
        public decimal? GiftwraptaxExclusivePromoAmount { get; set; }
        public string SellerTaxRegistration { get; set; }
        public string SellerTaxRegistrationJurisdiction { get; set; }
        public string BuyerTaxRegistration { get; set; }
        public string BuyerTaxRegistrationJurisdiction { get; set; }
        public string InvoiceLevelCurrencyCode { get; set; }
        public decimal? InvoiceLevelExchangeRate { get; set; }
        public DateTime? InvoiceLevelExchangeRateDate { get; set; }
        public decimal? ConvertedTaxAmount { get; set; }
        public string VatinvoiceNumber { get; set; }
        public string InvoiceUrl { get; set; }
        public string ExportOutsideEu { get; set; }
        public string ShipFromCity { get; set; }
        public string ShipFromState { get; set; }
        public string ShipFromCountry { get; set; }
        public string ShipFromPostalCode { get; set; }
        public string ShipFromTaxLocationCode { get; set; }
        public string ShipToCity { get; set; }
        public string ShipToState { get; set; }
        public string ShipToCountry { get; set; }
        public string ShipToPostalCode { get; set; }
        public string ShipToLocationCode { get; set; }
        public string ReturnFcCountry { get; set; }
    }
}
