﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class AmeiseImportvorlageeinstellung
    {
        public int KImportVorlageEinstellung { get; set; }
        public int KImportVorlage { get; set; }
        public int KImportTypEinstellung { get; set; }
        public int KImportTypEinstellungWert { get; set; }
    }
}
