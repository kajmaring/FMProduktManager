﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TLhmtyp
    {
        public int KLhmtyp { get; set; }
        public string CName { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
