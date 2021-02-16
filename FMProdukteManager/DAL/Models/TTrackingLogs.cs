using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TTrackingLogs
    {
        public int KTrackingLog { get; set; }
        public DateTime DDateTime { get; set; }
        public string CMessage { get; set; }
        public string CStackTrace { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
