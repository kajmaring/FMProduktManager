using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TNachrichtArtikel
    {
        public int KNachrichtArtikel { get; set; }
        public int KNachricht { get; set; }
        public int KArtikel { get; set; }
        public string CMatchingWord { get; set; }

        public virtual TArtikel KArtikelNavigation { get; set; }
        public virtual TNachricht KNachrichtNavigation { get; set; }
    }
}
