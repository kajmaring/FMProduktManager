using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class PosHardwareTreiber
    {
        public int KHardwareTreiber { get; set; }
        public string CBezeichnung { get; set; }
        public string CHardwareOid { get; set; }
        public int? CVersion { get; set; }
        public string CTyp { get; set; }
        public string CInfo { get; set; }
        public DateTime DDatum { get; set; }
        public byte[] CData { get; set; }
    }
}
