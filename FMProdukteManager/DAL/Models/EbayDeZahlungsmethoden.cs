﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class EbayDeZahlungsmethoden
    {
        public int KEbayDeZahlungsmethoden { get; set; }
        public string PaymentOption { get; set; }
        public string Description { get; set; }
        public string DisplayText { get; set; }
    }
}
