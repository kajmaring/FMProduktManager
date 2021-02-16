using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TTelefonatEntwurf
    {
        public TTelefonatEntwurf()
        {
            TTelefonatEntwurfAnhang = new HashSet<TTelefonatEntwurfAnhang>();
        }

        public int KTelefonatEntwurf { get; set; }
        public int KTicket { get; set; }
        public int KBenutzer { get; set; }
        public int NRichtung { get; set; }
        public string CTelefonnummer { get; set; }
        public int KFileHtmlInhalt { get; set; }
        public DateTime DErstellung { get; set; }

        public virtual TFile KFileHtmlInhaltNavigation { get; set; }
        public virtual TTicket KTicketNavigation { get; set; }
        public virtual ICollection<TTelefonatEntwurfAnhang> TTelefonatEntwurfAnhang { get; set; }
    }
}
