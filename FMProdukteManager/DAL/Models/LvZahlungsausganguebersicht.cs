using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class LvZahlungsausganguebersicht
    {
        public int KZahlungsabgleichAusgang { get; set; }
        public int KZahlungsabgleichUmsatzEingang { get; set; }
        public int KZahlungsabgleichUmsatzAusgang { get; set; }
        public int? KZahlungAusgang { get; set; }
        public int? KZahlungEingang { get; set; }
        public int KZahlungsabgleichModul { get; set; }
        public string CKontoIdentifikation { get; set; }
        public int KGutschrift { get; set; }
        public int KEingangsrechnung { get; set; }
        public int KKunde { get; set; }
        public string CKonto { get; set; }
        public string CKontozusatz { get; set; }
        public string CName { get; set; }
        public decimal FBetrag { get; set; }
        public string CWaehrungIso { get; set; }
        public string CInternerKommentar { get; set; }
        public string CVerwendungszweck { get; set; }
        public string CTransaktionId { get; set; }
        public DateTime DAnlagedatum { get; set; }
        public int KAnlagebenutzer { get; set; }
        public DateTime? DBuchungsdatum { get; set; }
        public int KBuchungsbenutzer { get; set; }
        public byte NVollstaendigerReferenzbetrag { get; set; }
    }
}
