using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class PfAmazonAngebotSelbstErstellt
    {
        public string CSellerSku { get; set; }
        public string KUser { get; set; }
        public int NPlattform { get; set; }
        public int? KItem { get; set; }
        public DateTime? DErstellt { get; set; }
        public int? NStatus { get; set; }
    }
}
