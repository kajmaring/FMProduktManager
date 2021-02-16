using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Tpk
    {
        public string CName { get; set; }
        public int? Nummer { get; set; }
        public string DChanged { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
