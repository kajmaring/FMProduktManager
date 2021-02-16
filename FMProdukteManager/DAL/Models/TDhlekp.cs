using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TDhlekp
    {
        public int KDhlekp { get; set; }
        public string CEkp { get; set; }
        public string CAnmerkung { get; set; }
        public int KShipperAccount { get; set; }

        public virtual TShipperAccount KShipperAccountNavigation { get; set; }
    }
}
