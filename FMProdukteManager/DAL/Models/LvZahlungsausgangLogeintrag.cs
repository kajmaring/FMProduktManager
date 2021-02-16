﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class LvZahlungsausgangLogeintrag
    {
        public int KZahlungsausgangLogeintrag { get; set; }
        public int KZahlungsabgleichLogsitzung { get; set; }
        public DateTime DZeitpunkt { get; set; }
        public byte NSchweregrad { get; set; }
        public string CMeldung { get; set; }
        public int KZahlungsabgleichModul { get; set; }
        public string CKontoIdentifikation { get; set; }
        public int KKunde { get; set; }
        public string CKundenNr { get; set; }
        public int KGutschrift { get; set; }
        public string CGutschriftNr { get; set; }
        public decimal FBetrag { get; set; }
        public string CVerwendungszweck { get; set; }
        public DateTime DAnlagedatum { get; set; }
        public int KAnlagebenutzer { get; set; }
        public string CAnlagebenutzerName { get; set; }
        public DateTime DBuchungsdatum { get; set; }
        public int KBuchungsbenutzer { get; set; }
        public string CBuchungsbenutzerName { get; set; }
    }
}
