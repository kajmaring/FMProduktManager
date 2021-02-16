using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TSteuerzoneLand
    {
        public int KSteuerzone { get; set; }
        public string CIso { get; set; }
        public string CKuerzelBundesland { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
