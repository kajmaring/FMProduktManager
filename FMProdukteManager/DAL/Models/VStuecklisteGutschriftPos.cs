using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class VStuecklisteGutschriftPos
    {
        public int KGutschriftPos { get; set; }
        public int? KArtikel { get; set; }
        public decimal? FAnzahl { get; set; }
    }
}
