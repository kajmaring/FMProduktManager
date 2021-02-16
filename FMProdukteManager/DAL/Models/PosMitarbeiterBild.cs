using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class PosMitarbeiterBild
    {
        public long KMitarbeiterBild { get; set; }
        public long KBenutzer { get; set; }
        public DateTime? DDatum { get; set; }
        public long? NBreite { get; set; }
        public long? NHoehe { get; set; }
        public string CHash { get; set; }
        public byte[] BBild { get; set; }
        public byte[] BBildVorschau { get; set; }
    }
}
