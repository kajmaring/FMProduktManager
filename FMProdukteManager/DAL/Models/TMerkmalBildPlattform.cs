﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TMerkmalBildPlattform
    {
        public int KMerkmalBildPlattform { get; set; }
        public int KMerkmal { get; set; }
        public int? KBild { get; set; }
        public int? KPlattform { get; set; }
        public int? KShop { get; set; }
        public byte? NInet { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
