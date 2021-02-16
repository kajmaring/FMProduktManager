using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TWmsbyLight
    {
        public int KWmsbyLight { get; set; }
        public string CId { get; set; }
        public int KBenutzer { get; set; }
        public int KWarenlager { get; set; }
        public DateTime DZeitstempel { get; set; }
        public byte NTyp { get; set; }
        public byte NAktiv { get; set; }
        public string CArbeitsPlatz { get; set; }
        public int? KPickliste { get; set; }
        public decimal? FPickAnzahl { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
