using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TVersandtoolDruckEinstellung
    {
        public int KVersandtoolDruckEinstellung { get; set; }
        public byte NVersandSchnittstelle { get; set; }
        public string CRechnername { get; set; }
        public int? KBenutzer { get; set; }
        public string CDruckername { get; set; }
        public byte? NPageScaling { get; set; }
        public byte? NOrientation { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
