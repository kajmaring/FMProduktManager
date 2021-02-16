using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class VDeliveryMethod
    {
        public int KDeliveryMethod { get; set; }
        public string CName { get; set; }
        public decimal FPrice { get; set; }
        public decimal FMwSt { get; set; }
        public decimal FVkfreiAb { get; set; }
        public string COrderText { get; set; }
    }
}
