using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class PosBonPositionStorno
    {
        public long KBonPositionStorno { get; set; }
        public long KBonPosition { get; set; }
        public int KBenutzer { get; set; }
        public DateTime DDatum { get; set; }
        public string CText { get; set; }
    }
}
