using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TStockRef
    {
        public int KStockRef { get; set; }
        public int KArtikel { get; set; }
        public int KBenutzer { get; set; }
        public int KBuchungsart { get; set; }
        public string CJfsku { get; set; }
        public int KWarenLagerPlatz { get; set; }
        public int? KLieferantenBestellungPos { get; set; }
        public decimal FAnzahl { get; set; }
        public DateTimeOffset DCreatedAt { get; set; }
        public DateTimeOffset? DUpdatedAt { get; set; }
        public string CLieferscheinNr { get; set; }
        public string COwnerId { get; set; }
        public DateTime? DMhd { get; set; }
        public string CCharge { get; set; }
        public string CKommentar { get; set; }
        public int? KWarenLagerEingang { get; set; }
        public int? KSessionId { get; set; }
        public Guid CFulfillerStockChangeId { get; set; }
        public byte[] BRowVersion { get; set; }
        public byte? NChangeState { get; set; }
        public byte? NType { get; set; }

        public virtual TArtikel KArtikelNavigation { get; set; }
    }
}
