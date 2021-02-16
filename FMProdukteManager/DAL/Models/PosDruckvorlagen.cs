using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class PosDruckvorlagen
    {
        public int KDruckvorlage { get; set; }
        public string CBezeichnung { get; set; }
        public string CVorlagenOid { get; set; }
        public int? CVersion { get; set; }
        public string CTyp { get; set; }
        public string CKlasse { get; set; }
        public string CInfo { get; set; }
        public DateTime DDatum { get; set; }
        public byte[] CData { get; set; }
        public byte[] CDataRendered { get; set; }
    }
}
