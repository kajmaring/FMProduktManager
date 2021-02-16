using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class VLagerbestandStuecklisteProLager
    {
        public int KArtikel { get; set; }
        public string CArtNr { get; set; }
        public int KStueckliste { get; set; }
        public decimal? FLagerbestand { get; set; }
        public decimal? FAuslieferungGesperrt { get; set; }
        public int KWarenlager { get; set; }
    }
}
