using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class PosLog
    {
        public long KLog { get; set; }
        public DateTime? DDatum { get; set; }
        public long? KKasse { get; set; }
        public long? KBenutzer { get; set; }
        public string CBenutzer { get; set; }
        public long? KWawiBenutzer { get; set; }
        public long? NType { get; set; }
        public string CCheck { get; set; }
        public long? I1 { get; set; }
        public long? I2 { get; set; }
        public long? I3 { get; set; }
        public long? I4 { get; set; }
        public long? I5 { get; set; }
        public double? F1 { get; set; }
        public double? F2 { get; set; }
        public double? F3 { get; set; }
        public double? F4 { get; set; }
        public double? F5 { get; set; }
        public string S1 { get; set; }
        public string S2 { get; set; }
        public string S3 { get; set; }
        public string S4 { get; set; }
        public string S5 { get; set; }
        public DateTime? D1 { get; set; }
        public DateTime? D2 { get; set; }
        public DateTime? D3 { get; set; }
        public DateTime? D4 { get; set; }
        public DateTime? D5 { get; set; }
        public string C1 { get; set; }
        public string C2 { get; set; }
        public string C3 { get; set; }
        public string C4 { get; set; }
        public string C5 { get; set; }
        public short? B1 { get; set; }
        public short? B2 { get; set; }
        public short? B3 { get; set; }
        public short? B4 { get; set; }
        public short? B5 { get; set; }
        public byte[] CData { get; set; }
    }
}
