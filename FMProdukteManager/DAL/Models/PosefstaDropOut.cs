using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class PosefstaDropOut
    {
        public long KEfstaDropOut { get; set; }
        public long? KEfstaBeleg { get; set; }
        public long KBon { get; set; }
        public long KKasse { get; set; }
        public long KBenutzer { get; set; }
        public DateTime? DErstellung { get; set; }
        public DateTime? DLoesung { get; set; }
        public byte[] CData { get; set; }
    }
}
