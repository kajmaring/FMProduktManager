﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TLieferStatus
    {
        public int KLieferStatus { get; set; }
        public int KSprache { get; set; }
        public string CName { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
