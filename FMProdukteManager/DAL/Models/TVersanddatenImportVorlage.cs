using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TVersanddatenImportVorlage
    {
        public int KVersanddatenImportVorlage { get; set; }
        public string CName { get; set; }
        public string CTrennzeichen { get; set; }
        public int NKopfzeilen { get; set; }
        public string CDatumsFormat { get; set; }
        public int NSpalteId { get; set; }
        public int NSpalteVersandDatum { get; set; }
        public int NSpalteTrackingNummer { get; set; }
        public int NSpalteVersandInfo { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
