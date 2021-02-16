using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TPicklisteStatus
    {
        public int KPicklisteStatus { get; set; }
        public int KPickliste { get; set; }
        public int? KBenutzer { get; set; }
        public DateTime? DZeitstempel { get; set; }
        public int? NStatus { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
