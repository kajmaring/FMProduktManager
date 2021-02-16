using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TNotiz1
    {
        public TNotiz1()
        {
            TAgentAngeseheneTickets = new HashSet<TAgentAngeseheneTickets>();
            TNotizAnhang = new HashSet<TNotizAnhang>();
        }

        public int KNotiz { get; set; }
        public string CBeschreibung { get; set; }
        public DateTime DErstellung { get; set; }
        public byte[] BRowversion { get; set; }
        public int KTicket { get; set; }
        public int KBenutzer { get; set; }
        public int KFileHtmlInhalt { get; set; }

        public virtual TFile KFileHtmlInhaltNavigation { get; set; }
        public virtual TTicket KTicketNavigation { get; set; }
        public virtual ICollection<TAgentAngeseheneTickets> TAgentAngeseheneTickets { get; set; }
        public virtual ICollection<TNotizAnhang> TNotizAnhang { get; set; }
    }
}
