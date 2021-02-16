using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class VBestellungEckdaten
    {
        public int KBestellung { get; set; }
        public decimal FWert { get; set; }
        public decimal FZahlung { get; set; }
        public decimal FGutschrift { get; set; }
        public decimal FGutschein { get; set; }
        public decimal FFaktor { get; set; }
        public string CWaehrung { get; set; }
        public decimal FWertNetto { get; set; }
        public byte[] BRowversion { get; set; }
        public bool NExistiertLieferschein { get; set; }
        public string CRechnungsnummer { get; set; }
        public DateTime? DRechnungErstellt { get; set; }
        public byte? NRechnungZahlungsziel { get; set; }
        public string CZahlungsartName { get; set; }
        public int? NMahnstufe { get; set; }
        public decimal? FMahngebuehr { get; set; }
        public DateTime? DZahlungsfrist { get; set; }
        public string CRueckhaltegrundName { get; set; }
        public string CShopName { get; set; }
        public string CFirmaName { get; set; }
        public string CVersandartName { get; set; }
        public DateTime? DErstellt { get; set; }
        public DateTime? DMahndatum { get; set; }
    }
}
