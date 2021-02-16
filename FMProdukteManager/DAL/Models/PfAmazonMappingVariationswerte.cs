using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class PfAmazonMappingVariationswerte
    {
        public int KMappingVariationswerte { get; set; }
        public string CValue { get; set; }
        public string CAmazonValue { get; set; }
        public int? KGroup { get; set; }
    }
}
