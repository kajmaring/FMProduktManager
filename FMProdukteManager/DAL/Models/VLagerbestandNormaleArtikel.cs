﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class VLagerbestandNormaleArtikel
    {
        public int KArtikel { get; set; }
        public decimal FBestandEigen { get; set; }
        public decimal? FBestand { get; set; }
        public decimal? FVerfuegbar { get; set; }
        public decimal FVerfuegbarGesperrt { get; set; }
        public decimal FInAuftraegen { get; set; }
        public decimal FZulauf { get; set; }
        public int NLagerAktiv { get; set; }
        public int NArtikeltyp { get; set; }
        public int NTeilbar { get; set; }
        public int NLagerKleinerNull { get; set; }
    }
}
