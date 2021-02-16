using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TFulfillmentAuftragPos
    {
        public int KFulfillmentAuftragPos { get; set; }
        public int? KFulfillmentAuftrag { get; set; }
        public int? KLieferscheinPos { get; set; }
        public int? KArtikel { get; set; }
        public string CArtNr { get; set; }
        public string CCarrier { get; set; }
        public string CName { get; set; }
        public decimal FAnzahl { get; set; }
        public int? NStatus { get; set; }
        public string CArtikelGeschenkText { get; set; }
        public string CArtikelHinweis { get; set; }
        public int? NErrorCode { get; set; }
        public string CErrorType { get; set; }
        public string CErrorMessage { get; set; }
        public string CAbhilfe { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
