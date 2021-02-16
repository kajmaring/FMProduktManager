using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TBestellungSperre
    {
        public int? KBestellung { get; set; }
        public string CName { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
