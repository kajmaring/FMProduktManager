using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TZahlungsausgangLogeintrag
    {
        public int KZahlungsausgangLogeintrag { get; set; }
        public int KZahlungsabgleichLogsitzung { get; set; }
        public DateTime DZeitpunkt { get; set; }
        public byte NSchweregrad { get; set; }
        public string CMeldung { get; set; }
        public int KZahlungsabgleichModul { get; set; }
        public string CKontoIdentifikation { get; set; }
        public int KKunde { get; set; }
        public int KGutschrift { get; set; }
        public decimal FBetrag { get; set; }
        public string CVerwendungszweck { get; set; }
        public DateTime DAnlagedatum { get; set; }
        public int KAnlagebenutzer { get; set; }
        public DateTime DBuchungsdatum { get; set; }
        public int KBuchungsbenutzer { get; set; }
        public byte[] BRowversion { get; set; }

        public virtual TZahlungsabgleichLogsitzung KZahlungsabgleichLogsitzungNavigation { get; set; }
    }
}
