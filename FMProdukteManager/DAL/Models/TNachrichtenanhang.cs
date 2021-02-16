using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TNachrichtenanhang
    {
        public int KNachrichtenanhang { get; set; }
        public int KNachricht { get; set; }
        public int KAnhang { get; set; }
        public byte[] BRowversion { get; set; }
        public byte NFreigabeStatus { get; set; }
        public int? KBenutzerFreigabeStatus { get; set; }

        public virtual TFile KAnhangNavigation { get; set; }
        public virtual TNachricht KNachrichtNavigation { get; set; }
    }
}
