using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TSteuersatzschluessel
    {
        public int KSteuersatz { get; set; }
        public int KWarengruppe { get; set; }
        public int KVersandart { get; set; }
        public int NPositionstyp { get; set; }
        public int? KSteuerschluessel { get; set; }
        public int? KStSchlIgl { get; set; }
        public int? KStSchlUstIgl { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
