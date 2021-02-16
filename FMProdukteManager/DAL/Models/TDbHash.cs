using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TDbHash
    {
        public string CSchema { get; set; }
        public string CName { get; set; }
        public byte[] CHashLocal { get; set; }
        public byte[] CHashJtl { get; set; }
    }
}
