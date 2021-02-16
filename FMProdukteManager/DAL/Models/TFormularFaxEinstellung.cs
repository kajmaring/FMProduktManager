using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TFormularFaxEinstellung
    {
        public int KFormularFaxEinstellung { get; set; }
        public int KFormular { get; set; }
        public string CRechnername { get; set; }
        public int? KBenutzer { get; set; }
        public string CFaxname { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
