using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class PosgastroItems
    {
        public long KItem { get; set; }
        public long KTisch { get; set; }
        public long? NGast { get; set; }
        public double? FMenge { get; set; }
        public double FPreis { get; set; }
        public DateTime? DErstellung { get; set; }
        public long? NZustand { get; set; }
        public long? NSort { get; set; }
        public byte[] CData { get; set; }
    }
}
