﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TKategorieShop
    {
        public int KKategorie { get; set; }
        public int KShop { get; set; }
        public string CInet { get; set; }
        public string CDelInet { get; set; }
        public bool? NInBearbeitung { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
