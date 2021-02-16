using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TTicketLabel
    {
        public int KTicketLabel { get; set; }
        public int KTicket { get; set; }
        public int KLabel { get; set; }
        public byte[] BRowversion { get; set; }

        public virtual TLabel KLabelNavigation { get; set; }
        public virtual TTicket KTicketNavigation { get; set; }
    }
}
