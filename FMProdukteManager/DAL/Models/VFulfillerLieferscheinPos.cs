using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class VFulfillerLieferscheinPos
    {
        public int KBestellung { get; set; }
        public int KLieferschein { get; set; }
        public int KLieferscheinPos { get; set; }
        public string CJfsku { get; set; }
        public decimal FQuantity { get; set; }
        public string CNote { get; set; }
        public string CBatch { get; set; }
        public DateTime? DBestBefore { get; set; }
        public int KWarenLager { get; set; }
        public string CSerialNumbers { get; set; }
    }
}
