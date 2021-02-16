using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class VDeletedEntity
    {
        public int KEntityId { get; set; }
        public byte NEntityType { get; set; }
        public byte[] BLastChanged { get; set; }
        public int KShop { get; set; }
    }
}
