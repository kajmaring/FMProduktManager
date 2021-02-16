using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TServerConfig
    {
        public string CIpAddress { get; set; }
        public int NPort { get; set; }
        public string CCertificateFingerprint { get; set; }
        public string CCertificateSerialNumber { get; set; }
    }
}
