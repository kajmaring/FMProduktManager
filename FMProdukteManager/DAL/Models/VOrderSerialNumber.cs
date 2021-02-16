using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class VOrderSerialNumber
    {
        public int KOrder { get; set; }
        public int KOrderPos { get; set; }
        public string CSerialNumber { get; set; }
    }
}
