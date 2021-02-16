using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TFormularAnhangDaten
    {
        public int KFormularAnhangDaten { get; set; }
        public string CDateiname { get; set; }
        public byte[] BSha1 { get; set; }
        public byte[] BDaten { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
