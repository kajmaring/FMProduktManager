using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TUmsatzSteuerPruefung
    {
        public int KKunde { get; set; }
        public string CUstid { get; set; }
        public DateTime? DErfolgreichGerpueft { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
