﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TPlz
    {
        public string CPlz { get; set; }
        public string COrt { get; set; }
        public string CLand { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
