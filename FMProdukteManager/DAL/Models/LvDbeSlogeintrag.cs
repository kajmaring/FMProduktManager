﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class LvDbeSlogeintrag
    {
        public int KDbeSlogeintrag { get; set; }
        public int KSyncLogsitzung { get; set; }
        public DateTime DZeitpunkt { get; set; }
        public byte NSchweregrad { get; set; }
        public string CXml { get; set; }
        public int? KShop { get; set; }
        public string CMeldung { get; set; }
        public byte NCallType { get; set; }
    }
}
