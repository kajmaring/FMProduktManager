using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TSteuerSammelkonten
    {
        public int KSteuerSammelkonten { get; set; }
        public string CName { get; set; }
        public string CSammelkonto { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
