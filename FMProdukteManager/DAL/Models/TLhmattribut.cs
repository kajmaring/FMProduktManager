﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TLhmattribut
    {
        public int KLhmattribut { get; set; }
        public int KLhm { get; set; }
        public string CAttribut { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
