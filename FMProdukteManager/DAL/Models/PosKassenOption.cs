using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class PosKassenOption
    {
        public long KKassenOption { get; set; }
        public long? KKasse { get; set; }
        public string CKey { get; set; }
        public string CValue { get; set; }
        public DateTime? DMod { get; set; }
    }
}
