﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TEigenschaftWertPict
    {
        public int KEigenschaftWertPict { get; set; }
        public int? KEigenschaftWert { get; set; }
        public int? KBild { get; set; }
        public byte? NInet { get; set; }
        public int? KPlattform { get; set; }
        public int? KShop { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
