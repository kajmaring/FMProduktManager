﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TSteuercache
    {
        public int KSteuerklasse { get; set; }
        public decimal FSteuersatz { get; set; }
        public int? KFirma { get; set; }
        public int? KSteuerzone { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
