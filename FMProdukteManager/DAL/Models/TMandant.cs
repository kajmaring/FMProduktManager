﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TMandant
    {
        public int KMandant { get; set; }
        public string CName { get; set; }
        public string CDb { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
