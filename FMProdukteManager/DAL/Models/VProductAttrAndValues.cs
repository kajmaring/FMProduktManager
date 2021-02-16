using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class VProductAttrAndValues
    {
        public int KAttribut { get; set; }
        public byte NIstFreifeld { get; set; }
        public byte NIstMehrsprachig { get; set; }
        public int KArtikel { get; set; }
        public string CIso { get; set; }
        public string CName { get; set; }
        public string CValue { get; set; }
    }
}
