using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TNachrichtAngebot
    {
        public int KNachrichtAngebot { get; set; }
        public int KNachricht { get; set; }
        public int KAuftrag { get; set; }
        public string CMatchingWord { get; set; }

        public virtual TNachricht KNachrichtNavigation { get; set; }
    }
}
