using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TNachrichtEntwurf
    {
        public TNachrichtEntwurf()
        {
            TNachrichtEntwurfAnhang = new HashSet<TNachrichtEntwurfAnhang>();
            TNachrichtEntwurfTyp = new HashSet<TNachrichtEntwurfTyp>();
        }

        public int KNachrichtEntwurf { get; set; }
        public int KTicket { get; set; }
        public int KBenutzer { get; set; }
        public string CBetreff { get; set; }
        public DateTime DErstelldatum { get; set; }
        public int? KFileHtmlInhalt { get; set; }
        public int? KAusgangskanalEmail { get; set; }

        public virtual TAusgangskanalEmail KAusgangskanalEmailNavigation { get; set; }
        public virtual TFile KFileHtmlInhaltNavigation { get; set; }
        public virtual TTicket KTicketNavigation { get; set; }
        public virtual ICollection<TNachrichtEntwurfAnhang> TNachrichtEntwurfAnhang { get; set; }
        public virtual ICollection<TNachrichtEntwurfTyp> TNachrichtEntwurfTyp { get; set; }
    }
}
