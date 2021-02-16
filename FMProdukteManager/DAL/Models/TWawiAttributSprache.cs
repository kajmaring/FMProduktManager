﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TWawiAttributSprache
    {
        public int KWawiAttribut { get; set; }
        public int KSprache { get; set; }
        public string CWertVarchar { get; set; }
        public int? NWertInt { get; set; }
        public decimal? FWertDecimal { get; set; }
        public DateTime? DWertDateTime { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
