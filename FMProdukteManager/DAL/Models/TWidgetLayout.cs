using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TWidgetLayout
    {
        public int KWidgetLayout { get; set; }
        public int? KBenutzer { get; set; }
        public string CLayout { get; set; }
        public string CArbeitsplatz { get; set; }
        public int? NApplikation { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
