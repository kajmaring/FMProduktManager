using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Tartikelkonfiggruppe
    {
        public int KArtikelkonfiggruppe { get; set; }
        public int KArtikel { get; set; }
        public int KKonfiggruppe { get; set; }
        public int NSort { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
