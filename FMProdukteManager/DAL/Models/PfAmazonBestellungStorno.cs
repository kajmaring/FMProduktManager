using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class PfAmazonBestellungStorno
    {
        public int KAmazonBestellungStorno { get; set; }
        public string COrderId { get; set; }
        public byte NCancelReason { get; set; }
        public DateTime DErstellt { get; set; }
        public DateTime? DBearbeitet { get; set; }
        public int KBenutzer { get; set; }
    }
}
