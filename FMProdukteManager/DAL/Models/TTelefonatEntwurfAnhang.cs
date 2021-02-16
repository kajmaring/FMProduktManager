using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TTelefonatEntwurfAnhang
    {
        public int KTelefonatEntwurfAnhang { get; set; }
        public int KTelefonatEntwurf { get; set; }
        public int KAnhang { get; set; }

        public virtual TFile KAnhangNavigation { get; set; }
        public virtual TTelefonatEntwurf KTelefonatEntwurfNavigation { get; set; }
    }
}
