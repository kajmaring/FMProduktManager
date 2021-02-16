using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class EbayXxLaufzeiten
    {
        public int SiteId { get; set; }
        public string CType { get; set; }
        public string CDuration { get; set; }
    }
}
