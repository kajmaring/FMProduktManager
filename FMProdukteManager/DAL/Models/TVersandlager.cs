using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TVersandlager
    {
        public int? KWarenlager { get; set; }
        public byte? NTyp { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
