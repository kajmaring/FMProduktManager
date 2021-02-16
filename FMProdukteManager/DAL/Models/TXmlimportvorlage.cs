using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TXmlimportvorlage
    {
        public int KXmlImportvorlage { get; set; }
        public byte NTyp { get; set; }
        public string CName { get; set; }
        public string BVorlage { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
