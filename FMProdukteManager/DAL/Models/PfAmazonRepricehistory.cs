using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class PfAmazonRepricehistory
    {
        public long KMessage { get; set; }
        public int? KUser { get; set; }
        public string CSellerSku { get; set; }
        public decimal FPreisAlt { get; set; }
        public decimal FPreisNeu { get; set; }
        public DateTime? DErstellt { get; set; }
        public int? NPlattform { get; set; }
    }
}
