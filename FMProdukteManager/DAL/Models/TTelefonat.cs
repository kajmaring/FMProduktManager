using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TTelefonat
    {
        public TTelefonat()
        {
            TAgentAngeseheneTickets = new HashSet<TAgentAngeseheneTickets>();
            TTelefonatAnhang = new HashSet<TTelefonatAnhang>();
        }

        public int KTelefonat { get; set; }
        public int KTicket { get; set; }
        public int KBenutzer { get; set; }
        public int NRichtung { get; set; }
        public string CTelefonnummer { get; set; }
        public int KFileHtmlInhalt { get; set; }
        public DateTime DErstellung { get; set; }

        public virtual TFile KFileHtmlInhaltNavigation { get; set; }
        public virtual TTicket KTicketNavigation { get; set; }
        public virtual ICollection<TAgentAngeseheneTickets> TAgentAngeseheneTickets { get; set; }
        public virtual ICollection<TTelefonatAnhang> TTelefonatAnhang { get; set; }
    }
}
