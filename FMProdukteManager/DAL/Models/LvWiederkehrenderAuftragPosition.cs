using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class LvWiederkehrenderAuftragPosition
    {
        public int KIntervall { get; set; }
        public int KIntervallPos { get; set; }
        public int? KArtikel { get; set; }
        public string CArtikelnummer { get; set; }
        public decimal NAnzahl { get; set; }
        public string CBeschreibung { get; set; }
        public decimal FVkbrutto { get; set; }
        public decimal FVknetto { get; set; }
        public decimal FMwSt { get; set; }
        public decimal FRabatt { get; set; }
        public string CHinweis { get; set; }
    }
}
