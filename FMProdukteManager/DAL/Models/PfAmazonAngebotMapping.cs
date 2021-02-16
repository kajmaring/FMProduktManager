using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class PfAmazonAngebotMapping
    {
        public int KArtikel { get; set; }
        public string CSellerSku { get; set; }
        public int KUser { get; set; }
    }
}
