using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TBroken
    {
        public string CBroken { get; set; }
        public DateTime? DDatum { get; set; }
        public string CKey { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
