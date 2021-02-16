using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TAttribut
    {
        public TAttribut()
        {
            TAttributWarengruppe = new HashSet<TAttributWarengruppe>();
            TKundeEigenesFeld = new HashSet<TKundeEigenesFeld>();
        }

        public int KAttribut { get; set; }
        public byte NIstMehrsprachig { get; set; }
        public byte NIstFreifeld { get; set; }
        public int NSortierung { get; set; }
        public string CBeschreibung { get; set; }
        public byte NBezugstyp { get; set; }
        public byte NAusgabeweg { get; set; }
        public byte NIstStandard { get; set; }
        public int KFeldTyp { get; set; }
        public string CRegEx { get; set; }
        public string CGruppeName { get; set; }
        public byte NReadOnly { get; set; }
        public byte[] BRowversion { get; set; }
        public bool? NAktivFuerArtikelOhneWarengruppe { get; set; }

        public virtual ICollection<TAttributWarengruppe> TAttributWarengruppe { get; set; }
        public virtual ICollection<TKundeEigenesFeld> TKundeEigenesFeld { get; set; }
    }
}
