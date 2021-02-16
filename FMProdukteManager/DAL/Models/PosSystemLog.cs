using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class PosSystemLog
    {
        public long KSystemLog { get; set; }
        public long KKasse { get; set; }
        public DateTime DDatum { get; set; }
        public long? NId { get; set; }
        public string CComputer { get; set; }
        public string CText { get; set; }
        public byte[] CData { get; set; }
        public string CCheck { get; set; }
    }
}
