using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TAntwortkanal
    {
        public TAntwortkanal()
        {
            TErreichbarkeit = new HashSet<TErreichbarkeit>();
            TNachrichtEntwurfTyp = new HashSet<TNachrichtEntwurfTyp>();
            TNachrichtTyp = new HashSet<TNachrichtTyp>();
        }

        public int KAntwortkanal { get; set; }
        public string CAdresse { get; set; }
        public DateTime DErstellung { get; set; }
        public DateTime? DDeaktivierung { get; set; }
        public byte[] BRowversion { get; set; }
        public byte NTyp { get; set; }

        public virtual ICollection<TErreichbarkeit> TErreichbarkeit { get; set; }
        public virtual ICollection<TNachrichtEntwurfTyp> TNachrichtEntwurfTyp { get; set; }
        public virtual ICollection<TNachrichtTyp> TNachrichtTyp { get; set; }
    }
}
