using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Tbestelleigenschaft
    {
        public int KBestellEigenschaft { get; set; }
        public int? KEigenschaftWert { get; set; }
        public int? KBestellPos { get; set; }
        public int? KArtikel { get; set; }
        public decimal FNettoPreis { get; set; }
        public string CWert { get; set; }
        public string CName { get; set; }
        public int? KEigenschaft { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
