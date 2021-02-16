using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TLhmstatus
    {
        public int KLhmstatus { get; set; }
        public int KLhm { get; set; }
        public int NStatus { get; set; }
        public DateTime? DZeitstempel { get; set; }
        public int? KBestellung { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
