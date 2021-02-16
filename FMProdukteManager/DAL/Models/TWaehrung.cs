using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TWaehrung
    {
        public int KWaehrung { get; set; }
        public string CName { get; set; }
        public string CNameHtml { get; set; }
        public decimal FFaktor { get; set; }
        public string CEamapping { get; set; }
        public byte NStandard { get; set; }
        public byte? NVorBetrag { get; set; }
        public string CTrennzeichenCent { get; set; }
        public string CTrennzeichenTausend { get; set; }
        public DateTime? DAktualisiert { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
