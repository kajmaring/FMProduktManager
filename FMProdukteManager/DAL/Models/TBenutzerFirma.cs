﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TBenutzerFirma
    {
        public int KBenutzer { get; set; }
        public int KFirma { get; set; }
        public int KMandant { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
