using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TMassEinheit
    {
        public int KMassEinheit { get; set; }
        public string CCode { get; set; }
        public string CDisplayCode { get; set; }
        public int? KBezugsMassEinheit { get; set; }
        public decimal FBezugsMassEinheitFaktor { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
