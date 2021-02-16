using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class VFulfillerOutboundInfo
    {
        public int KBestellung { get; set; }
        public int? KLieferadresse { get; set; }
        public int? KRechnugnsadresse { get; set; }
        public int? KKunde { get; set; }
        public string OutboundId { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset? ObjectVersion { get; set; }
        public byte? NStorno { get; set; }
        public int? KVersandArt { get; set; }
        public string CBestellNr { get; set; }
    }
}
