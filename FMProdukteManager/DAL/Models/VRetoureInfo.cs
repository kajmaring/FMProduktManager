using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class VRetoureInfo
    {
        public int IsFulfillmentWareHouse { get; set; }
        public int KRmretoure { get; set; }
        public byte StatusTyp { get; set; }
        public string FfnReturnId { get; set; }
        public int IsMerchant { get; set; }
        public string LieferantId { get; set; }
    }
}
