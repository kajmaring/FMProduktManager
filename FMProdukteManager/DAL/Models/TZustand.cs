using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TZustand
    {
        public int KZustand { get; set; }
        public string CSuffix { get; set; }
        public byte NAktiv { get; set; }
        public string CColor { get; set; }
        public byte NTyp { get; set; }
        public byte NEinschraenkung { get; set; }
        public int NCode { get; set; }
        public int NEbayCode { get; set; }
        public int NAmazonCode { get; set; }
        public int? NSort { get; set; }
        public byte NLieferantenEntfernen { get; set; }
        public int NFfncode { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
