using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class VRetoureEtikett
    {
        public int KRmretourenEtikett { get; set; }
        public int KRmretoure { get; set; }
        public string CIdentCode { get; set; }
        public DateTime? DErstellt { get; set; }
    }
}
