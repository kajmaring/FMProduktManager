using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TAktiverAbgleich
    {
        public int KAktiverEmailAbgleich { get; set; }
        public string CHostname { get; set; }
        public DateTime DLock { get; set; }
    }
}
