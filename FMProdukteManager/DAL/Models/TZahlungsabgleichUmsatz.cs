using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TZahlungsabgleichUmsatz
    {
        public int KZahlungsabgleichUmsatz { get; set; }
        public int KZahlungsabgleichModul { get; set; }
        public string CKontoIdentifikation { get; set; }
        public string CTransaktionId { get; set; }
        public DateTime DBuchungsdatum { get; set; }
        public decimal FBetrag { get; set; }
        public string CWaehrungIso { get; set; }
        public string CName { get; set; }
        public string CKonto { get; set; }
        public string CKontozusatz { get; set; }
        public string CVerwendungszweck { get; set; }
        public string CInternerKommentar { get; set; }
        public DateTime DAbgleichszeitpunkt { get; set; }
        public int KBenutzer { get; set; }
        public bool? NSichtbar { get; set; }
        public int NBuchungstyp { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
