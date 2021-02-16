using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TVordefinierteAntwort
    {
        public int KVordefinierteAntwort { get; set; }
        public string CName { get; set; }
        public string CBeschreibung { get; set; }
        public int KBenutzer { get; set; }
        public byte NIndex { get; set; }
        public int KFileHtmlInhalt { get; set; }

        public virtual TFile KFileHtmlInhaltNavigation { get; set; }
    }
}
