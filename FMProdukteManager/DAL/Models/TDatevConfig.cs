using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TDatevConfig
    {
        public int KFirma { get; set; }
        public string TOauthConfigCId { get; set; }
        public int NBeraterNummer { get; set; }
        public int NMandantenNummer { get; set; }
        public DateTime? DAbgleichStartDatum { get; set; }
        public bool? BUseSandbox { get; set; }
    }
}
