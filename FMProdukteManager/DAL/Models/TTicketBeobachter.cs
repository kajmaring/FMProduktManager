using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TTicketBeobachter
    {
        public int KTicketBeobachter { get; set; }
        public int KTicket { get; set; }
        public int KBenutzer { get; set; }
        public byte[] BRowversion { get; set; }

        public virtual TTicket KTicketNavigation { get; set; }
    }
}
