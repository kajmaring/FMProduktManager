using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TArtikelMerkmal
    {
        public int? KMerkmal { get; set; }
        public int KMerkmalWert { get; set; }
        public int KArtikel { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
