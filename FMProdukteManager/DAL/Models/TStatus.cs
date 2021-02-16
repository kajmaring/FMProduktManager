using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TStatus
    {
        public TStatus()
        {
            TAusgangskanalEmail = new HashSet<TAusgangskanalEmail>();
            TEingangskanalEmailKStatusNeueAntwortNavigation = new HashSet<TEingangskanalEmail>();
            TEingangskanalEmailKStatusNeuesTicketNavigation = new HashSet<TEingangskanalEmail>();
            TTicket = new HashSet<TTicket>();
        }

        public int KStatus { get; set; }
        public string CName { get; set; }
        public bool NIsDefault { get; set; }

        public virtual ICollection<TAusgangskanalEmail> TAusgangskanalEmail { get; set; }
        public virtual ICollection<TEingangskanalEmail> TEingangskanalEmailKStatusNeueAntwortNavigation { get; set; }
        public virtual ICollection<TEingangskanalEmail> TEingangskanalEmailKStatusNeuesTicketNavigation { get; set; }
        public virtual ICollection<TTicket> TTicket { get; set; }
    }
}
