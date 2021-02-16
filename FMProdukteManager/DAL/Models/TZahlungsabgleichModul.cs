using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TZahlungsabgleichModul
    {
        public int KZahlungsabgleichModul { get; set; }
        public string CModulId { get; set; }
        public string CEinstellungen { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
