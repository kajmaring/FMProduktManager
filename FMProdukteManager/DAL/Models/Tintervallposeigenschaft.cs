using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Tintervallposeigenschaft
    {
        public int KIntervallPos { get; set; }
        public int? KBestellEigenschaft { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
