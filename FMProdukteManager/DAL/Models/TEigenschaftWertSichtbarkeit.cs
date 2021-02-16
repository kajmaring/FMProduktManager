using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TEigenschaftWertSichtbarkeit
    {
        public int KEigenschaftWert { get; set; }
        public int KKundenGruppe { get; set; }
        public int KShop { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
