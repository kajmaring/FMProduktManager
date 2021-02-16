using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TBestellvorschlagPlugin
    {
        public int KBestellvorschlagPlugin { get; set; }
        public string CName { get; set; }
        public string CAnzeigeName { get; set; }
        public string CHersteller { get; set; }
        public string CVersion { get; set; }
        public string CBeschreibung { get; set; }
        public string CFunctionName { get; set; }
        public string CParameter { get; set; }
        public byte[] BIcon { get; set; }
        public byte[] BIconSelektiert { get; set; }
    }
}
