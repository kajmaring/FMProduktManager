﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TReports
    {
        public int KReports { get; set; }
        public string CName { get; set; }
        public string CData { get; set; }
        public string CTyp { get; set; }
        public string CDataSet { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
