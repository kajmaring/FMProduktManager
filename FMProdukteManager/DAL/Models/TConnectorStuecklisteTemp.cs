using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TConnectorStuecklisteTemp
    {
        public int? KStueckliste { get; set; }
        public string CVaterId { get; set; }
        public int? KArtikelKind { get; set; }
        public decimal? FAnzahl { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
