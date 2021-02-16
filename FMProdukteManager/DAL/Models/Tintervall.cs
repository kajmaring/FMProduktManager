using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Tintervall
    {
        public int KIntervall { get; set; }
        public int? KBestellung { get; set; }
        public DateTime? DStartdatum { get; set; }
        public DateTime? DEnddatum { get; set; }
        public short? NAlleXtage { get; set; }
        public short? NAlleXmonate { get; set; }
        public short? AmMonatsende { get; set; }
        public short? NAlleXjahre { get; set; }
        public int? KLieferAdresse { get; set; }
        public int? KRechnungsAdresse { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
