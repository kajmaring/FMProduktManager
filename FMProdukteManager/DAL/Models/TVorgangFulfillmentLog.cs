using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TVorgangFulfillmentLog
    {
        public int KVorgangFulfillmentLog { get; set; }
        public int KVorgang { get; set; }
        public int KFulfillmentLog { get; set; }

        public virtual TFulfillmentLog KFulfillmentLogNavigation { get; set; }
        public virtual TVorgang KVorgangNavigation { get; set; }
    }
}
