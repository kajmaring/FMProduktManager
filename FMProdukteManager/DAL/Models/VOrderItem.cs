using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class VOrderItem
    {
        public int KOrder { get; set; }
        public int KOrderPos { get; set; }
        public int KProduct { get; set; }
        public decimal FPriceNet { get; set; }
        public decimal FPriceGross { get; set; }
        public decimal FVat { get; set; }
        public decimal NQuantity { get; set; }
        public string CName { get; set; }
        public string CSku { get; set; }
        public string CUnit { get; set; }
        public byte? NType { get; set; }
        public decimal FDiscount { get; set; }
        public string CNote { get; set; }
        public decimal FPurchasePriceNet { get; set; }
        public string CUniqueId { get; set; }
        public int? KConfigurationitem { get; set; }
    }
}
