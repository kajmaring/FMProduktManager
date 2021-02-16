using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TGlobalsQueue
    {
        public int? KShop { get; set; }
        public byte? NType { get; set; }
        public string CName { get; set; }
        public int? KKey { get; set; }
        public string CText { get; set; }
        public DateTime? DTimeStamp { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
