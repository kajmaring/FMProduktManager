using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TWidgetSettings
    {
        public int KWidgetSettings { get; set; }
        public int? KWidget { get; set; }
        public string CKey { get; set; }
        public string CValue { get; set; }
        public string CArbeitsplatz { get; set; }
        public int? NApplikation { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
