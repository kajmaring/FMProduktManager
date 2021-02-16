using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TArtikelbildPlattformSeo
    {
        public int KArtikelbildPlattformSeo { get; set; }
        public int KArtikelbildPlattform { get; set; }
        public int KSprache { get; set; }
        public string CAlternativtext { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
