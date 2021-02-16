using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class VFulfillerLieferscheinWarehouseInfo
    {
        public string COutboundId { get; set; }
        public int KBestellung { get; set; }
        public string CBestellNr { get; set; }
        public int KLieferschein { get; set; }
        public int KLieferscheinPos { get; set; }
        public int KWarenLager { get; set; }
        public byte NLagerplatzVerwaltung { get; set; }
    }
}
