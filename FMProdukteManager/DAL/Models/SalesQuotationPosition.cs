using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class SalesQuotationPosition
    {
        public int InternalId { get; set; }
        public string Sku { get; set; }
        public string Name { get; set; }
        public string Unit { get; set; }
        public string Note { get; set; }
        public int SalesQuotationInternalId { get; set; }
        public string ItemDescriptionDetailed { get; set; }
        public string ItemDescriptionBrief { get; set; }
        public decimal Quantity { get; set; }
        public decimal Vatrate { get; set; }
        public decimal PurchasePriceNet { get; set; }
        public decimal? GrossPricePerUnit { get; set; }
        public decimal NetPricePerUnit { get; set; }
        public decimal? TotalGrossPrice { get; set; }
        public decimal? TotalNetPrice { get; set; }
        public decimal? Vatvalue { get; set; }
        public decimal? DiscountValue { get; set; }
        public decimal DiscountRate { get; set; }
        public string PositionType { get; set; }
        public string ConfiguratorPosition { get; set; }
        public string BillOfMaterialsPosition { get; set; }
        public int? ConfigurationItemInternalId { get; set; }
        public decimal? IndividualWeight { get; set; }
        public decimal? TotalWeight { get; set; }
        public decimal? IndividualShippingWeight { get; set; }
        public decimal? TotalShippingWeight { get; set; }
        public int Sorting { get; set; }
        public int BillOfMaterialsPositionParentId { get; set; }
        public int ConfiguratorPositionParentId { get; set; }
        public string Ean { get; set; }
        public int? ProductInternalId { get; set; }
    }
}
