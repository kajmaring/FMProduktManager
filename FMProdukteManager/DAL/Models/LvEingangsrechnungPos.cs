using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class LvEingangsrechnungPos
    {
        public int KEingangsrechnungPos { get; set; }
        public string CArtNr { get; set; }
        public string CLieferantenArtNr { get; set; }
        public string CName { get; set; }
        public string CLieferantenBezeichnung { get; set; }
        public decimal FMwSt { get; set; }
        public string CEinheit { get; set; }
        public decimal FEknetto { get; set; }
        public decimal FEknettoGesamt { get; set; }
        public decimal FEkbrutto { get; set; }
        public decimal FEkbruttoGesamt { get; set; }
        public string CHinweis { get; set; }
        public string CHan { get; set; }
        public int? KArtikel { get; set; }
        public int? KEingangsrechnung { get; set; }
        public int? KLieferantenbestellung { get; set; }
        public decimal FMenge { get; set; }
    }
}
