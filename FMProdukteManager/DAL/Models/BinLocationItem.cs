﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class BinLocationItem
    {
        public int BinLocationInternalId { get; set; }
        public int ProductInternalId { get; set; }
        public string Comment1 { get; set; }
        public string Comment2 { get; set; }
    }
}
