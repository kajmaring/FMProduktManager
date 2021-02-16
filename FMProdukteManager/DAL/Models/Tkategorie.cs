using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Tkategorie
    {
        public int KKategorie { get; set; }
        public int? KOberKategorie { get; set; }
        public string CInet { get; set; }
        public string CAktiv { get; set; }
        public string CDelInet { get; set; }
        public int? NSort { get; set; }
        public byte[] BRowversion { get; set; }

        public virtual TCategoryRef TCategoryRef { get; set; }
    }
}
