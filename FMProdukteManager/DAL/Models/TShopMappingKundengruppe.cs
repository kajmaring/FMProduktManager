using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TShopMappingKundengruppe
    {
        public int KKundengruppe { get; set; }
        public int KShop { get; set; }
        public string CPkshop { get; set; }
        public string CNameShop { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
