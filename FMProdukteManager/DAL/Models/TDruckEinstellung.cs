using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TDruckEinstellung
    {
        public int KDruckEinstellung { get; set; }
        public int KBenutzer { get; set; }
        public string CArbeitsplatz { get; set; }
        public int KDruckvorlage { get; set; }
        public string CDruckername1 { get; set; }
        public string CDruckername2 { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
