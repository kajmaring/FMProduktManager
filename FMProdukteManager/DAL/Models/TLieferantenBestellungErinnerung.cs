﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TLieferantenBestellungErinnerung
    {
        public int KLieferantenBestellungErinnerung { get; set; }
        public int? KLieferantenBestellung { get; set; }
        public int? KBenutzer { get; set; }
        public DateTime? DDatum { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
