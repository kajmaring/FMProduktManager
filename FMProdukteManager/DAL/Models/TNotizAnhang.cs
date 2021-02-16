using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TNotizAnhang
    {
        public int KNotizAnhang { get; set; }
        public int KNotiz { get; set; }
        public int KAnhang { get; set; }
        public byte[] BRowversion { get; set; }

        public virtual TFile KAnhangNavigation { get; set; }
        public virtual TNotiz1 KNotizNavigation { get; set; }
    }
}
