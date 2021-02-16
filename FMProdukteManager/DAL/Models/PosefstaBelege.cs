using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class PosefstaBelege
    {
        public long KEfstaBeleg { get; set; }
        public long KKasse { get; set; }
        public long KBenutzer { get; set; }
        public DateTime? DDatum { get; set; }
        public string CInfo { get; set; }
        public long NTyp { get; set; }
        public byte[] CData { get; set; }
        public byte[] CData2 { get; set; }
        public string CTable { get; set; }
        public string CField { get; set; }
        public long? KKey { get; set; }
    }
}
