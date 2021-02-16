using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TNachrichtEntwurfTyp
    {
        public int KNachrichtEntwurfTyp { get; set; }
        public int KNachrichtEntwurf { get; set; }
        public int KAntwortkanal { get; set; }
        public int NAntwortTyp { get; set; }

        public virtual TAntwortkanal KAntwortkanalNavigation { get; set; }
        public virtual TNachrichtEntwurf KNachrichtEntwurfNavigation { get; set; }
    }
}
