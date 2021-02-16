using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TVersandPos
    {
        public int KVersand { get; set; }
        public int KLieferscheinPos { get; set; }
        public decimal FAnzahl { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
