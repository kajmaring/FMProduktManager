using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TFirmaUstIdNr
    {
        public int KFirmaUstIdNr { get; set; }
        public int KFirma { get; set; }
        public string CLandIso { get; set; }
        public string CUstId { get; set; }
        public byte NAuchAlsVersandlandBetrachten { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
