﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TWmsversandLock
    {
        public int KWmsversandLock { get; set; }
        public int KPickliste { get; set; }
        public int KBestellung { get; set; }
        public int? NSort { get; set; }
        public int KBenutzer { get; set; }
        public DateTime? DDatum { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
