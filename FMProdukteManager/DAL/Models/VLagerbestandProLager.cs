using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class VLagerbestandProLager
    {
        public int KArtikel { get; set; }
        public int KWarenlager { get; set; }
        public decimal? FBestand { get; set; }
    }
}
