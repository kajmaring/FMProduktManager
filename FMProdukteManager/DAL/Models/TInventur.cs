using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TInventur
    {
        public int KInventur { get; set; }
        public int KArtikel { get; set; }
        public int KWarenLagerPlatz { get; set; }
        public decimal FAnzahl { get; set; }
        public DateTime? DMhd { get; set; }
        public string CCharge { get; set; }
        public string CSeriennummer { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
