using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TFeldTyp
    {
        public int KFeldTyp { get; set; }
        public string CName { get; set; }
        public byte NDatenTyp { get; set; }
        public string CRegEx { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
