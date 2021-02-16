using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TNachrichtEntwurfAnhang
    {
        public int KNachrichtEntwurfAnhang { get; set; }
        public int KNachrichtEntwurf { get; set; }
        public int KAnhang { get; set; }

        public virtual TFile KAnhangNavigation { get; set; }
        public virtual TNachrichtEntwurf KNachrichtEntwurfNavigation { get; set; }
    }
}
