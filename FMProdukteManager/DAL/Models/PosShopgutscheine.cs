using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class PosShopgutscheine
    {
        public long KShopgutschein { get; set; }
        public long? KBon { get; set; }
        public string CBonNr { get; set; }
        public long? KKasse { get; set; }
        public DateTime? DErstellung { get; set; }
        public long? NTyp { get; set; }
        public double? FWert { get; set; }
        public string CGutscheinNummerHash { get; set; }
        public DateTime? DGutscheinErstellung { get; set; }
        public DateTime? DGutscheinGueltigkeit { get; set; }
        public byte[] CData { get; set; }
        public DateTime? DUpload { get; set; }
        public byte[] CUploadResponse { get; set; }
        public long? KBenutzer { get; set; }
        public string CBenutzer { get; set; }
        public long? KKunde { get; set; }
        public string CKunde { get; set; }
    }
}
