using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class PosBonpark
    {
        public long KBonpark { get; set; }
        public DateTime DDatum { get; set; }
        public int KBenutzer { get; set; }
        public string CBenutzerName { get; set; }
        public int KKunde { get; set; }
        public string CKundeName { get; set; }
        public int KKasse { get; set; }
        public float FBetrag { get; set; }
        public float FAnzahl { get; set; }
        public byte[] CData { get; set; }
    }
}
