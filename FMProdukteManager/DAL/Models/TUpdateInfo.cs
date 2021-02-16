using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TUpdateInfo
    {
        public int KUpdateInfo { get; set; }
        public byte NVorgang { get; set; }
        public string CKey { get; set; }
        public string CValueOld { get; set; }
        public string CValueNew { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
