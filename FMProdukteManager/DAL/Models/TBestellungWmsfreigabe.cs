using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TBestellungWmsfreigabe
    {
        public int KBestellungWmsfreigabe { get; set; }
        public int? KBestellung { get; set; }
        public DateTime? DZeitstempel { get; set; }
        public int? KBenutzer { get; set; }
        public int? NTeillieferungErlaubt { get; set; }
        public int? NVorkommissionieren { get; set; }
        public int? NAktiv { get; set; }
        public byte? NSperre { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
