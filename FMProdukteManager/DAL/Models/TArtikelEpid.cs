using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TArtikelEpid
    {
        public long KArtikelEpid { get; set; }
        public int KArtikel { get; set; }
        public int KSiteId { get; set; }
        public string CEpid { get; set; }
        public byte[] BRowversion { get; set; }

        public virtual TArtikel KArtikelNavigation { get; set; }
        public virtual EbayXxSites KSite { get; set; }
    }
}
