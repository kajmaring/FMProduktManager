using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Tsynch
    {
        public string CIp { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
