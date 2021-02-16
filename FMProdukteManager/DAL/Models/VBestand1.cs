using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class VBestand1
    {
        public string Artikelnummer { get; set; }
        public string EigenerLagerbestand { get; set; }
        public string GesamterLagerbestand { get; set; }
        public string VerfügbarerBestand { get; set; }
        public string FürVerfügbarkeitGesperrt { get; set; }
        public string AnzahlInAufträgen { get; set; }
        public string Zulauf { get; set; }
        public string CodeZumKorigieren { get; set; }
        public int KArtikel { get; set; }
    }
}
