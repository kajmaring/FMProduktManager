using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TSubStatistikZustand
    {
        public int KBenutzer { get; set; }
        public byte KSubStatistik { get; set; }
        public string CWert { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
