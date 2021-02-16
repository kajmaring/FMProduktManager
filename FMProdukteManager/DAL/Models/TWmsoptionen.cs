using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TWmsoptionen
    {
        public string CName { get; set; }
        public string CWert { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
