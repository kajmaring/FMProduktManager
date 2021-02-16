using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TNachrichtRechnung
    {
        public int KNachrichtRechnung { get; set; }
        public int KNachricht { get; set; }
        public int KRechnung { get; set; }
        public string CMatchingWord { get; set; }

        public virtual TNachricht KNachrichtNavigation { get; set; }
    }
}
