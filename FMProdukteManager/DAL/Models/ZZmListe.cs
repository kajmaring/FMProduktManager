﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class ZZmListe
    {
        public int KListe { get; set; }
        public string CKey { get; set; }
        public string CDesc { get; set; }
        public byte? NStatus { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
