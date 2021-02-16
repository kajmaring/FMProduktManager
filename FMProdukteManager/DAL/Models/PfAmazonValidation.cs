using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class PfAmazonValidation
    {
        public string CName { get; set; }
        public int? MinLength { get; set; }
        public int? MaxLength { get; set; }
        public string CPattern { get; set; }
        public string CType { get; set; }
        public int? ArraySize { get; set; }
        public int? MinOccurs { get; set; }
        public int? MaxOccurs { get; set; }
    }
}
