﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TRmstatusBerechtigung
    {
        public int KRmstatus { get; set; }
        public int KRechtBenutzerGruppe { get; set; }
        public byte NStatusSetzen { get; set; }
        public byte NStatusVerlassen { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
