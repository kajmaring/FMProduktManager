using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TArtikelbildPlattform
    {
        public TArtikelbildPlattform()
        {
            TProductPictureRef = new HashSet<TProductPictureRef>();
        }

        public int KArtikelbildPlattform { get; set; }
        public int KBild { get; set; }
        public int KArtikel { get; set; }
        public int KPlattform { get; set; }
        public int KShop { get; set; }
        public int NNr { get; set; }
        public byte NInet { get; set; }
        public int? KEbayUser { get; set; }
        public string CBildname { get; set; }
        public byte[] BRowversion { get; set; }

        public virtual ICollection<TProductPictureRef> TProductPictureRef { get; set; }
    }
}
