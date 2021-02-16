using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TMedienDateiAttribut
    {
        public int KMediendateiAttribut { get; set; }
        public int KMedienDatei { get; set; }
        public int KSprache { get; set; }
        public string CName { get; set; }
        public string CWert { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
