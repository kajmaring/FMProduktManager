using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class EbayDeCategories
    {
        public int CategoryId { get; set; }
        public int? CategoryParentId { get; set; }
        public byte? CategoryLevel { get; set; }
        public string CategoryName { get; set; }
        public byte B2bvatenabled { get; set; }
        public byte IntlAutosFixedCat { get; set; }
        public byte LeafCategory { get; set; }
        public byte Orpa { get; set; }
        public byte Orra { get; set; }
        public byte Lsd { get; set; }
        public byte? VariationsEnabled { get; set; }
        public byte? ConditionEnabled { get; set; }
        public string ConditionValues { get; set; }
        public byte? ItemSpecificsEnabled { get; set; }
        public byte? AttributeConversionEnabled { get; set; }
    }
}
