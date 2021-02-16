using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class PosKassensturz
    {
        public long KKassensturz { get; set; }
        public long KKasse { get; set; }
        public long KBenutzer { get; set; }
        public DateTime? DDatum { get; set; }
        public long? IInfo { get; set; }
        public byte[] CData { get; set; }
    }
}
