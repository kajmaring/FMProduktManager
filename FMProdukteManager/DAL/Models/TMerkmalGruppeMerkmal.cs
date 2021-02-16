using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TMerkmalGruppeMerkmal
    {
        public int KMerkmalGruppe { get; set; }
        public int KMerkmal { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
