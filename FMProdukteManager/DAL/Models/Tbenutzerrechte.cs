using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Tbenutzerrechte
    {
        public int? KBenutzerRechte { get; set; }
        public int? KBenutzer { get; set; }
        public int? NRechte { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
