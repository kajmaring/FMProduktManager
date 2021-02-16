using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TLieferantWarenlager
    {
        public int KLieferantWarenlager { get; set; }
        public int KLieferant { get; set; }
        public int KWarenlager { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
