using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Platform
    {
        public int InternalId { get; set; }
        public string Name { get; set; }
        public int? Fallback { get; set; }
        public int ShopId { get; set; }
        public int Sort { get; set; }
    }
}
