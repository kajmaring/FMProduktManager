using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class PosKassen
    {
        public int KKasse { get; set; }
        public string CName { get; set; }
        public DateTime? DErstellung { get; set; }
        public DateTime? DZugriff { get; set; }
        public string CZugriff { get; set; }
    }
}
