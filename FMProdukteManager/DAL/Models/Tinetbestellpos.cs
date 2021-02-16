using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Tinetbestellpos
    {
        public int KInetBestellPos { get; set; }
        public int? KInetBestellung { get; set; }
        public int? KArikel { get; set; }
        public decimal FPreis { get; set; }
        public decimal FMwSt { get; set; }
        public decimal NAnzahl { get; set; }
        public string CName { get; set; }
        public int KShop { get; set; }
        public byte? NType { get; set; }
        public string CHinweis { get; set; }
        public int? NHatUpload { get; set; }
        public string CUnique { get; set; }
        public int? KKonfigitem { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
