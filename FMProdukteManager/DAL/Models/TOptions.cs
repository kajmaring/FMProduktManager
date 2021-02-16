using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TOptions
    {
        public string CKey { get; set; }
        public string CValue { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
