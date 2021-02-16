using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TErrorlog
    {
        public int KErrorlog { get; set; }
        public string CRechnername { get; set; }
        public DateTime DErstelltUtc { get; set; }
        public bool NIstWorker { get; set; }
        public long NFehlerId { get; set; }
        public string CMeldung { get; set; }
    }
}
