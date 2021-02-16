using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TVersandKonfigurationArtikelZustand
    {
        public int KVersandKonfiguration { get; set; }
        public int KZustand { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
