using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class EbayDeCategory2Cs
    {
        public int CategoryId { get; set; }
        public int AttributeSetId { get; set; }
        public int? AttributeSetVersion { get; set; }
        public string Name { get; set; }
    }
}
