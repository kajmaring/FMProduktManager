using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TKategorieSichtbarkeit
    {
        public int KKategorie { get; set; }
        public int KKundenGruppe { get; set; }
        public int KShop { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
