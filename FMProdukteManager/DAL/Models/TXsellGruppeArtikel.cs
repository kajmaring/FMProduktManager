using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TXsellGruppeArtikel
    {
        public int KXsellGruppeArtikel { get; set; }
        public int? TXsellGruppe { get; set; }
        public int? KArtikel { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
