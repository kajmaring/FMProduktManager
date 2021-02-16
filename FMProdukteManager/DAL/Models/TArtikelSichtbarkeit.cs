using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TArtikelSichtbarkeit
    {
        public int KArtikel { get; set; }
        public int KKundenGruppe { get; set; }
        public int KShop { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
