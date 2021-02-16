using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TZahlungsabgleichLogsitzung
    {
        public TZahlungsabgleichLogsitzung()
        {
            TZahlungsabgleichLogeintrag = new HashSet<TZahlungsabgleichLogeintrag>();
            TZahlungsausgangLogeintrag = new HashSet<TZahlungsausgangLogeintrag>();
        }

        public int KZahlungsabgleichLogsitzung { get; set; }
        public int NTyp { get; set; }
        public int KBenutzer { get; set; }
        public string CRechnername { get; set; }
        public DateTime DStart { get; set; }
        public DateTime? DEnde { get; set; }
        public byte? NStatus { get; set; }
        public string CStatusMeldung { get; set; }
        public byte[] BRowversion { get; set; }

        public virtual ICollection<TZahlungsabgleichLogeintrag> TZahlungsabgleichLogeintrag { get; set; }
        public virtual ICollection<TZahlungsausgangLogeintrag> TZahlungsausgangLogeintrag { get; set; }
    }
}
