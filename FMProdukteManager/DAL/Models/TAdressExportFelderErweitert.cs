using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TAdressExportFelderErweitert
    {
        public int? KAdressExportVorlage { get; set; }
        public int? NFeldNr { get; set; }
        public string CName { get; set; }
        public string CWert { get; set; }
        public string CZone { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
