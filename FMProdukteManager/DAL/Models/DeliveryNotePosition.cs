using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class DeliveryNotePosition
    {
        public int InternalId { get; set; }
        public int DeliveryNoteInternalId { get; set; }
        public decimal Quantity { get; set; }
        public string Note { get; set; }
        public string Sku { get; set; }
        public string Jfsku { get; set; }
        public string Name { get; set; }
        public string ItemDescriptionDetailed { get; set; }
        public string ItemDescriptionBrief { get; set; }
        public string Unit { get; set; }
        public string PositionType { get; set; }
        public string ConfiguratorPosition { get; set; }
        public string BillOfMaterialsPosition { get; set; }
        public int? ConfigurationItemInternalId { get; set; }
        public int BillOfMaterialsPositionParentId { get; set; }
        public int ConfiguratorPositionParentId { get; set; }
        public int ProductInternalId { get; set; }
        public string Ean { get; set; }
        public int Sorting { get; set; }
        public decimal NetPricePerUnit { get; set; }
        public decimal? TotalNetPrice { get; set; }
        public decimal? IndividualWeight { get; set; }
        public decimal? TotalShippingWeight { get; set; }
        public bool? IsAmazonCustomPosition { get; set; }
        public string AmazonCustomJson { get; set; }
    }
}
