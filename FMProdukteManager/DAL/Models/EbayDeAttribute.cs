using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class EbayDeAttribute
    {
        public int? AttributeId { get; set; }
        public int? AttributeSetId { get; set; }
        public int? ParentAttrId { get; set; }
        public int? DefaultValueId { get; set; }
        public string Label { get; set; }
        public string LabelVisible { get; set; }
        public string IsRequired { get; set; }
        public string DateFormat { get; set; }
        public string WhenToShow { get; set; }
        public byte? EditType { get; set; }
        public byte? Type { get; set; }
        public byte? PresentationType { get; set; }
        public byte Maxlength { get; set; }
        public byte Ordernumber { get; set; }
    }
}
