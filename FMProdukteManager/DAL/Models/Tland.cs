﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Tland
    {
        public string CIso { get; set; }
        public string CName { get; set; }
        public string CNameEng { get; set; }
        public byte? NEu { get; set; }
        public string CKontinent { get; set; }
        public string CNameFra { get; set; }
        public string CIso3 { get; set; }
        public int NIsonumeric { get; set; }
        public string CWaehrung { get; set; }
        public string CDefaultCulture { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
