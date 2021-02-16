using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TAmazonbestellpositionVcszuordnung
    {
        public int KMessageId { get; set; }
        public int KAmazonBestellungPos { get; set; }
        public byte NTyp { get; set; }
    }
}
