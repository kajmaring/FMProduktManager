using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class PosgastroGastroBon
    {
        public long KGastroBon { get; set; }
        public long KKasse { get; set; }
        public long? NTyp { get; set; }
        public long? NBelegNr { get; set; }
        public long? KGastroDrucker { get; set; }
        public long? KTisch { get; set; }
        public DateTime? DErstellung { get; set; }
        public long? NKopiendruck { get; set; }
        public byte[] CData { get; set; }
    }
}
