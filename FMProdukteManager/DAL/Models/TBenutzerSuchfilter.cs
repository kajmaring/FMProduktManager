using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TBenutzerSuchfilter
    {
        public int KBenutzerSuchfilter { get; set; }
        public int KBenutzer { get; set; }
        public int NFilterTyp { get; set; }
        public int NModus { get; set; }
        public string CName { get; set; }
        public string CValue { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
