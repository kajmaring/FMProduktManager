using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TEbayAbgleichLogsitzung
    {
        public TEbayAbgleichLogsitzung()
        {
            TEbayAbgleichLogeintrag = new HashSet<TEbayAbgleichLogeintrag>();
        }

        public int KEbayAbgleichLogsitzung { get; set; }
        public int NTyp { get; set; }
        public int KBenutzer { get; set; }
        public string CRechnername { get; set; }
        public DateTime DStart { get; set; }
        public DateTime? DEnde { get; set; }
        public byte? NStatus { get; set; }
        public string CStatusMeldung { get; set; }
        public byte[] BRowversion { get; set; }

        public virtual ICollection<TEbayAbgleichLogeintrag> TEbayAbgleichLogeintrag { get; set; }
    }
}
