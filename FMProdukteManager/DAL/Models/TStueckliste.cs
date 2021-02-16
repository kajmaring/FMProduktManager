using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TStueckliste
    {
        public int KStueckliste { get; set; }
        public int KArtikel { get; set; }
        public decimal FAnzahl { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
