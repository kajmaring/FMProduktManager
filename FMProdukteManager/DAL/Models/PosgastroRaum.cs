using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class PosgastroRaum
    {
        public long KRaum { get; set; }
        public string CName { get; set; }
        public long? CColor { get; set; }
        public long NTischStart { get; set; }
        public long NTischCount { get; set; }
        public long ISpalten { get; set; }
        public long ISpacer { get; set; }
        public byte[] BRaumplan { get; set; }
    }
}
