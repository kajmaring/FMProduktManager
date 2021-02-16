using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class PosAuswahl
    {
        public long KAuswahl { get; set; }
        public long? KKunde { get; set; }
        public long? KBenutzerAusgabe { get; set; }
        public DateTime? DDatumAusgabe { get; set; }
        public byte[] BData { get; set; }
    }
}
