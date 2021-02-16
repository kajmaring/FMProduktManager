using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class PosKassenPlugin
    {
        public int KKassenPlugin { get; set; }
        public int KKasse { get; set; }
        public long? KPlugin { get; set; }
        public long? NIndex { get; set; }
        public string CAktiv { get; set; }
        public byte[] CData1 { get; set; }
        public byte[] CData2 { get; set; }
    }
}
