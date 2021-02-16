using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TFormularEmailEinstellung
    {
        public int KFormularEmailEinstellung { get; set; }
        public int KFormular { get; set; }
        public string CBcc { get; set; }
        public byte NSignieren { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
