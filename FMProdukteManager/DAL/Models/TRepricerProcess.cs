using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TRepricerProcess
    {
        public int NId { get; set; }
        public string CMandant { get; set; }
        public DateTime DUpdated { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
