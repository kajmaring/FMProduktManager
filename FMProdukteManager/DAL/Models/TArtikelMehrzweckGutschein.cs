using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TArtikelMehrzweckGutschein
    {
        public int KArtikel { get; set; }
        public byte NIsMehrzweckGutschein { get; set; }
        public int NGutscheinTyp { get; set; }
        public int NGutscheinVersandArt { get; set; }
        public int? KGutscheinDruckVorlage { get; set; }
        public string CIso { get; set; }
        public decimal? NBetrag { get; set; }
        public string CKampagne { get; set; }

        public virtual TArtikel KArtikelNavigation { get; set; }
    }
}
