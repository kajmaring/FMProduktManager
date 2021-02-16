using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TErloeskonten
    {
        public int KErloeskonten { get; set; }
        public string CName { get; set; }
        public byte? NType { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
