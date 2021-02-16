using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class LvRetouren
    {
        public int KKunde { get; set; }
        public int KRmretoure { get; set; }
        public int? KBestellungUmtausch { get; set; }
        public int? KGutschrift { get; set; }
        public string CRetoureNr { get; set; }
        public DateTime DErstellt { get; set; }
        public byte NStatusTyp { get; set; }
        public string Warenlagername { get; set; }
        public string Status { get; set; }
        public string Firma { get; set; }
        public string BestellNr { get; set; }
    }
}
