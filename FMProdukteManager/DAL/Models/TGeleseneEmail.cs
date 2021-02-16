using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TGeleseneEmail
    {
        public string CUniqueId { get; set; }
        public int KEingangskanalEmail { get; set; }
        public int? KNachricht { get; set; }
        public int KGeleseneEmail { get; set; }

        public virtual TEingangskanalEmail KEingangskanalEmailNavigation { get; set; }
        public virtual TNachricht KNachrichtNavigation { get; set; }
    }
}
