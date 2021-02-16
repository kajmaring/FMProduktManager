﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TZahlung
    {
        public int KZahlung { get; set; }
        public string CName { get; set; }
        public DateTime? DDatum { get; set; }
        public decimal FBetrag { get; set; }
        public int? KBestellung { get; set; }
        public int? KBenutzer { get; set; }
        public byte? NAnzahlung { get; set; }
        public string CHinweis { get; set; }
        public int? KZahlungsart { get; set; }
        public byte? NKeinExport { get; set; }
        public string CSkrmanuell { get; set; }
        public string CExternalTransactionId { get; set; }
        public int? KZahlungsabgleichUmsatz { get; set; }
        public byte? NZuweisungstyp { get; set; }
        public byte NZahlungstyp { get; set; }
        public string CZuweisungsinfo { get; set; }
        public int? NZuweisungswertung { get; set; }
        public byte[] BRowversion { get; set; }
        public int? KGutschrift { get; set; }
        public int? KEingangsrechnung { get; set; }
    }
}
