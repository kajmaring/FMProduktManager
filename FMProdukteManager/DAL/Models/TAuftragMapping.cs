using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TAuftragMapping
    {
        public int? KAuftrag { get; set; }
        public int KPosAuftrag { get; set; }
        public int KShopSubShop { get; set; }
    }
}
