﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TMedienDateiSprache
    {
        public int KMedienDatei { get; set; }
        public int KSprache { get; set; }
        public string CName { get; set; }
        public string CBeschreibung { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
