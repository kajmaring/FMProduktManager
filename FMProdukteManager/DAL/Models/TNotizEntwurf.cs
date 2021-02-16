using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TNotizEntwurf
    {
        public TNotizEntwurf()
        {
            TNotizEntwurfAnhang = new HashSet<TNotizEntwurfAnhang>();
        }

        public int KNotizEntwurf { get; set; }
        public int KTicket { get; set; }
        public int KBenutzer { get; set; }
        public string CBetreff { get; set; }
        public DateTime DErstelldatum { get; set; }
        public int? KFileHtmlInhalt { get; set; }

        public virtual TFile KFileHtmlInhaltNavigation { get; set; }
        public virtual TTicket KTicketNavigation { get; set; }
        public virtual ICollection<TNotizEntwurfAnhang> TNotizEntwurfAnhang { get; set; }
    }
}
