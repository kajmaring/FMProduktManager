﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TStatistikVorlageChartEinstellung
    {
        public int KStatistikVorlage { get; set; }
        public string CName { get; set; }
        public string CValue { get; set; }
        public int? NSort { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
