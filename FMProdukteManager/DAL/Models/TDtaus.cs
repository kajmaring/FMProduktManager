﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TDtaus
    {
        public string CName { get; set; }
        public string CZeile1 { get; set; }
        public string CZeile2 { get; set; }
        public byte? NZahlung { get; set; }
        public string CKontoInhaber { get; set; }
        public string CBlz { get; set; }
        public string CKontoNr { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
