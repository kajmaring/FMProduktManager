using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TConfiguration
    {
        public int KConfig { get; set; }
        public int KBenutzer { get; set; }
        public string Arbeitsplatz { get; set; }
        public int Typ { get; set; }
        public int ElementId { get; set; }
        public string Configuration { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
