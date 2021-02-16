﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TPosLogeintrag
    {
        public int KPosLogeintrag { get; set; }
        public int KSyncLogsitzung { get; set; }
        public DateTime DZeitpunkt { get; set; }
        public byte NSchweregrad { get; set; }
        public string CJson { get; set; }
        public int? KShop { get; set; }
        public int? KShopSubshop { get; set; }
        public string CMeldung { get; set; }
        public int? NLimit { get; set; }
        public byte NCallType { get; set; }

        public virtual TSyncLogsitzung KSyncLogsitzungNavigation { get; set; }
    }
}
