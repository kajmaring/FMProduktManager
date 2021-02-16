using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TVcsUploadData
    {
        public int KVcsUploadData { get; set; }
        public byte[] BData { get; set; }
        public int KBenutzer { get; set; }
        public int? KRechnung { get; set; }
        public int? KGutschrift { get; set; }
        public DateTime DErstellDatum { get; set; }
        public string CFileHash { get; set; }
        public string CFileName { get; set; }
        public int NFileSizeKb { get; set; }
        public byte NStatus { get; set; }
    }
}
