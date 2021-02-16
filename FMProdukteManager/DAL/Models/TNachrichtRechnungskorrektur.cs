using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TNachrichtRechnungskorrektur
    {
        public int KNachrichtRechnungskorrektur { get; set; }
        public int KNachricht { get; set; }
        public int KGutschrift { get; set; }
        public string CMatchingWord { get; set; }

        public virtual TNachricht KNachrichtNavigation { get; set; }
    }
}
