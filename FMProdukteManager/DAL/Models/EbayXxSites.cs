using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class EbayXxSites
    {
        public EbayXxSites()
        {
            TArtikelEpid = new HashSet<TArtikelEpid>();
        }

        public int SiteId { get; set; }
        public string CAbbreviation { get; set; }
        public string CName { get; set; }
        public string CSiteCodeType { get; set; }
        public string CSprachIso { get; set; }
        public string CLandIso { get; set; }
        public DateTime? DLastUpdate { get; set; }
        public int NVersion { get; set; }
        public string Www { get; set; }
        public int KPlattform { get; set; }
        public string CWaehrungIso { get; set; }

        public virtual ICollection<TArtikelEpid> TArtikelEpid { get; set; }
    }
}
