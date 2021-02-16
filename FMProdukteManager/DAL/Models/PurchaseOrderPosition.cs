using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class PurchaseOrderPosition
    {
        public int InternalId { get; set; }
        public int PurchaseOrderInternalId { get; set; }
        public int ProductInternalId { get; set; }
        public string Sku { get; set; }
        public string Skusupplier { get; set; }
        public string Name { get; set; }
        public string SupplierName { get; set; }
        public decimal Vatrate { get; set; }
        public decimal Quantity { get; set; }
        public decimal PurchasePriceNetPerUnit { get; set; }
        public decimal? GrossPricePerUnit { get; set; }
        public decimal? TotalGrossPrice { get; set; }
        public decimal? TotalNetPrice { get; set; }
        public decimal? Vatvalue { get; set; }
        public string Note { get; set; }
        public string PositionType { get; set; }
        public string NameOfSupplier { get; set; }
        public int? DeliveryDays { get; set; }
        public int? DeliveryNotePositionInternalId { get; set; }
        public decimal DeliveredQuantity { get; set; }
        public decimal OpenQuantity { get; set; }
    }
}
