using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class VWarehouseMerchant
    {
        public int Pk { get; set; }
        public int WarehouseKey { get; set; }
        public string MerchantId { get; set; }
        public int MerchantKey { get; set; }
    }
}
