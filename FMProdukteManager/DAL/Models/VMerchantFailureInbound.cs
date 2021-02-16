using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class VMerchantFailureInbound
    {
        public int KLieferantenBestellung { get; set; }
        public int? KUmlagerung { get; set; }
        public string MerchantInboundNumber { get; set; }
        public byte[] Rowversion { get; set; }
        public string WarehouseId { get; set; }
        public string WarehouseName { get; set; }
        public bool? IsLieferantenBestellung { get; set; }
        public DateTimeOffset? UpdatedAt { get; set; }
        public byte? ChangeType { get; set; }
        public byte? ChangeState { get; set; }
        public byte? RetryAttempts { get; set; }
        public string InboundId { get; set; }
        public byte? InboundStatus { get; set; }
        public int? LieferantenBestellungStatus { get; set; }
        public string ExternalInboundNumber { get; set; }
    }
}
