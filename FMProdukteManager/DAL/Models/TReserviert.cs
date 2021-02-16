using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TReserviert
    {
        public int KArtikel { get; set; }
        public decimal FAnzahl { get; set; }
        public int KKey { get; set; }
        public int KPlattform { get; set; }
        public int? KBestellung { get; set; }
        public decimal FBestandReserviert { get; set; }
        public decimal FBestandReserviertEigen { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
