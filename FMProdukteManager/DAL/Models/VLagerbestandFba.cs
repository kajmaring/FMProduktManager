using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class VLagerbestandFba
    {
        public int KArtikel { get; set; }
        public decimal FLagerbestand { get; set; }
        public decimal FAnzahlFba { get; set; }
    }
}
