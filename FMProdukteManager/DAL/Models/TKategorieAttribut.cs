using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TKategorieAttribut
    {
        public int KKategorieAttribut { get; set; }
        public int KKategorie { get; set; }
        public int KAttribut { get; set; }
        public int KShop { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
