using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class EbayLogbuch
    {
        public int KEbayLogbuch { get; set; }
        public int KEbayuser { get; set; }
        public string CBetreff { get; set; }
        public int NKategorie { get; set; }
        public int NTyp { get; set; }
        public string CLog { get; set; }
        public DateTime DZeit { get; set; }
    }
}
