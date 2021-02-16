using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TEazyShippingVerpackQueue
    {
        public int? KBestellung { get; set; }
        public DateTime? DTimeStamp { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
