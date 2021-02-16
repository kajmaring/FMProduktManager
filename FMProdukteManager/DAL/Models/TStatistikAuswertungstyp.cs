using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TStatistikAuswertungstyp
    {
        public int KStatistikAuswertungstyp { get; set; }
        public string CName { get; set; }
        public byte? NSort { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
