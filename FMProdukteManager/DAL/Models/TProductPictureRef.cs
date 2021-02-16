using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TProductPictureRef
    {
        public int KProductPictureRef { get; set; }
        public int KArtikelbildPlattform { get; set; }
        public int KBild { get; set; }
        public int KArtikel { get; set; }
        public byte NType { get; set; }
        public DateTimeOffset DCreatedAt { get; set; }
        public DateTimeOffset DUpdatedAt { get; set; }
        public string COwnerId { get; set; }
        public string CFfnPublicUrl { get; set; }
        public string CFfnHash { get; set; }
        public int NFfnNumber { get; set; }
        public byte[] BBildRowVersion { get; set; }

        public virtual TArtikelbildPlattform KArtikelbildPlattformNavigation { get; set; }
    }
}
