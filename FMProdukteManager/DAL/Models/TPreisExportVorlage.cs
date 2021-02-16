using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TPreisExportVorlage
    {
        public int KPreisExportVorlage { get; set; }
        public string CName { get; set; }
        public int? KPlattform { get; set; }
        public int? KKundengruppe { get; set; }
        public string SMapping { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
