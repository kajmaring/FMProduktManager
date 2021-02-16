using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TCsvSettings
    {
        public string CKey { get; set; }
        public string CDelmiter { get; set; }
        public string CQuote { get; set; }
        public string CEscape { get; set; }
        public string CComment { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
