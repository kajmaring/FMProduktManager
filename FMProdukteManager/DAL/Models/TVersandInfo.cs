using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TVersandInfo
    {
        public int KBestellung { get; set; }
        public int? NAnzahlVersendetePakete { get; set; }
        public int? NAnzahlPakete { get; set; }
        public DateTime? DVersanddatum { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
