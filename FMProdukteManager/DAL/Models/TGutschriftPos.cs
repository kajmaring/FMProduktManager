using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TGutschriftPos
    {
        public int KGutschriftPos { get; set; }
        public int TArtikelKArtikel { get; set; }
        public int TGutschriftKGutschrift { get; set; }
        public decimal FVkpreis { get; set; }
        public decimal FMwSt { get; set; }
        public decimal NAnzahl { get; set; }
        public decimal FRabatt { get; set; }
        public string CString { get; set; }
        public decimal FVknetto { get; set; }
        public string CArtNr { get; set; }
        public byte? NLager { get; set; }
        public int? KBestellPos { get; set; }
        public int KGutschriftStueckliste { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
