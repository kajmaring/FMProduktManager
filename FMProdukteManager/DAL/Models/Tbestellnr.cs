using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Tbestellnr
    {
        public int? KBestellNr { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
