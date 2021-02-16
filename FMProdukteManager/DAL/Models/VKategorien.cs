using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class VKategorien
    {
        public string CName { get; set; }
        public string Pfad { get; set; }
        public int? Ebene { get; set; }
        public int? KKategorie { get; set; }
        public string Sort { get; set; }
    }
}
