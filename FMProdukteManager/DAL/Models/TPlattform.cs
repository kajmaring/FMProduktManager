using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TPlattform
    {
        public int NPlattform { get; set; }
        public string CName { get; set; }
        public string CId { get; set; }
        public int NInet { get; set; }
        public string CWaehrung { get; set; }
        public int NTyp { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
