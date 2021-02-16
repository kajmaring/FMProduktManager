using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TInteropQueue
    {
        public int NKey1 { get; set; }
        public int NOperation { get; set; }
        public int? NKey2 { get; set; }
        public string CUnique { get; set; }
        public string CData { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
