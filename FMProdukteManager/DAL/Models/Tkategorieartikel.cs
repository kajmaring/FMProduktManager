﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Tkategorieartikel
    {
        public int KKategorieArtikel { get; set; }
        public int KArtikel { get; set; }
        public int KKategorie { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
