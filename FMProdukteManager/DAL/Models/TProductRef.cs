using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TProductRef
    {
        public int KProductRef { get; set; }
        public int KArtikel { get; set; }
        public byte NType { get; set; }
        public DateTimeOffset DCreatedAt { get; set; }
        public DateTimeOffset? DUpdatedAt { get; set; }
        public string COwnerId { get; set; }
        public string CJfsku { get; set; }
        public byte[] BRowVersion { get; set; }

        public virtual TArtikel KArtikelNavigation { get; set; }
    }
}
