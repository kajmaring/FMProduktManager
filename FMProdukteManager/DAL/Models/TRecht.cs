using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TRecht
    {
        public int KRecht { get; set; }
        public string CAnzeigeName { get; set; }
        public string CBeschreibung { get; set; }
        public int? KRechtVater { get; set; }
        public byte? NIstLabel { get; set; }
        public int? NSort { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
