﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TKundeSuche
    {
        public int KKunde { get; set; }
        public string CValue { get; set; }
        public byte NId { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
