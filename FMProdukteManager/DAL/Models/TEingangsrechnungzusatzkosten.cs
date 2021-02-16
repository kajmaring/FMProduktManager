using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TEingangsrechnungzusatzkosten
    {
        public int KZusatzkosten { get; set; }
        public string CName { get; set; }
        public byte? NGld { get; set; }
        public byte? NPreis { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
