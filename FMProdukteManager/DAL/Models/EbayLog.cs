﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class EbayLog
    {
        public string DDatum { get; set; }
        public string CString { get; set; }
        public string CText { get; set; }
        public int? KItem { get; set; }
    }
}
