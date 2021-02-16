using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class PosLaufendeNummern
    {
        public int KLaufendeNummer { get; set; }
        public long KKasse { get; set; }
        public string CName { get; set; }
        public int? NNummer { get; set; }
        public string CPrefix { get; set; }
        public string CSuffix { get; set; }
        public string CTable { get; set; }
        public string CField { get; set; }
    }
}
