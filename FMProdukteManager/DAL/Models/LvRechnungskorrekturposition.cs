using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class LvRechnungskorrekturposition
    {
        public int KGutschrift { get; set; }
        public int KGutschriftPos { get; set; }
        public int? KBestellpos { get; set; }
        public int TArtikelKArtikel { get; set; }
        public string CString { get; set; }
        public string CArtNr { get; set; }
        public decimal? FAnzahl { get; set; }
        public decimal? FVknetto { get; set; }
        public decimal? FMwSt { get; set; }
        public decimal? FVkbrutto { get; set; }
        public int KStuecklistenVater { get; set; }
        public int? KKonfigurationsVater { get; set; }
    }
}
