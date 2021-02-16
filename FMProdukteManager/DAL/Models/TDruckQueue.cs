﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TDruckQueue
    {
        public int KDruckQueue { get; set; }
        public DateTime? DZeitstempel { get; set; }
        public int? KBenutzer { get; set; }
        public byte? NStatus { get; set; }
        public int? KLhm { get; set; }
        public int? KWarenlagerPlatz { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
