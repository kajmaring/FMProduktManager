using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class EbayUsertexte
    {
        public int KEbayUserTexte { get; set; }
        public int? KEbayUser { get; set; }
        public string CTagName { get; set; }
        public string CText { get; set; }
    }
}
