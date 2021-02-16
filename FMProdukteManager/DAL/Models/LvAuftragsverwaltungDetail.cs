using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class LvAuftragsverwaltungDetail
    {
        public int KBestellung { get; set; }
        public string CAnmerkung { get; set; }
        public string CSonstiges { get; set; }
        public int NStornogrund { get; set; }
        public string CStornobenutzer { get; set; }
        public DateTime? DStornozeitpunkt { get; set; }
    }
}
