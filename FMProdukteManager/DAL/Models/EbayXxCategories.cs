using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class EbayXxCategories
    {
        public int SiteId { get; set; }
        public int CategoryId { get; set; }
        public int CategoryParentId { get; set; }
        public byte CategoryLevel { get; set; }
        public string CategoryName { get; set; }
        public byte LeafCategory { get; set; }
        public byte VariationsEnabled { get; set; }
        public byte ConditionEnabled { get; set; }
        public string ConditionValues { get; set; }
        public byte ItemSpecificsEnabled { get; set; }
        public byte AttributeConversionEnabled { get; set; }
        public byte ItemCompatibilityEnabled { get; set; }
        public string CompatibleVehicleType { get; set; }
        public byte ProductRequiredEnabled { get; set; }
    }
}
