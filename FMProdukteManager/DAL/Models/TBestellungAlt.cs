using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TBestellungAlt
    {
        public int KBestellungAlt { get; set; }
        public int KBestellungNeu { get; set; }
        public string CBestellNr { get; set; }
        public string DErstellt { get; set; }
        public int? KInetBestellung { get; set; }
        public string CVersandInfo { get; set; }
        public string DVersandt { get; set; }
        public string CIdentCode { get; set; }
        public string DLieferDatum { get; set; }
        public int? KBestellHinweis { get; set; }
        public int? KShop { get; set; }
        public int? KLogistik { get; set; }
        public byte? NPlatform { get; set; }
        public decimal FGutschein { get; set; }
        public string CInetBestellung { get; set; }
        public string CStatus { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
