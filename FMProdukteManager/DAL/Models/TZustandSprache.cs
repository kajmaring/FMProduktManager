﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TZustandSprache
    {
        public int KZustand { get; set; }
        public int KSprache { get; set; }
        public string CName { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
