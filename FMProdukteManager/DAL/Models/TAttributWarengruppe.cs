using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TAttributWarengruppe
    {
        public int KAttributWarengruppe { get; set; }
        public int KWarengruppe { get; set; }
        public int KAttribut { get; set; }

        public virtual TAttribut KAttributNavigation { get; set; }
        public virtual TWarengruppe KWarengruppeNavigation { get; set; }
    }
}
