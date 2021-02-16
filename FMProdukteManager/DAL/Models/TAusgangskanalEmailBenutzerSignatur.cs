using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TAusgangskanalEmailBenutzerSignatur
    {
        public int KAusgangskanalEmailBenutzerSignatur { get; set; }
        public int KAusgangskanalEmail { get; set; }
        public int KBenutzer { get; set; }
        public int KFileHtmlInhalt { get; set; }

        public virtual TAusgangskanalEmail KAusgangskanalEmailNavigation { get; set; }
        public virtual TFile KFileHtmlInhaltNavigation { get; set; }
    }
}
