﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TB2bartikel
    {
        public int KB2bartikel { get; set; }
        public int KArtikel { get; set; }
        public string CJpid { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
