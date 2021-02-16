﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TArtikelSonderpreis
    {
        public int KArtikelSonderpreis { get; set; }
        public int KArtikel { get; set; }
        public byte? NAktiv { get; set; }
        public DateTime? DStart { get; set; }
        public int? NAnzahl { get; set; }
        public DateTime? DEnde { get; set; }
        public byte? NIstDatum { get; set; }
        public byte? NIstAnzahl { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
