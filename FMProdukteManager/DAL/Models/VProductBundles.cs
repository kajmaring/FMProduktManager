using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class VProductBundles
    {
        public int KArtikel { get; set; }
        public string Name { get; set; }
        public decimal Quantity { get; set; }
        public string Ean { get; set; }
        public string Upc { get; set; }
    }
}
