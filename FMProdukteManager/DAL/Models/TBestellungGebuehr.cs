using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TBestellungGebuehr
    {
        public int KBestellungGebuehr { get; set; }
        public int KBestellung { get; set; }
        public int KGebuehrtyp { get; set; }
        public decimal FBetrag { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
