using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class VStuecklisteInBestellung
    {
        public int Stueckliste { get; set; }
        public int TArtikelKArtikel { get; set; }
        public decimal? MengeInBestellung { get; set; }
    }
}
