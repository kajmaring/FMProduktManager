using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TotalsPurchaseOrder
    {
        public int PurchaseOrderInternalId { get; set; }
        public decimal Vatrate { get; set; }
        public decimal? Vatsum { get; set; }
        public decimal? GrossPriceTotal { get; set; }
        public decimal? NetPriceTotal { get; set; }
        public decimal? GrossPriceShippingPositionTotal { get; set; }
        public decimal? NetPriceShippingPositionTotal { get; set; }
        public decimal? GrossPriceShippingSurchargeTotal { get; set; }
        public decimal? NetPriceShippingSurchargeTotal { get; set; }
        public decimal? GrossPriceDiscountTotal { get; set; }
        public decimal? NetPriceDiscountTotal { get; set; }
        public decimal? GrossPriceMinimumQuantitySurchargeTotal { get; set; }
        public decimal? NetPriceMinimumQuantitySurchargeTotal { get; set; }
        public decimal? ShippingCostsVat { get; set; }
    }
}
