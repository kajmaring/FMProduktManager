using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TGebuehrtyp
    {
        public int KGebuehrtyp { get; set; }
        public string CName { get; set; }
        public string CNameExtern { get; set; }
        public int NTyp { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
