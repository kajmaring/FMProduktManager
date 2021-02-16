using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TLizenzInfo
    {
        public int KApplication { get; set; }
        public string CShopType { get; set; }
        public DateTime DLastUsed { get; set; }
        public int KLicense { get; set; }
    }
}
