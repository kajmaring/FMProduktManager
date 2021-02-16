using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TAuftragPositionAttribut
    {
        public int KAuftragPosition { get; set; }
        public string CWert { get; set; }
        public byte NTyp { get; set; }
        public bool NArchiv { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
