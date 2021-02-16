using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TQueue2
    {
        public int KQueue { get; set; }
        public string CFehler { get; set; }
        public string CJson { get; set; }
        public byte NCount { get; set; }
        public int NFailedStep { get; set; }
        public int KAuftrag { get; set; }
        public int KShop { get; set; }
        public int KShopSubShop { get; set; }
        public bool NInBearbeitung { get; set; }
    }
}
