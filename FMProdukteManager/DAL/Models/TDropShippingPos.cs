using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TDropShippingPos
    {
        public int KBestellPos { get; set; }
        public int KLieferantenBestellungPos { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
