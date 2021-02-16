using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TNachrichtEingangsrechnung
    {
        public int KNachrichtEingangsrechnung { get; set; }
        public int KNachricht { get; set; }
        public int KEingangsrechnung { get; set; }
        public string CMatchingWord { get; set; }

        public virtual TNachricht KNachrichtNavigation { get; set; }
    }
}
