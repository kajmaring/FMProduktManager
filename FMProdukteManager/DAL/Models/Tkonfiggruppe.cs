using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Tkonfiggruppe
    {
        public int KKonfiggruppe { get; set; }
        public byte[] Bild { get; set; }
        public int? NMin { get; set; }
        public int? NMax { get; set; }
        public int? NTyp { get; set; }
        public int? NSort { get; set; }
        public string CKommentar { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
