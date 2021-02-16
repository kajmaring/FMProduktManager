using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TBestellHinweis
    {
        public int KBestellHinweis { get; set; }
        public string CText { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
