using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TStatistikvorlagenserialisierung
    {
        public int KStatistikvorlagenserialisierung { get; set; }
        public int KBenutzer { get; set; }
        public string CAuswertungsvorlage { get; set; }
        public string CDarstellungsvorlage { get; set; }
        public string CName { get; set; }
        public string CBeschreibung { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
