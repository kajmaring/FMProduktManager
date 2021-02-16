using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class PosPlugin
    {
        public long KPlugin { get; set; }
        public string CEid { get; set; }
        public string COid { get; set; }
        public long? NVersion { get; set; }
        public byte[] CData { get; set; }
    }
}
