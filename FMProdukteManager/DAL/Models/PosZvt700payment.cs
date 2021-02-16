using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class PosZvt700payment
    {
        public long KZvt700payment { get; set; }
        public long? KUmsaetze { get; set; }
        public DateTime? DDatum { get; set; }
        public string CKartenName { get; set; }
        public double? FBetrag { get; set; }
    }
}
