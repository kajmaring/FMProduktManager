using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TVersanddatenExportVorlage
    {
        public int KVersanddatenExportVorlage { get; set; }
        public string CName { get; set; }
        public string CContentXml { get; set; }
        public string CFilenameTemplate { get; set; }
        public byte NExistingFileAction { get; set; }
        public int? KAdressExportVorlage { get; set; }
        public byte NExpertenmodus { get; set; }
        public string CPathTemplate { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
