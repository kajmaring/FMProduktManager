using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TTicketRelation
    {
        public int KTicketRelation { get; set; }
        public int KBasisticket { get; set; }
        public int KVerknuepftesTicket { get; set; }
        public DateTime DErstelldatum { get; set; }
        public int KBenutzer { get; set; }

        public virtual TTicket KBasisticketNavigation { get; set; }
        public virtual TTicket KVerknuepftesTicketNavigation { get; set; }
    }
}
