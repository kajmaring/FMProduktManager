﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TListViewSpalten
    {
        public int? KListView { get; set; }
        public int? NPos { get; set; }
        public string CWert { get; set; }
        public int? KBenutzer { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
