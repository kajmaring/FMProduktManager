﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TShopWaehrung
    {
        public int KWebShop { get; set; }
        public int KWaehrung { get; set; }
        public byte? NStandard { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
