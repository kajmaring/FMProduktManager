﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TArtikelShop
    {
        public int KArtikel { get; set; }
        public int KShop { get; set; }
        public string CInet { get; set; }
        public string CDelInet { get; set; }
        public int NAktion { get; set; }
        public byte? NInBearbeitung { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
