using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TWorklog
    {
        public int KWorkerlog { get; set; }
        public string CMessage { get; set; }
        public long NErrorId { get; set; }
        public DateTime DDate { get; set; }
    }
}
