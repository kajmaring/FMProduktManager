using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TPicklistenVorschauSync
    {
        public int KPicklisteVorlage { get; set; }
        public DateTime? DLastUpdate { get; set; }
        public int NAnzahl { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
