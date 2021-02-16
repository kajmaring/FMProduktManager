using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class PfAmazonLagerbewegung
    {
        public int KAmazonLagerbewegung { get; set; }
        public int KUser { get; set; }
        public int KArtikel { get; set; }
        public int NMenge { get; set; }
        public string CFulfillmentCenter { get; set; }
        public DateTime? DSnapshot { get; set; }
        public byte? NStatus { get; set; }
        public string CTransactionType { get; set; }
        public int? KMessageId { get; set; }
    }
}
