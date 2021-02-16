using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TTicketEckdaten
    {
        public int KTicket { get; set; }
        public int NAnzahlNachrichten { get; set; }
        public int NAnzahlAnhaenge { get; set; }
        public string CInhaltErsteNachricht { get; set; }
        public int NRichtungLetzteNachricht { get; set; }
        public string CTitelErsteNachricht { get; set; }
        public string CAbsenderErsteNachricht { get; set; }
        public DateTime DEmpfangLetzteNachricht { get; set; }

        public virtual TTicket KTicketNavigation { get; set; }
    }
}
