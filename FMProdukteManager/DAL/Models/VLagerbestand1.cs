﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class VLagerbestand1
    {
        public int KArtikel { get; set; }
        public int KWarenlager { get; set; }
        public decimal? FBestand { get; set; }
        public decimal FBestandAuslieferungGesperrt { get; set; }
    }
}
