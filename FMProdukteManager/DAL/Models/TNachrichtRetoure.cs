using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TNachrichtRetoure
    {
        public int KNachrichtRetoure { get; set; }
        public int KNachricht { get; set; }
        public int KRmretoure { get; set; }
        public string CMatchingWord { get; set; }

        public virtual TNachricht KNachrichtNavigation { get; set; }
    }
}
