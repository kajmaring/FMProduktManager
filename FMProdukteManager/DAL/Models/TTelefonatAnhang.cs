using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TTelefonatAnhang
    {
        public int KTelefonatAnhang { get; set; }
        public int KTelefonat { get; set; }
        public int KAnhang { get; set; }
        public byte[] BRowversion { get; set; }

        public virtual TFile KAnhangNavigation { get; set; }
        public virtual TTelefonat KTelefonatNavigation { get; set; }
    }
}
