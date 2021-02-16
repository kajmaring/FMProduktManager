using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class PfAmazonDotLiquidMapping
    {
        public int KDotLiquidMapping { get; set; }
        public int KGroup { get; set; }
        public string CKey { get; set; }
        public string CValue { get; set; }
    }
}
