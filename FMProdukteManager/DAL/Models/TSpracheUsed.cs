using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TSpracheUsed
    {
        public int KSprache { get; set; }
        public string CNameEng { get; set; }
        public string CNameDeu { get; set; }
        public string CIso { get; set; }
        public byte? NStandard { get; set; }
        public string CKultur { get; set; }
        public string CIso2 { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
