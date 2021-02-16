using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class PosTeleCashPayment
    {
        public long KTeleCashPayment { get; set; }
        public long? KUmsaetze { get; set; }
        public DateTime? DDatum { get; set; }
        public long? NBelegNummer { get; set; }
        public string CKartenName { get; set; }
        public double? FBetrag { get; set; }
    }
}
