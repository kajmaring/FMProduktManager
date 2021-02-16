using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class PfAmazonApaPreis
    {
        public string CSellerSku { get; set; }
        public int? NPlattform { get; set; }
        public decimal FPreis { get; set; }
        public DateTime? DErstellt { get; set; }
    }
}
