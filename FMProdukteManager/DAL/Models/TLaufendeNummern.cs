using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TLaufendeNummern
    {
        public int KLaufendeNummer { get; set; }
        public string CName { get; set; }
        public int? NNummer { get; set; }
        public string CPrefix { get; set; }
        public string CSuffix { get; set; }
        public int? KFirma { get; set; }
        public string CTable { get; set; }
        public string CColumn { get; set; }
        public byte[] BRowversion { get; set; }
        public string CAnzeigename { get; set; }
    }
}
