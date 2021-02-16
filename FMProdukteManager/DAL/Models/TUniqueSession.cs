using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TUniqueSession
    {
        public int KSession { get; set; }
        public string CContext { get; set; }
        public DateTime DLastCallback { get; set; }
        public string CInfo { get; set; }
        public byte[] BRowversion { get; set; }
        public string CRechnername { get; set; }
    }
}
