﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TFehler
    {
        public int KFehler { get; set; }
        public int? KSessionId { get; set; }
        public string CText { get; set; }
        public int? NValue1 { get; set; }
        public int? NValue2 { get; set; }
        public int? NValue3 { get; set; }
        public string CValue1 { get; set; }
        public string CValue2 { get; set; }
        public string CValue3 { get; set; }
        public int? Kkey1 { get; set; }
        public int? Kkey2 { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
