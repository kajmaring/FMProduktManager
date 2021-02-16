using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TZahlungsabgleichLogeintrag
    {
        public int KZahlungsabgleichLogeintrag { get; set; }
        public int KZahlungsabgleichLogsitzung { get; set; }
        public DateTime DZeitpunkt { get; set; }
        public byte NSchweregrad { get; set; }
        public string CMeldung { get; set; }
        public int KZahlungsabgleichModul { get; set; }
        public string CKontoIdentifikation { get; set; }
        public byte[] BRowversion { get; set; }

        public virtual TZahlungsabgleichLogsitzung KZahlungsabgleichLogsitzungNavigation { get; set; }
    }
}
