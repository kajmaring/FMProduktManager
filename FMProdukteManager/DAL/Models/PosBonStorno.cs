using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class PosBonStorno
    {
        public long KBonStorno { get; set; }
        public long KBon { get; set; }
        public int KBenutzer { get; set; }
        public DateTime DDatum { get; set; }
        public string CGrund { get; set; }
    }
}
