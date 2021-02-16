using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class PosKassenKonfiguration
    {
        public int KKassenkonfiguration { get; set; }
        public int KKasse { get; set; }
        public byte[] CData { get; set; }
    }
}
