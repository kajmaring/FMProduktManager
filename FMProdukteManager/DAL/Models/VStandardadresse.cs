using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class VStandardadresse
    {
        public int KKunde { get; set; }
        public string CKundenNr { get; set; }
        public string CKundengruppe { get; set; }
        public string CKundeEbayName { get; set; }
        public string CFirma { get; set; }
        public string CVorname { get; set; }
        public string CName { get; set; }
        public string CStrasse { get; set; }
        public string CPlz { get; set; }
        public string COrt { get; set; }
        public string CLand { get; set; }
        public string CBundesland { get; set; }
        public string CTel { get; set; }
        public string CFax { get; set; }
        public string CMail { get; set; }
        public string CUstid { get; set; }
    }
}
