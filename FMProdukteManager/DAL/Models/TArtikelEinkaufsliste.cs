using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TArtikelEinkaufsliste
    {
        public int KArtikel { get; set; }
        public int KBenutzer { get; set; }
        public DateTime DErstellt { get; set; }
        public string CStatus { get; set; }
        public decimal FAnzahl { get; set; }
        public int? KLieferant { get; set; }
        public decimal FEknettoLieferant { get; set; }
        public string CHinweis { get; set; }
        public string CBestellmodus { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
