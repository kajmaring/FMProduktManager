using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class EbayMapitemSuchStrings
    {
        public int KEbayMapitemSuchString { get; set; }
        public string CSuchStringAnfang { get; set; }
        public string CSuchStringEnde { get; set; }
        public byte NSource { get; set; }
    }
}
