﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TZustandKategorie
    {
        public int KZustandKategorie { get; set; }
        public int KZustand { get; set; }
        public int KKategorie { get; set; }
        public byte NIstMarkiert { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
