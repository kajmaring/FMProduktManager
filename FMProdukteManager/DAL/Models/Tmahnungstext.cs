﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Tmahnungstext
    {
        public int KMahnungsText { get; set; }
        public string CBetreff { get; set; }
        public string CAnrede { get; set; }
        public string CText { get; set; }
        public byte? NStuffe { get; set; }
        public decimal FGebuehr { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
