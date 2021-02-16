using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class PosKonfiguration
    {
        public int KKonfiguration { get; set; }
        public int FDbschema { get; set; }
        public DateTime? DSchemaDate { get; set; }
        public string CExeVersion { get; set; }
        public DateTime? DLastUpdate { get; set; }
        public string CUpdateComputer { get; set; }
    }
}
