﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class EbayVersandOut
    {
        public int? KEbayCheckout { get; set; }
        public string DDatum { get; set; }
        public string CTrackingId { get; set; }
        public string CInfo { get; set; }
        public string CLogistiker { get; set; }
        public string CUrl { get; set; }
    }
}
