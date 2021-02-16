using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TEigenschaftKombiWert
    {
        public int KEigenschaftKombi { get; set; }
        public int KEigenschaft { get; set; }
        public int? KEigenschaftWert { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
