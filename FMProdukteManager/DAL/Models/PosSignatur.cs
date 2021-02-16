using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class PosSignatur
    {
        public long KSignatur { get; set; }
        public DateTime DDatum { get; set; }
        public string CTabelle { get; set; }
        public long KKey { get; set; }
        public byte[] CSignatur { get; set; }
        public string CCheck { get; set; }
    }
}
