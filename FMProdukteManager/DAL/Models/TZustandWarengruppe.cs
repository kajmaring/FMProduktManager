using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TZustandWarengruppe
    {
        public int KZustandWarengruppe { get; set; }
        public int KZustand { get; set; }
        public int KWarengruppe { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
