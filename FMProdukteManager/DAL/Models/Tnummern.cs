﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Tnummern
    {
        public int? KBestellung { get; set; }
        public int? KAngebot { get; set; }
        public int? KRechnung { get; set; }
        public int? KKunde { get; set; }
        public string CInet { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
