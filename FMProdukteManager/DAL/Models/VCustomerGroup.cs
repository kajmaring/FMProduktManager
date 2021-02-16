using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class VCustomerGroup
    {
        public int KCustomerGroup { get; set; }
        public string CName { get; set; }
        public byte? NStandard { get; set; }
        public decimal FDiscountPercent { get; set; }
        public byte[] BLastChanged { get; set; }
        public int KShop { get; set; }
        public DateTime? DLastModified { get; set; }
        public DateTime? DActive { get; set; }
        public DateTime? DInactive { get; set; }
    }
}
