using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class VSteuercache
    {
        public int KFirma { get; set; }
        public decimal FSteuersatz { get; set; }
        public int? KSteuerKlasse { get; set; }
        public int KSteuerZone { get; set; }
    }
}
