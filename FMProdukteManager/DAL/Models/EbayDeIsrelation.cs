using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class EbayDeIsrelation
    {
        public int? CategoryId { get; set; }
        public int? KName { get; set; }
        public int? KValue { get; set; }
        public int? KNameParent { get; set; }
        public int? KValueParent { get; set; }
    }
}
