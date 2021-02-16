using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TLieferantErlaubteLieferlaender
    {
        public int KLieferant { get; set; }
        public string CIso { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
