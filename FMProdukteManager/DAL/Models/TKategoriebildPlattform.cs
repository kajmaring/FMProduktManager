﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TKategoriebildPlattform
    {
        public int KKategoriebildPlattform { get; set; }
        public int KBild { get; set; }
        public int KKategorie { get; set; }
        public int KPlattform { get; set; }
        public int KShop { get; set; }
        public int NNr { get; set; }
        public byte NInet { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
