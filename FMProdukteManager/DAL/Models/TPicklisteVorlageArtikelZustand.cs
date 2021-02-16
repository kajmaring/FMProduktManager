using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TPicklisteVorlageArtikelZustand
    {
        public int KPicklisteVorlage { get; set; }
        public int KZustand { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
