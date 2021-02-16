using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TVorgangQueue
    {
        public int KVorgangQueue { get; set; }
        public int KVorgang { get; set; }
        public int KQueue { get; set; }

        public virtual TQueue1 KQueueNavigation { get; set; }
        public virtual TVorgang KVorgangNavigation { get; set; }
    }
}
