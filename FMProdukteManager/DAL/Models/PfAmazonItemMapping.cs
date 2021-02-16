using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class PfAmazonItemMapping
    {
        public int KItemMapping { get; set; }
        public int KItem { get; set; }
        public string CKey { get; set; }
        public string CValue { get; set; }
    }
}
