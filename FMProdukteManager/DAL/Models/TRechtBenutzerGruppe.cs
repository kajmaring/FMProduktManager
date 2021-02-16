using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TRechtBenutzerGruppe
    {
        public int KRechtBenutzerGruppe { get; set; }
        public string CName { get; set; }
        public string CBeschreibung { get; set; }
        public byte? NIsAdmin { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
