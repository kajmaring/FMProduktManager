using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TBild
    {
        public int KBild { get; set; }
        public string CQuelle { get; set; }
        public byte[] BBild { get; set; }
        public int NDateigroesse { get; set; }
        public int NBreite { get; set; }
        public int NHoehe { get; set; }
        public string CHash { get; set; }
        public string CChecksum { get; set; }
        public byte[] BVorschauBild { get; set; }
        public int NVorschauDateigroesse { get; set; }
        public int NVorschauBreite { get; set; }
        public int NVorschauHoehe { get; set; }
        public DateTime DErstellt { get; set; }
        public DateTime DAenderung { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
