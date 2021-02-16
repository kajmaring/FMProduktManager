using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TStampit
    {
        public short? NAktiv { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
