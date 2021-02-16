using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class PosBon
    {
        public long KBon { get; set; }
        public byte[] CData { get; set; }
        public byte[] CData2 { get; set; }
        public long? KBonStorno { get; set; }
        public int KKasse { get; set; }
        public int KBenutzer { get; set; }
        public int KKunde { get; set; }
        public DateTime DDatum { get; set; }
        public float FGegeben { get; set; }
        public float FRueckgeld { get; set; }
        public float FGesamtSumme { get; set; }
        public float FSumme1 { get; set; }
        public float FSumme2 { get; set; }
        public float FSumme3 { get; set; }
        public float FSumme4 { get; set; }
        public float FSumme5 { get; set; }
        public float FSumme6 { get; set; }
        public float FSumme7 { get; set; }
        public float FSumme8 { get; set; }
        public float FSumme9 { get; set; }
        public float FSumme10 { get; set; }
        public float FMwSt1 { get; set; }
        public float FMwSt2 { get; set; }
        public float FMwSt3 { get; set; }
        public float FMwSt4 { get; set; }
        public float FMwSt5 { get; set; }
        public float FMwSt6 { get; set; }
        public float FMwSt7 { get; set; }
        public float FMwSt8 { get; set; }
        public float FMwSt9 { get; set; }
        public float FMwSt10 { get; set; }
        public string CHasRabatt { get; set; }
        public string CWawiAuftragErstellt { get; set; }
        public float? FGutscheinAusgabe { get; set; }
        public float? FGutscheinEinloesung { get; set; }
        public long? TRechnungKRechnung { get; set; }
        public string CBonNr { get; set; }
        public string TVersandartCName { get; set; }
        public long? TVersandartKVersandart { get; set; }
    }
}
