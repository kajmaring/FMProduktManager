using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TKundenDrucktext
    {
        public int KKundenDrucktext { get; set; }
        public string CName { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
