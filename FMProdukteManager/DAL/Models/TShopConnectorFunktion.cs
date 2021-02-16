using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TShopConnectorFunktion
    {
        public int KShop { get; set; }
        public int NTyp { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
