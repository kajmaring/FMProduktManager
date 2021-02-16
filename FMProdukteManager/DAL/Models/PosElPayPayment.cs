using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class PosElPayPayment
    {
        public long KelPayPayment { get; set; }
        public long? KUmsaetze { get; set; }
        public DateTime? DDatum { get; set; }
        public long? NBelegNummer { get; set; }
        public string CKartenName { get; set; }
        public string CWaehrung { get; set; }
        public double? FBetrag { get; set; }
        public byte[] CData { get; set; }
    }
}
