using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TBestellungKampagne
    {
        public int KBestellung { get; set; }
        public string CKampagne { get; set; }
        public string CKampagneWert { get; set; }
        public string CUserAgent { get; set; }
        public string CGeraet { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
