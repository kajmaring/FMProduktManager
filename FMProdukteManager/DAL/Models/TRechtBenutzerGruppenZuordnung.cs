using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TRechtBenutzerGruppenZuordnung
    {
        public int KRechtBenutzerGruppe { get; set; }
        public int KBenutzer { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
