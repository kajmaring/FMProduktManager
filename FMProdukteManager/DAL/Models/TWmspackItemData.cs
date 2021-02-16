using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TWmspackItemData
    {
        public int KWmspackItemData { get; set; }
        public int KWmspackItem { get; set; }
        public string CChargenNr { get; set; }
        public DateTime? DMhd { get; set; }
        public string CSerNo { get; set; }
        public decimal FMenge { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
