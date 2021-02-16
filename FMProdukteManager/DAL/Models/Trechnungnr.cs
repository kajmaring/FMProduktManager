using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Trechnungnr
    {
        public int KRechnungNr { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
