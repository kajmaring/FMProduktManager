using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class LvAuftragspositionsvariation
    {
        public int KBestellung { get; set; }
        public int? KBestellPos { get; set; }
        public string CWert { get; set; }
    }
}
