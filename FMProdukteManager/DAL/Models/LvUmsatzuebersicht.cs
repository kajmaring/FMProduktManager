using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class LvUmsatzuebersicht
    {
        public int KZahlungsabgleichUmsatz { get; set; }
        public string CTransaktionId { get; set; }
        public DateTime DAbgleichszeitpunkt { get; set; }
        public int KAbgleichsbenutzer { get; set; }
        public string CAbgleichsbenutzername { get; set; }
        public DateTime DBuchungsdatum { get; set; }
        public decimal FBetrag { get; set; }
        public string CWaehrungIso { get; set; }
        public string CName { get; set; }
        public string CKonto { get; set; }
        public string CKontozusatz { get; set; }
        public string CVerwendungszweck { get; set; }
        public string CInternerKommentar { get; set; }
        public int KZahlungsabgleichModul { get; set; }
        public string CKontoIdentifikation { get; set; }
        public int NAnzahlZahlungszuweisungen { get; set; }
        public decimal FSummeZahlungszuweisungen { get; set; }
        public bool NSichtbar { get; set; }
        public int NBuchungstyp { get; set; }
    }
}
