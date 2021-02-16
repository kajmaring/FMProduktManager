using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class VMerchantProductPicture
    {
        public int KArtikelbildPlattform { get; set; }
        public int KArtikel { get; set; }
        public int KPlattform { get; set; }
        public int NNr { get; set; }
        public int KBild { get; set; }
        public byte[] BBild { get; set; }
        public byte[] BBildRowVersion { get; set; }
        public int? NFfnNumber { get; set; }
        public byte[] BProductPictureRefBildRowVersion { get; set; }
    }
}
