﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TWidget
    {
        public int KWidget { get; set; }
        public int? KWidgetTemplate { get; set; }
        public int? KBenutzer { get; set; }
        public string CTitel { get; set; }
        public string CArbeitsplatz { get; set; }
        public int? NApplikation { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
