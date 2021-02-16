using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TAttributSprache
    {
        public int KAttribut { get; set; }
        public int KSprache { get; set; }
        public string CName { get; set; }
        public string CWertListe { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
