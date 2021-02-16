using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class AmeiseImportvorlagefeldps
    {
        public int KImportVorlageFeldPs { get; set; }
        public int KImportVorlage { get; set; }
        public string CTable { get; set; }
        public string CDbname { get; set; }
        public string CPraefix { get; set; }
        public string CSuffix { get; set; }
    }
}
