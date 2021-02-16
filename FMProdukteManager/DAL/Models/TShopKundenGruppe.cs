using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TShopKundenGruppe
    {
        public int KWebShop { get; set; }
        public int KKundenGruppe { get; set; }
        public byte? NStandard { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
