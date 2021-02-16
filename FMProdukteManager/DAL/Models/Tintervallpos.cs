using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Tintervallpos
    {
        public int KIntervallPos { get; set; }
        public int? KArtikel { get; set; }
        public int KIntervall { get; set; }
        public decimal FVkpreis { get; set; }
        public decimal FMwSt { get; set; }
        public decimal NAnzahl { get; set; }
        public decimal FRabatt { get; set; }
        public string CString { get; set; }
        public decimal FVknetto { get; set; }
        public string CArtNr { get; set; }
        public byte? NType { get; set; }
        public string CHinweis { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
