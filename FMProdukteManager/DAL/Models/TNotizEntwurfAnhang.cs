using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TNotizEntwurfAnhang
    {
        public int KNotizEntwurfAnhang { get; set; }
        public int KNotizEntwurf { get; set; }
        public int KAnhang { get; set; }

        public virtual TFile KAnhangNavigation { get; set; }
        public virtual TNotizEntwurf KNotizEntwurfNavigation { get; set; }
    }
}
