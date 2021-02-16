using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TSettings
    {
        public string CKey { get; set; }
        public string CStringValue { get; set; }
        public int? NIntValue { get; set; }
        public decimal? FDoubleValue { get; set; }
        public DateTimeOffset? DDateValue { get; set; }
    }
}
