﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class ArtikelBildShop
    {
        public int KArtikelBildPlattform { get; set; }
        public int KShop { get; set; }
        public byte NInet { get; set; }
        public int KBild { get; set; }
        public int NNr { get; set; }
        public int KArtikel { get; set; }
        public int? KArtikelbildPlattformMain { get; set; }
    }
}
