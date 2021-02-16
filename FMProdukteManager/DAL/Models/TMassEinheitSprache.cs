using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TMassEinheitSprache
    {
        public int KMassEinheit { get; set; }
        public int KSprache { get; set; }
        public string CName { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
