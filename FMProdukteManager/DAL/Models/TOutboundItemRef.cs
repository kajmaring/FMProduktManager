using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TOutboundItemRef
    {
        public int KOutboundItemRef { get; set; }
        public int KBestellung { get; set; }
        public int KBestellPos { get; set; }
        public string COutboundItemId { get; set; }
        public decimal FQuantity { get; set; }
        public DateTimeOffset? DCreatedAt { get; set; }
        public DateTimeOffset? DUpdatedAt { get; set; }

        public virtual Tbestellpos KBestellPosNavigation { get; set; }
    }
}
