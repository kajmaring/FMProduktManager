using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TBundesland
    {
        public string CIsoland { get; set; }
        public string CBundesland { get; set; }
        public string CKuerzelBundesland { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
