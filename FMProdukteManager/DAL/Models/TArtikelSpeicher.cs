using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TArtikelSpeicher
    {
        public int KArtikel { get; set; }
        public string CNummer { get; set; }
        public byte NId { get; set; }
        public byte? NAktiv { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
