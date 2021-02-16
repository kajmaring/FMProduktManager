using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class VTicketLabels
    {
        public int TicketLabelKey { get; set; }
        public int TicketKey { get; set; }
        public int LabelKey { get; set; }
        public string Displayname { get; set; }
        public string ColorCode { get; set; }
    }
}
