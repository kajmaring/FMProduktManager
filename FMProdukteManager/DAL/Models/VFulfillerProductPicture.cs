using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class VFulfillerProductPicture
    {
        public int KArtikelbildPlattform { get; set; }
        public int KArtikel { get; set; }
        public int KPlattform { get; set; }
        public int NNr { get; set; }
        public int KShop { get; set; }
        public int? KEbayUser { get; set; }
        public int KBild { get; set; }
        public byte[] BBildRowVersion { get; set; }
        public byte[] BBild { get; set; }
    }
}
