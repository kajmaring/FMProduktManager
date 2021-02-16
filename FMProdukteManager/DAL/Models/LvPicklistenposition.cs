using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class LvPicklistenposition
    {
        public int KPicklistePos { get; set; }
        public int KPickliste { get; set; }
        public decimal FAnzahl { get; set; }
        public string CBestellNr { get; set; }
        public string CLieferscheinNr { get; set; }
        public string CAuftragArtNr { get; set; }
        public string CString { get; set; }
        public string CStringStandard { get; set; }
        public int? NStatus { get; set; }
        public int NIstStueckliste { get; set; }
        public string LetzterStatusBenutzername { get; set; }
        public int KArtikel { get; set; }
    }
}
