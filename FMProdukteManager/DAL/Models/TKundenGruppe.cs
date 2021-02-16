using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TKundenGruppe
    {
        public int KKundenGruppe { get; set; }
        public string CName { get; set; }
        public byte? NStandard { get; set; }
        public byte? NShopLogin { get; set; }
        public byte? NNettoPreise { get; set; }
        public decimal FRabatt { get; set; }
        public int? KKundenDrucktext { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
