using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class VWarenlagerEingang
    {
        public int KBestellPos { get; set; }
        public int KWarenlager { get; set; }
        public int KWarenlagerEingang { get; set; }
        public string CChargenNr { get; set; }
        public DateTime? DMhd { get; set; }
        public decimal? FAnzahl { get; set; }
        public int? KSessionId { get; set; }
    }
}
