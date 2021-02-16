using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class PosgastroTischSperre
    {
        public long KTischSperre { get; set; }
        public long KKasse { get; set; }
        public long KTisch { get; set; }
        public long KBenutzer { get; set; }
        public DateTime? DtErstellung { get; set; }
    }
}
