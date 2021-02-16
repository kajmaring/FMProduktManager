using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TLogin
    {
        public int KLogin { get; set; }
        public string CUserId { get; set; }
        public bool BFulfiller { get; set; }
        public bool BMerchant { get; set; }
    }
}
