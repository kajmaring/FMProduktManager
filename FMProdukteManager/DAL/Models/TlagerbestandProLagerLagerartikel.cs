﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TlagerbestandProLagerLagerartikel
    {
        public int KArtikel { get; set; }
        public int KWarenlager { get; set; }
        public decimal FBestand { get; set; }
        public decimal FVerfuegbarGesperrt { get; set; }
        public decimal FAuslieferungGesperrt { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
