using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class PosBonPosition
    {
        public long KBonPosition { get; set; }
        public long KBon { get; set; }
        public long? KBonPositionStorno { get; set; }
        public float FMenge { get; set; }
        public float FEinzelPreis { get; set; }
        public float FKassenRabattSatz { get; set; }
        public string CHasSonderPreis { get; set; }
        public string CisAstaffelPreis { get; set; }
        public string CisLagerArtikel { get; set; }
        public string CHasVariationen { get; set; }
        public string CVariationen { get; set; }
        public long? TArtikelKArtikel { get; set; }
        public string TArtikelCArtNr { get; set; }
        public string TArtikelCName { get; set; }
        public float? TArtikelFVkbrutto { get; set; }
        public float? TArtikelFVknetto { get; set; }
        public float? TArtikelFUvp { get; set; }
        public float? TArtikelFMwSt { get; set; }
        public string TArtikelCEinheit { get; set; }
        public string TArtikelCHersteller { get; set; }
        public string TArtikelCErloeskonto { get; set; }
        public string TArtikelCWarengruppe { get; set; }
        public long? TLagerArtikelKLagerArtikel { get; set; }
        public string TLagerArtikelCSerienNr { get; set; }
        public string CWawiAuftragErstellt { get; set; }
        public string CisAgutschein { get; set; }
        public string CisArueckgabeAusgleich { get; set; }
        public long? TBestellungKBestellung { get; set; }
        public long? TZahlungKZahlung { get; set; }
        public string CisAfreitext { get; set; }
        public byte[] CData { get; set; }
        public int? KBenutzer { get; set; }
    }
}
