﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TArtikelAbnahme
    {
        public int KArtikel { get; set; }
        public int KKundengruppe { get; set; }
        public decimal FIntervall { get; set; }
        public decimal FMindestabnahme { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
