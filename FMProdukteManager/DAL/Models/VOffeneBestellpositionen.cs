using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class VOffeneBestellpositionen
    {
        public DateTime? DLieferdatum { get; set; }
        public int KArtikel { get; set; }
        public decimal? FMengeNochZuLiefern { get; set; }
    }
}
