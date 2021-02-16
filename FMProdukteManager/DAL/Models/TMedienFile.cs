using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TMedienFile
    {
        public int KMedienFile { get; set; }
        public int KMedienDir { get; set; }
        public string CName { get; set; }
        public int? NSize { get; set; }
        public DateTime? DTime { get; set; }
        public short? NDel { get; set; }
        public int KShop { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
