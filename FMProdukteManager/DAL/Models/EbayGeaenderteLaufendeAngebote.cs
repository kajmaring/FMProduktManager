using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class EbayGeaenderteLaufendeAngebote
    {
        public int KItem { get; set; }
        public int? NChanges { get; set; }
        public byte NTryUpload { get; set; }
    }
}
