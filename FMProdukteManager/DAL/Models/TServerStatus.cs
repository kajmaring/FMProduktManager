using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TServerStatus
    {
        public int? KServerStatus { get; set; }
        public string CComputername { get; set; }
        public int? NStatus { get; set; }
        public string CIpAddress { get; set; }
        public string CCertificateInfo { get; set; }
        public string CPublicIpStatus { get; set; }
        public string CLastSyncInfo { get; set; }
        public DateTime? DLastUpdated { get; set; }
        public int? NRequestedAction { get; set; }
        public DateTime? DRequestedAction { get; set; }
    }
}
