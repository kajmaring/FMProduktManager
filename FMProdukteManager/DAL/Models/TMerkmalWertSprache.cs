﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TMerkmalWertSprache
    {
        public int KMerkmalWert { get; set; }
        public int KSprache { get; set; }
        public string CWert { get; set; }
        public string CSeo { get; set; }
        public string CMetaTitle { get; set; }
        public string CMetaKeywords { get; set; }
        public string CMetaDescription { get; set; }
        public string CBeschreibung { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
