﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TWidgetTemplate
    {
        public int KWidgetTemplate { get; set; }
        public string CTitel { get; set; }
        public string CBeschreibung { get; set; }
        public string CKlasse { get; set; }
        public string CKategorie { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
