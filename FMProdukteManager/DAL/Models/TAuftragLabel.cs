using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TAuftragLabel
    {
        public int KAuftrag { get; set; }
        public int KLabel { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
