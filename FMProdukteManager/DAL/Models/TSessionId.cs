using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TSessionId
    {
        public int KSessionId { get; set; }
        public string CRechnername { get; set; }
        public int KBenutzer { get; set; }
        public DateTime DLastAction { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
