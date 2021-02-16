using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class PfAmazonBestellungstatus
    {
        public int KMessageId { get; set; }
        public int KUser { get; set; }
        public string COrderId { get; set; }
        public string COrderStatus { get; set; }
        public DateTime? DErstellt { get; set; }
    }
}
