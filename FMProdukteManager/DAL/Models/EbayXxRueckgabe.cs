using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class EbayXxRueckgabe
    {
        public int SiteId { get; set; }
        public string CType { get; set; }
        public string COption { get; set; }
        public string CDescription { get; set; }
    }
}
