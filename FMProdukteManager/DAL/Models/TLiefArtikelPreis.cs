using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TLiefArtikelPreis
    {
        public int KLiefArtikelPreis { get; set; }
        public int KLiefArtikel { get; set; }
        public decimal FAb { get; set; }
        public decimal FPreisNetto { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
