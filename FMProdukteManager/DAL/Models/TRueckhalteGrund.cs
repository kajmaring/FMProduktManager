using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TRueckhalteGrund
    {
        public int KRueckhalteGrund { get; set; }
        public string CName { get; set; }
        public byte NZusammenfassbar { get; set; }
        public byte NEinkaufslisteGesperrt { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
