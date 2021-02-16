using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TLizenzlog
    {
        public int KLizenzlog { get; set; }
        public byte NTyp { get; set; }
        public string CAufruf { get; set; }
        public string CLog { get; set; }
        public DateTime? DDatum { get; set; }
    }
}
