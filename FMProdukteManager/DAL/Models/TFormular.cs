using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TFormular
    {
        public int KFormular { get; set; }
        public int NTyp { get; set; }
        public string CName { get; set; }
        public byte NStandard { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
