using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TFulfillmentWorker
    {
        public int KFulfillmentWorker { get; set; }
        public int NTaskId { get; set; }
        public DateTime DUpdated { get; set; }
        public string CTaskId { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
