using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TWaehrungIso
    {
        public string CIso { get; set; }
        public string CName { get; set; }
        public string CLand { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
