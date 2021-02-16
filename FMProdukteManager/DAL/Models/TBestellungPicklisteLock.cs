using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TBestellungPicklisteLock
    {
        public int KBestellung { get; set; }
        public int KPickliste { get; set; }
        public DateTime? DZeitstempel { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
