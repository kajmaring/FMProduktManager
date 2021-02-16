using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TWaehrungAlt
    {
        public int KWaehrung { get; set; }
        public DateTime? DAktualisiert { get; set; }
        public decimal FFaktorAlt { get; set; }
        public decimal FFaktorNeu { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
