using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class EbayDeGebErweiterungen
    {
        public int KEbayDeGebErweiterungen { get; set; }
        public string Enhancement { get; set; }
        public byte? MehrereArtikel { get; set; }
        public decimal Gebuehr { get; set; }
    }
}
