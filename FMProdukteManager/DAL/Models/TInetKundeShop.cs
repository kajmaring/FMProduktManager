using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TInetKundeShop
    {
        public int KInetKunde { get; set; }
        public int KShop { get; set; }
        public int KKundenGruppe { get; set; }
        public string DKundeSeit { get; set; }
        public string CInet { get; set; }
        public int? KKunde { get; set; }
        public short? NRegistriert { get; set; }
        public string CShopKundenNr { get; set; }
        public byte[] BRowversion { get; set; }
        public int? KSubShop { get; set; }
    }
}
