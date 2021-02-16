using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class CustomerGroup
    {
        public int InternalId { get; set; }
        public string Name { get; set; }
        public decimal DiscountInPercent { get; set; }
    }
}
