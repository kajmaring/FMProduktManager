﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TWmslagerBereich
    {
        public int KWmslagerBereich { get; set; }
        public string CKuerzel { get; set; }
        public string CBeschreibung { get; set; }
        public int KWarenLager { get; set; }
        public int? NTyp { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
