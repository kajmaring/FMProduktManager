﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class LvLogeintrag
    {
        public DateTime? DZeitpunkt { get; set; }
        public int NSchweregrad { get; set; }
        public string CMeldung { get; set; }
        public int? NTyp { get; set; }
        public int? NVorgang { get; set; }
        public string CBenutzername { get; set; }
    }
}
