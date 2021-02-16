﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TUmlagerung
    {
        public int KUmlagerung { get; set; }
        public int? KQuellLager { get; set; }
        public int? KZielLager { get; set; }
        public int? KStreckenLager { get; set; }
        public int? KBestellung { get; set; }
        public int? KLieferantenBestellung { get; set; }
        public byte? NStatus { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
