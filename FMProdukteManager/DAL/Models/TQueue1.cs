using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TQueue1
    {
        public TQueue1()
        {
            TVorgangQueue = new HashSet<TVorgangQueue>();
        }

        public int KQueue { get; set; }
        public DateTimeOffset DModificationDate { get; set; }
        public DateTimeOffset DCreatedAt { get; set; }
        public DateTimeOffset? DProcessedAt { get; set; }
        public string CSessionId { get; set; }
        public string CRequestId { get; set; }
        public byte NType { get; set; }
        public byte NState { get; set; }
        public byte NRole { get; set; }
        public byte NTarget { get; set; }
        public byte NEvent { get; set; }
        public string CData { get; set; }
        public string CErrorMessage { get; set; }
        public int NPriority { get; set; }

        public virtual ICollection<TVorgangQueue> TVorgangQueue { get; set; }
    }
}
