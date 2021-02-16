using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TEinheit
    {
        public int KEinheit { get; set; }
        public byte NIstUnsichtbar { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
