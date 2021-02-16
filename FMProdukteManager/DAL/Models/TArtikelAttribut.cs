using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TArtikelAttribut
    {
        public int KArtikelAttribut { get; set; }
        public int KArtikel { get; set; }
        public int KAttribut { get; set; }
        public int KShop { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
