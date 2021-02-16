using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class PfAmazonBestandAnDatum
    {
        public int KUser { get; set; }
        public string CSellerSku { get; set; }
        public DateTime DErstellt { get; set; }
    }
}
