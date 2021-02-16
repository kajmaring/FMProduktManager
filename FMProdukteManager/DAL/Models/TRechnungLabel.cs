using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TRechnungLabel
    {
        public int KRechnung { get; set; }
        public int KLabel { get; set; }
        public byte[] BRowversion { get; set; }

        public virtual Trechnung KRechnungNavigation { get; set; }
    }
}
