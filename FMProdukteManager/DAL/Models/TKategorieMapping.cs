﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TKategorieMapping
    {
        public int KKategorieMapping { get; set; }
        public int KKategorie { get; set; }
        public int KFremdKategorie { get; set; }
        public int NPlattform { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
