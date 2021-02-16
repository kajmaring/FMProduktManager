using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TNachrichtPreisanfrage
    {
        public int KNachrichtPreisanfrage { get; set; }
        public int KNachricht { get; set; }
        public int KLieferantenbestellung { get; set; }
        public string CMatchingWord { get; set; }

        public virtual TNachricht KNachrichtNavigation { get; set; }
    }
}
