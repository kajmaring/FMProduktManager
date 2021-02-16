using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TArtikelLabel
    {
        public int KArtikel { get; set; }
        public int KLabel { get; set; }
        public byte[] BRowversion { get; set; }

        public virtual TArtikel KArtikelNavigation { get; set; }
    }
}
