using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TLieferscheinPos
    {
        public int KLieferscheinPos { get; set; }
        public int KLieferschein { get; set; }
        public int? KBestellPos { get; set; }
        public decimal FAnzahl { get; set; }
        public string CHinweis { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
