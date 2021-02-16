using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class VLagerbestandProLager1
    {
        public string CArtNr { get; set; }
        public string DatensätzeFehlen { get; set; }
        public string Bestände { get; set; }
        public string CodeZumKorigieren { get; set; }
        public int KWarenLager { get; set; }
        public int KArtikel { get; set; }
    }
}
