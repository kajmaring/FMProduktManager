using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Tversion
    {
        public string CVersion { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
