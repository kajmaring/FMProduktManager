﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TMerkmalWert
    {
        public int KMerkmalWert { get; set; }
        public int? KMerkmal { get; set; }
        public int? NSort { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
