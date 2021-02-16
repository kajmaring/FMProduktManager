using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TSyncLogsitzung
    {
        public TSyncLogsitzung()
        {
            TDbeSlogeintrag = new HashSet<TDbeSlogeintrag>();
            TPosLogeintrag = new HashSet<TPosLogeintrag>();
        }

        public int KSyncLogsitzung { get; set; }
        public int NTyp { get; set; }
        public int KBenutzer { get; set; }
        public string CRechnername { get; set; }
        public DateTime DStart { get; set; }
        public DateTime? DEnde { get; set; }
        public byte? NStatus { get; set; }
        public string CStatusMeldung { get; set; }

        public virtual ICollection<TDbeSlogeintrag> TDbeSlogeintrag { get; set; }
        public virtual ICollection<TPosLogeintrag> TPosLogeintrag { get; set; }
    }
}
