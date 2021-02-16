﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class EbaySpecific
    {
        public int KItem { get; set; }
        public string CName { get; set; }
        public string CValue { get; set; }
        public byte? NCustom { get; set; }
        public int KMerkmal { get; set; }
        public int KMerkmalWert { get; set; }
        public int KSprache { get; set; }
    }
}
