using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Tgutschrifteigenschaft
    {
        public int KGutschriftEigenschaft { get; set; }
        public int? KEigenschaftWert { get; set; }
        public int? KGutschriftPos { get; set; }
        public int? KArtikel { get; set; }
        public decimal FNettoPreis { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
