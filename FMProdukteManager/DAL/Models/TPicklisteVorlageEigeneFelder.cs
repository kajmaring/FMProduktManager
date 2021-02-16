using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TPicklisteVorlageEigeneFelder
    {
        public int KPicklisteVorlage { get; set; }
        public int KAttribut { get; set; }
        public string CWert { get; set; }
        public byte[] BRowversion { get; set; }
        public int? NWertInt { get; set; }
        public decimal? FWertDecimal { get; set; }
        public DateTime? DWertDateTime { get; set; }
    }
}
