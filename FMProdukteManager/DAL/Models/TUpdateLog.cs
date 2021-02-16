using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TUpdateLog
    {
        public int KUpdateLog { get; set; }
        public string CModul { get; set; }
        public DateTime DZeitstempel { get; set; }
        public int NSchweregrad { get; set; }
        public int KBenutzer { get; set; }
        public string CMeldung { get; set; }
    }
}
