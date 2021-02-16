using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TLieferantenBestellungErinnerungPos
    {
        public int KLieferantenBestellungErinnerung { get; set; }
        public int KLieferantenBestellung { get; set; }
        public int KLieferantenBestellungPos { get; set; }
        public decimal FAnzahl { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
