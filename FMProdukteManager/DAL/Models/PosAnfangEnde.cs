using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class PosAnfangEnde
    {
        public int KAnfangEnde { get; set; }
        public DateTime DDatum { get; set; }
        public int KKasse { get; set; }
        public float FStartBetrag { get; set; }
        public float FEndBetrag { get; set; }
        public string CAnfangEndeNr { get; set; }
        public int? KKassenAnfangsBestand { get; set; }
        public DateTime? DDatum2 { get; set; }
    }
}
