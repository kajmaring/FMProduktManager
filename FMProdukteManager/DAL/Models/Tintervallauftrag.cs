using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Tintervallauftrag
    {
        public int? KIntervall { get; set; }
        public DateTime? DStart { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
