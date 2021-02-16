using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class LvAuftragsposition
    {
        public int KBestellung { get; set; }
        public int KBestellpos { get; set; }
        public decimal? FAnzRetoure { get; set; }
        public int TArtikelKArtikel { get; set; }
        public string CString { get; set; }
        public string CArtNr { get; set; }
        public string CHinweis { get; set; }
        public decimal? FAnzahl { get; set; }
        public decimal? FVknettoGesamt { get; set; }
        public decimal? FGeliefert { get; set; }
        public decimal? FGutgeschrieben { get; set; }
        public decimal? FVknetto { get; set; }
        public decimal? FMwSt { get; set; }
        public decimal? FVkbrutto { get; set; }
        public decimal? FVerfuegbar { get; set; }
        public decimal? FLagerbestand { get; set; }
        public decimal? FVerfuegbarGesperrt { get; set; }
        public decimal? FZulauf { get; set; }
        public decimal? FAufEinkaufsliste { get; set; }
        public decimal FAnzahlAuszuliefern { get; set; }
        public int NSort { get; set; }
        public byte NLagerAktiv { get; set; }
        public int KStuecklistenVater { get; set; }
        public int? KKonfigurationsVater { get; set; }
        public decimal? NAnzahlFehlbestandEigen { get; set; }
        public int NLieferbarStatus { get; set; }
        public int NLieferbarStatusEigen { get; set; }
    }
}
