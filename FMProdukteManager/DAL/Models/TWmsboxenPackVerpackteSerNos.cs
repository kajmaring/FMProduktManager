using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TWmsboxenPackVerpackteSerNos
    {
        public int KWmsboxenPackVerpackteSerNos { get; set; }
        public int KBestellung { get; set; }
        public int KBestellPos { get; set; }
        public int KArtikel { get; set; }
        public string CSerNo { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
