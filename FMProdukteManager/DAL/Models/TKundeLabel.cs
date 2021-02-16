using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TKundeLabel
    {
        public int KKunde { get; set; }
        public int KLabel { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
